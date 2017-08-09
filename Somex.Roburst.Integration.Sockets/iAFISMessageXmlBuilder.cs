using Somex.Roburst.Integration.Common;
using Somex.Roburst.Integration.Sockets.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace Somex.Roburst.Integration.Sockets
{
    /// <summary>
    /// Build up various Roburst messages in XML format,  ready for sending to the Line Controller
    /// </summary>
    public class iAFISMessageXmlBuilder : IMessageBuilder
    {

        public string BuildXmlFor(IMessage message)
        {

            XmlWriterSettings ws = new XmlWriterSettings();
            ws.Indent = false;
            ws.CheckCharacters = true;
            ws.CloseOutput = true;
            ws.ConformanceLevel = ConformanceLevel.Fragment;
            ws.OmitXmlDeclaration = true;

            switch (message.MessageType)
            {
                case MessageType.StatusReesponse:
                    return BuildStatusResponseXml(ws, message as StatusResponseMessage);
                
                case MessageType.ModeResponse:
                    return BuildModeChangeResponseXml(ws, message as ModeResponseMessage);

                case MessageType.SampleRequest:
                    return BuildMouldRequest(ws, message as MouldNumberRequestMessage);

                case MessageType.SampleResponse:
                    return BuildMouldResponseXml(ws, message as MouldNumberResponseMessage);

                case MessageType.SampleResponseWithProfileDetail:
                    return BuildMouldWithProfileDetailResponseXml(ws, message as MouldNumberWithProfileDetailResponseMessage);

                case MessageType.SampleReceivedAcknowledge:
                    return BuildMouldAcknowledgeXml(ws, message as MouldNumberAcknowledgeMessage);

                case MessageType.TestResult:
                    return BuildTestResultXml(ws, message as TestResultMessage);

                case MessageType.SampleSetRequest:
                    return BuildMouldSetRequest(ws, message as MouldSetRequestMessage);

                case MessageType.SampleSetResponse:
                    return BuildMouldSetResponseXml(ws, message as MouldSetResponseMessage);

                case MessageType.SampleSetWithProfileDetailResponse:
                    return BuildMouldSetWithProfileDetailsResponseXml(ws, message as MouldSetWithProfileDetailsResponseMessage);

                case MessageType.SampleSetReceivedAcknoowledge:
                    return BuildMouldSetAcknowledgeXml(ws, message as MouldSetAcknowledgeMessage);

                default:
                    throw new ApplicationException("Unknown message type");
            }

        }

        private string BuildStatusResponseXml( XmlWriterSettings ws, StatusResponseMessage responseMessage)
        {
            StringBuilder sb = new StringBuilder();
            StringWriterWithEncoding xmlMsg = new StringWriterWithEncoding(sb, Encoding.UTF8);
            using (XmlWriter xw = XmlWriter.Create(xmlMsg, ws))
            {
                xw.WriteStartElement("status");
                    xw.WriteElementString("state", responseMessage.Status);
                    xw.WriteElementString("mode", responseMessage.Mode);
                    xw.WriteElementString("reason", responseMessage.Reason);
                xw.WriteEndElement();
                
                xw.Close();
                xmlMsg.Close();
            }

            return xmlMsg.ToString();
        }


        /// <summary>
        /// Same xml as the StatusResponse message. Keep in two seperate methods
        /// in case either change. It's minor code duplication. 
        /// </summary>
        /// <param name="ws"></param>
        /// <param name="responseMessage"></param>
        /// <returns></returns>
        private string BuildModeChangeResponseXml(XmlWriterSettings ws, ModeResponseMessage responseMessage)
        {
            StringBuilder sb = new StringBuilder();
            StringWriterWithEncoding xmlMsg = new StringWriterWithEncoding(sb, Encoding.UTF8);
            using (XmlWriter xw = XmlWriter.Create(xmlMsg, ws))
            {
                xw.WriteStartElement("status");
                    xw.WriteElementString("state", responseMessage.Status);
                    xw.WriteElementString("mode", Enum.GetName(typeof(ModesOfOperation), responseMessage.Mode));
                    xw.WriteElementString("reason", responseMessage.Reason);
                    
                xw.WriteEndElement();
                xw.Close();
                xmlMsg.Close();
            }

            return xmlMsg.ToString();
        }

        private string BuildMouldRequest(XmlWriterSettings ws, MouldNumberRequestMessage message)
        {
            return "<sampreq/>";
        }

        private string BuildMouldSetRequest(XmlWriterSettings ws, MouldSetRequestMessage message)
        {
            return "<setreq/>";
        }

        private string BuildMouldAcknowledgeXml(XmlWriterSettings ws, MouldNumberAcknowledgeMessage message)
        {
            StringBuilder sb = new StringBuilder();
            StringWriterWithEncoding xmlMsg = new StringWriterWithEncoding(sb, Encoding.UTF8);
            using (XmlWriter xw = XmlWriter.Create(xmlMsg, ws))
            {
                xw.WriteStartElement("sampack");
                    xw.WriteElementString("mould", message.MouldNumber);
                    xw.WriteElementString("profile", message.ProfileNumber);

                xw.WriteEndElement();
                
                xw.Close();
                xmlMsg.Close();
            }

            return xmlMsg.ToString();
        }


        /// <summary>
        /// This is here for testing purposes only.  iAFIS will be returning this message
        /// </summary>
        /// <param name="ws"></param>
        /// <param name="responseMessage"></param>
        /// <returns></returns>
        private string BuildMouldResponseXml(XmlWriterSettings ws, MouldNumberResponseMessage message)
        {
            StringBuilder sb = new StringBuilder();
            StringWriterWithEncoding xmlMsg = new StringWriterWithEncoding(sb, Encoding.UTF8);
            using (XmlWriter xw = XmlWriter.Create(xmlMsg, ws))
            {
                xw.WriteStartElement("samp");
                xw.WriteElementString("mould", message.MouldNumber);
                xw.WriteElementString("profile", message.ProfileNumber);

                xw.WriteEndElement();
                xw.Close();
                xmlMsg.Close();
            }

            return xmlMsg.ToString();
        }

        /// <summary>
        /// This is here for testing purposes only.  iAFIS will be returning this xml
        /// </summary>
        private string BuildMouldWithProfileDetailResponseXml(XmlWriterSettings ws, MouldNumberWithProfileDetailResponseMessage message)
        {
            StringBuilder sb = new StringBuilder();
            StringWriterWithEncoding xmlMsg = new StringWriterWithEncoding(sb, Encoding.UTF8);
            using (XmlWriter xw = XmlWriter.Create(xmlMsg, ws))
            {
                xw.WriteStartElement("samp");
                xw.WriteElementString("mould", message.MouldNumber);
                xw.WriteElementString("profile", message.ProfileNumber);
                xw.WriteElementString("bottleHeight", message.ProfileDetails.BottleHeight.ToString());
                xw.WriteElementString("bottleVolume", message.ProfileDetails.BottleVolume.ToString());
                xw.WriteElementString("dwellTime1", message.ProfileDetails.DwellTime1.ToString());
                xw.WriteElementString("dwellTime2", message.ProfileDetails.DwellTime2.ToString());
                xw.WriteElementString("finishHeight", message.ProfileDetails.FinishHeight.ToString());
                xw.WriteElementString("labelHeight", message.ProfileDetails.LabelHeight.ToString());
                xw.WriteElementString("lowBurstValue", message.ProfileDetails.LowBurstValue.ToString());
                xw.WriteElementString("neckBurstSize", message.ProfileDetails.NeckBurstSize.ToString());
                xw.WriteElementString("p60orpr", message.ProfileDetails.P60orPr.ToLower());
                xw.WriteElementString("pressuresetpoint1", message.ProfileDetails.PressureSetpoint1.ToString());
                xw.WriteElementString("pressuresetpoint2", message.ProfileDetails.PressureSetpoint2.ToString());
                xw.WriteElementString("pressureunits", message.ProfileDetails.PressureUnits.ToLower());
                xw.WriteElementString("ramprate1", message.ProfileDetails.RampRate1.ToString());
                xw.WriteElementString("ramprate2", message.ProfileDetails.RampRate2.ToString());

                xw.WriteEndElement();
                xw.Close();
                xmlMsg.Close();
            }

            return xmlMsg.ToString();
        }


        /// <summary>
        /// This is here for testing purposes only.  iAFIS will be returning this xml
        /// </summary>
        /// <param name="ws"></param>
        /// <param name="responseMessage"></param>
        /// <returns></returns>
        private string BuildMouldSetWithProfileDetailsResponseXml(XmlWriterSettings ws, MouldSetWithProfileDetailsResponseMessage message)
        {
            StringBuilder sb = new StringBuilder();
            StringWriterWithEncoding xmlMsg = new StringWriterWithEncoding(sb, Encoding.UTF8);
            using (XmlWriter xw = XmlWriter.Create(xmlMsg, ws))
            {
                xw.WriteStartElement("set");
                    xw.WriteElementString("profile", message.Profile);
                    xw.WriteElementString("bottleHeight", message.ProfileDetails.BottleHeight.ToString());
                    xw.WriteElementString("bottleVolume", message.ProfileDetails.BottleVolume.ToString());
                    xw.WriteElementString("dwellTime1", message.ProfileDetails.DwellTime1.ToString());
                    xw.WriteElementString("dwellTime2", message.ProfileDetails.DwellTime2.ToString());
                    xw.WriteElementString("finishHeight", message.ProfileDetails.FinishHeight.ToString());
                    xw.WriteElementString("labelHeight", message.ProfileDetails.LabelHeight.ToString());
                    xw.WriteElementString("lowBurstValue", message.ProfileDetails.LowBurstValue.ToString());
                    xw.WriteElementString("neckBurstSize", message.ProfileDetails.NeckBurstSize.ToString());
                    xw.WriteElementString("p60orpr", message.ProfileDetails.P60orPr.ToLower());
                    xw.WriteElementString("pressuresetpoint1", message.ProfileDetails.PressureSetpoint1.ToString());
                    xw.WriteElementString("pressuresetpoint2", message.ProfileDetails.PressureSetpoint2.ToString());
                    xw.WriteElementString("pressureunits", message.ProfileDetails.PressureUnits.ToLower());
                    xw.WriteElementString("ramprate1", message.ProfileDetails.RampRate1.ToString());
                    xw.WriteElementString("ramprate2", message.ProfileDetails.RampRate2.ToString());

                    xw.WriteElementString("setqty", message.SetQuantity.ToString());
                    xw.WriteElementString("setnum", message.SetNumber.ToString());
                    xw.WriteStartElement("setlist");

                    message.MouldNumbers.ForEach((m) =>
                    {
                        xw.WriteElementString("set", m);
                    });
                    xw.WriteEndElement();
                
                xw.WriteEndElement();
                xw.Close();
                xmlMsg.Close();
            }

            return xmlMsg.ToString();
        }

        /// <summary>
        /// This is here for testing purposes only.  iAFIS will be returning this xml
        /// </summary>
        private string BuildMouldSetResponseXml(XmlWriterSettings ws, MouldSetResponseMessage message)
        {
            StringBuilder sb = new StringBuilder();
            StringWriterWithEncoding xmlMsg = new StringWriterWithEncoding(sb, Encoding.UTF8);
            using (XmlWriter xw = XmlWriter.Create(xmlMsg, ws))
            {
                xw.WriteStartElement("set");
                xw.WriteElementString("profile", message.Profile);
                xw.WriteElementString("setqty", message.SetQuantity.ToString());
                xw.WriteElementString("setnum", message.SetNumber.ToString());
                xw.WriteStartElement("setlist");

                message.MouldNumbers.ForEach((m) =>
                {
                    xw.WriteElementString("set", m);
                });
                xw.WriteEndElement();

                xw.WriteEndElement();
                xw.Close();
                xmlMsg.Close();
            }

            return xmlMsg.ToString();
        }




        /// <summary>
        /// Build xml for Mould Set Acknowledge
        /// </summary>
        /// <param name="ws"></param>
        /// <param name="responseMessage"></param>
        /// <returns></returns>
        private string BuildMouldSetAcknowledgeXml(XmlWriterSettings ws, MouldSetAcknowledgeMessage message)
        {
            StringBuilder sb = new StringBuilder();
            StringWriterWithEncoding xmlMsg = new StringWriterWithEncoding(sb, Encoding.UTF8);
            using (XmlWriter xw = XmlWriter.Create(xmlMsg, ws))
            {
                xw.WriteStartElement("setack");
                xw.WriteElementString("profile", message.Profile);
                xw.WriteElementString("setqty", message.SetQuantity.ToString());
                xw.WriteElementString("setnum", message.SetNumber.ToString());
                xw.WriteStartElement("setlist");

                message.MouldNumbers.ForEach((m) =>
                {
                    xw.WriteElementString("set", m);
                });
                xw.WriteEndElement();

                xw.WriteEndElement();
                xw.Close();
                xmlMsg.Close();
            }

            return xmlMsg.ToString();
        }

        /// <summary>
        /// Create xml string for TestResultMessage
        /// </summary>
        /// <param name="ws"></param>
        /// <param name="responseMessage"></param>
        /// <returns></returns>
        private string BuildTestResultXml(XmlWriterSettings ws, TestResultMessage message)
        {
            StringBuilder sb = new StringBuilder();
            StringWriterWithEncoding xmlMsg = new StringWriterWithEncoding(sb, Encoding.UTF8);
            using (XmlWriter xw = XmlWriter.Create(xmlMsg, ws))
            {
                xw.WriteStartElement("test");
                    xw.WriteElementString("id", message.ID.ToString());
                    xw.WriteElementString("time", message.Time);
                    xw.WriteElementString("mould", message.Mould.ToString());
                    xw.WriteElementString("maxpress", message.MaxPressure.ToString());
                    xw.WriteElementString("pressureunit", message.PressureUnit.ToString());
                    xw.WriteElementString("pressurevalue", message.PressureValue.ToString());
                    xw.WriteElementString("burst", message.DidBurst ? "yes" : "no");
                    xw.WriteElementString("profile", message.Profile);
                    xw.WriteElementString("resultvalid", message.IsResultValid ? "yes" : "no");

                    xw.WriteStartElement("testpresslist");
                    message.TestPressureList.ForEach((v)=>  
                    {
                        xw.WriteElementString("testpress", v.ToString());
                    });
                    xw.WriteEndElement();

                    xw.WriteStartElement("testramplist");
                    message.TestRampList.ForEach((v) =>
                    {
                        xw.WriteElementString("testramp", v.ToString());
                    });
                    xw.WriteEndElement();

                    xw.WriteStartElement("testdwelllist");
                    message.TestDwellTimeList.ForEach((v) =>
                    {
                        xw.WriteElementString("testdwell", v.ToString());
                    });
                    xw.WriteEndElement();

                xw.WriteEndElement();
                xw.Close();
                xmlMsg.Close();
            }

            return xmlMsg.ToString();
        }






    }
}
