using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Somex.Roburst.Integration.Sockets;
using Somex.Roburst.Integration.Common;
using log4net.Config;
using System.IO;
using log4net;

namespace Integration.Test.Server
{


    public partial class Form1 : Form
    {

        private CommunicationsManager _connectionManager;
        private IMessageBuilder _messageBuilder;
        static ILog _log = LogManager.GetLogger(typeof(Form1));

        public Form1()
        {
            InitializeComponent();


            XmlConfigurator.ConfigureAndWatch(new FileInfo(".\\Log4netConfig.config"));

            _connectionManager = new CommunicationsManager("127.0.0.1", 11001, 2000);
            _messageBuilder = new iAFISMessageXmlBuilder();
            _connectionManager.MessageReceived += _connectionManager_MessageReceived;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            new Action(() => _connectionManager.Start()).BeginInvoke(null, null);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _connectionManager.Stop();
        }

        private void SendDataTimer_Tick(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                _connectionManager.SendData(this.textBox1.Text + Environment.NewLine);
            }
            catch (Exception ex)
            {
                this.textBox2.Text = ex.Message;
            }
        }


        private void _connectionManager_MessageReceived(IMessage newMessage)
        {
            _log.Info("New Message Received : " + newMessage.MessageType.ToString());

            IMessage responseMessage = null;
            switch (newMessage.MessageType)
            {
                case MessageType.StatusRequest:
                    responseMessage = new StatusResponseMessage() { Mode = "auto", Reason = "000", Status = "rdy" };
                    break; 

                case MessageType.ModeChangeRequest:
                    ModeChangeRequestMessage modeChangeMessage = newMessage as ModeChangeRequestMessage;
                    responseMessage = new ModeResponseMessage() { Mode = modeChangeMessage.Mode, Status = "rdy", Reason = "000" };
                    break; 

                default:
                    break; 

            }

            _log.Info("Is Response Message Null ? : " + responseMessage == null);

            // send this message 
            if (responseMessage == null) 
                return;

            string xml = _messageBuilder.BuildXmlFor(responseMessage);
            xml += Environment.NewLine; // eol terminating characters CR-LF

            _log.Info("Sending data " + xml);
            _connectionManager.SendData(xml); // fire and forget
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                IMessage mouldRequest = new MouldNumberRequestMessage();
                string xml = _messageBuilder.BuildXmlFor(mouldRequest);
                xml += Environment.NewLine; // eol terminating characters CR-LF
                string responseData = _connectionManager.SendData(xml, true); // fire and wait for response
                this.textBox1.Text = responseData;

                // build message from response acknowledgement

                MouldNumberResponseMessage mouldNumberResponse = (MouldNumberResponseMessage)iAFISXmlMessageParser.CreateMessage(responseData);

                // now send ack with the mould number received
                IMessage mouldAck = new MouldNumberAcknowledgeMessage() { MouldNumber = mouldNumberResponse.MouldNumber, ProfileNumber = mouldNumberResponse.ProfileNumber };
                xml = _messageBuilder.BuildXmlFor(mouldAck);
                xml += Environment.NewLine; // eol terminating characters CR-LF
                _connectionManager.SendData(xml); // fire and forget
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                IMessage testResult = new TestResultMessage()
                {
                    ID = new Random().Next(999999),
                    DidBurst = (new Random().Next(10) / 2 == 0),
                    MaxPressure = Convert.ToDecimal(new Random().NextDouble()),
                    Mould = new Random().Next(100).ToString(),
                    Profile = "99",
                    Time = DateTime.Now.ToString(),
                    PressureValue = "act",
                    PressureUnit = "bar",
                    TestDwellTimeList = new List<double>() { 10.1, 10.2 },
                    TestRampList = new List<double>() { 11.1, 11.2 },
                    TestPressureList = new List<double>() { 12.1, 12.2 }
                };

                string xml = _messageBuilder.BuildXmlFor(testResult);
                xml += Environment.NewLine; // eol terminating characters CR-LF
                string responseData = _connectionManager.SendData(xml); // fire and forget
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                IMessage mouldSetRequest = new MouldSetRequestMessage();
                string xml = _messageBuilder.BuildXmlFor(mouldSetRequest);
                xml += Environment.NewLine; // eol terminating characters CR-LF
                string responseData = _connectionManager.SendData(xml, true); // fire and wait for response
                this.textBox1.Text = responseData;

                // build message from response acknowledgement

                MouldSetResponseMessage mouldNumberSetResponse = (MouldSetResponseMessage)iAFISXmlMessageParser.CreateMessage(responseData);

                // now send ack with the mould number received
                IMessage mouldSetAck = new MouldSetAcknowledgeMessage() { MouldNumbers = mouldNumberSetResponse.MouldNumbers, Profile = mouldNumberSetResponse.Profile, SetNumber = mouldNumberSetResponse.SetNumber, SetQuantity = mouldNumberSetResponse.SetQuantity };
                xml = _messageBuilder.BuildXmlFor(mouldSetAck);
                xml += Environment.NewLine; // eol terminating characters CR-LF
                _connectionManager.SendData(xml); // fire and forget
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
