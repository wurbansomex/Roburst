using Somex.Roburst.Integration.Common;
using Somex.Roburst.Integration.Sockets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integration.TestClient
{
    public partial class Form1 : Form
    {

        Thread receiveDatathread; 

        public Form1()
        {
            InitializeComponent();

            receiveDatathread = new Thread(new ThreadStart(ReceiveData));
        }


        private Socket socket;

        private void button1_Click(object sender, EventArgs e)
        {
            ConnectToSocket();


        }


        public void ConnectToSocket()
        {

            // Connect to a remote device.
            try
            {
                // Establish the remote endpoint for the socket.
                // This example uses port 11000 on the local computer.
                IPAddress ipAddress = IPAddress.Parse(this.IPAdddressTextBox.Text);
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 11001);

                // Create a TCP/IP  socket.
                socket = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);

                // Connect the socket to the remote endpoint. Catch any errors.
                try
                {
                    socket.Connect(remoteEP);

                    MessageBox.Show("Socket connected to {0}", socket.RemoteEndPoint.ToString());


                    receiveDatathread.Start();
                    //this.SendDataTimer.Start();

                    // Release the socket.
                    // sender.Shutdown(SocketShutdown.Both);
                    // sender.Close();

                }
                catch (ArgumentNullException ane)
                {
                    MessageBox.Show(string.Format("ArgumentNullException : {0}", ane.ToString()));
                }
                catch (SocketException se)
                {
                    MessageBox.Show(string.Format("SocketException : {0}", se.ToString()));
                }
                catch (Exception e)
                {
                    MessageBox.Show(string.Format("Unexpected exception : {0}", e.ToString()));
                }

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                // Data buffer for incoming data.
                byte[] bytes = new byte[1024];

                // Encode the data string into a byte array.
                byte[] msg = Encoding.ASCII.GetBytes("<statreq/>" + Environment.NewLine);

                // Send the data through the socket.
                int bytesSent = socket.Send(msg);


            }
            catch (SocketException sex)
            {
                MessageBox.Show(sex.Message);
            }
        }

        private void SendDataTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                
                // Data buffer for incoming data.
                byte[] bytes = new byte[1024];

                // Encode the data string into a byte array.
                byte[] msg = Encoding.ASCII.GetBytes("<statreq/>" + Environment.NewLine);

                // Send the data through the socket.
                int bytesSent = socket.Send(msg);

                //// Receive the response from the remote device.
                //int bytesRec = socket.Receive(bytes);
                //Console.WriteLine("Echoed test = {0}",
                //    Encoding.ASCII.GetString(bytes, 0, bytesRec));

            }
            catch (SocketException sex)
            {
                MessageBox.Show(sex.Message);
            }
        }

        private void ReceiveData()
        {

            NetworkStream ns = new NetworkStream(socket);
            ns.ReadTimeout = 500;

            while (true)
            {

                DateTime startTime = DateTime.Now;
                byte[] bytes = new byte[1024];
                bool isEndOfData = false;
                int bytesRead = 0;
                List<byte> clientData = new List<byte>();

                do
                {
                    try
                    {
                        bytesRead = ns.Read(bytes, 0, bytes.Length);
                        if (bytesRead > 0)
                        {
                            string dataReceived = Encoding.ASCII.GetString(bytes, 0, bytesRead);


                            // take bytesRead number of bytes and append to buffer
                            clientData.AddRange(bytes.Take(bytesRead));

                            // have we reached the end of the data transmission
                            byte[] endCharacter = clientData.Skip(clientData.Count - 2).Take(2).ToArray();
                            isEndOfData = (endCharacter.SequenceEqual(Encoding.ASCII.GetBytes(Environment.NewLine)));

                            if (isEndOfData)
                            {
                                if (this.InvokeRequired)
                                {
                                    this.BeginInvoke((Action)(() =>
                                    {
                                        this.textBox1.Text = DateTime.Now + "\r\n" + dataReceived;
                                    }));


                                    if (dataReceived.Contains("<sampreq/>"))
                                    {
                                        SendMouldNumber();
                                    }

                                    if (dataReceived.Contains("<setreq/>"))
                                    {
                                        SendMouldSet();
                                    }


                                }
                                // reply back with a message
                                //socket.Send(Encoding.ASCII.GetBytes("ECHO" + Environment.NewLine));
                            }

                        }
                    }
                    catch (IOException ioe)
                    {
                        // ignore as we'll be getting continuous read time outs
                    }

                }
                while ((isEndOfData == false) & (!IsWaitTimeExceeded(startTime)));

                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
        }
        

      /// <summary>
        /// We need to wait for the IVC Camera to send an EOF delimiter. We can't wait 
        /// forever so this function checks if we've been waiting for 3 seconds
        /// </summary>
        /// <param name="startTime"></param>
        /// <returns></returns>
        private bool IsWaitTimeExceeded(DateTime startTime)
        {
            double timeDifferenceInSeconds = DateTime.Now.Subtract(startTime).TotalSeconds;
            return timeDifferenceInSeconds > 2000;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                // Data buffer for incoming data.
                byte[] bytes = new byte[1024];

                // Encode the data string into a byte array.
                byte[] msg = Encoding.ASCII.GetBytes("<modereq>semi</modereq>" + Environment.NewLine);

                // Send the data through the socket.
                int bytesSent = socket.Send(msg);

                //// Receive the response from the remote device.
                //int bytesRec = socket.Receive(bytes);
                //Console.WriteLine("Echoed test = {0}",
                //    Encoding.ASCII.GetString(bytes, 0, bytesRec));

            }
            catch (SocketException sex)
            {
                MessageBox.Show(sex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().Kill();
        }

        private void SetResponseButton_Click(object sender, EventArgs e)
        {
            SendMouldSet();
        }

        private void SendMouldSet()
        {
            MouldSetResponseMessage message = new MouldSetResponseMessage()
            {
                Profile = this.MouldNumberTextBox.Text,
                SetNumber = new Random().Next(99999),
                SetQuantity = 3,
                MouldNumbers = new List<string>() { "10", "11", "101" }
            };


            //MouldSetWithProfileDetailsResponseMessage message = new MouldSetWithProfileDetailsResponseMessage()
            //{
            //    Profile = this.MouldNumberTextBox.Text,
            //    SetNumber = new Random().Next(99999),
            //    SetQuantity = 3,
            //    MouldNumbers = new List<string>() { "10", "11", "101" },
            //    ProfileDetails = new ProfileDetails()
            //    {
            //        BottleHeight = 1,
            //        BottleVolume = 2,
            //        DwellTime1 = 3,
            //        DwellTime2 = 4,
            //        RampRate2 = 5,
            //        PressureSetpoint1 = 6,
            //        PressureUnits = "bar",
            //        RampRate1 = 7,
            //        P60orPr = "Pr",
            //        NeckBurstSize = 8,
            //        LowBurstValue = 9,
            //        FinishHeight = 10,
            //        LabelHeight = 11,
            //        PressureSetpoint2 = 12

            //    }
            //};
            string xml = new iAFISMessageXmlBuilder().BuildXmlFor(message) + Environment.NewLine;
            socket.Send(Encoding.ASCII.GetBytes(xml));
        }

        private void SendMouldNumber()
        {
            //MouldNumberWithProfileDetailResponseMessage message = new MouldNumberWithProfileDetailResponseMessage() { MouldNumber = new Random().Next(99).ToString(), ProfileNumber = this.MouldNumberTextBox.Text };
            //message.ProfileDetails = new ProfileDetails()
            //{
            //    BottleHeight = 1,
            //    BottleVolume = 2,
            //    DwellTime1 = 3,
            //    DwellTime2 = 4,
            //    RampRate2 = 5,
            //    PressureSetpoint1 = 6,
            //    PressureUnits = "bar",
            //    RampRate1 = 7,
            //    P60orPr = "Pr",
            //    NeckBurstSize = 8,
            //    LowBurstValue = 9,
            //    FinishHeight = 10,
            //    LabelHeight = 11,
            //    PressureSetpoint2 = 12

            //};

            MouldNumberResponseMessage message = new MouldNumberResponseMessage() { MouldNumber = new Random().Next(99).ToString(), ProfileNumber = this.MouldNumberTextBox.Text };
     
            string xml = new iAFISMessageXmlBuilder().BuildXmlFor(message) + Environment.NewLine;
            socket.Send(Encoding.ASCII.GetBytes(xml));
        }
    }
}
