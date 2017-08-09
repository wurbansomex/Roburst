using Somex.Roburst.Integration.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Somex.Roburst.Integration.Sockets
{
    /// <summary>
    /// Parses incoming XML strings, determining the type of data
    /// </summary>
    public class iAFISXmlMessageParser
    {

        public static IMessage CreateMessage(string data)
        {
            // TODO: this will throw an exception if data isn't valid xml  or a message cannot be created due to
            // a breakdown in the protocol data exchanged. For example, if a non supported Mode of operation request is issued. 

            XDocument doc = XDocument.Parse(data.ToLower());
            XElement root = doc.Root;

            // add your new xml message type here and a corresponding parsing method below
            if (root.Name == "statreq")
                return new StatusRequestMessage();
            if (root.Name == "modereq")
                return CreateModeChangeRequestMessage(root.Value);
            if (root.Name == "samp")
                return CreateMouldNumberResponseMessage(doc);
            if (root.Name == "setreq")
                return CreateMouldNumberSetResponseMessage(doc);
            if (root.Name == "set")
                return CreateMouldNumberSetResponseMessage(doc);
            else
                throw new MessageParseException(string.Format("Unknown data format received from client, '{0}'", data));
        }


        /// <summary>
        /// Convert string mode to ModesOperation enum value
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        private static ModeChangeRequestMessage CreateModeChangeRequestMessage(string mode)
        {
            ModesOfOperation operation = ModesOfOperation.auto;
            if (!Enum.TryParse(mode, true, out operation))
            {
                throw new ApplicationException(string.Format("Mode string '{0}' is not supported. Supported mode values are 'auto,semi and local'", mode));
            }
            else
            {
                return new ModeChangeRequestMessage() { Mode = operation };
            }
        }

        private static MouldNumberResponseMessage CreateMouldNumberResponseMessage(XDocument doc)
        {
            // need to parse and extract the mould number
            MouldNumberResponseMessage responseMessage = new MouldNumberResponseMessage();
            responseMessage.MouldNumber = doc.Descendants("mould").First().Value;
            responseMessage.ProfileNumber = doc.Descendants("profile").First().Value;

            if (responseMessage.ProfileNumber == "0")
            {
                MouldNumberWithProfileDetailResponseMessage responseWithProfileDetailMessage = new MouldNumberWithProfileDetailResponseMessage(responseMessage);
                ProfileDetails profileDetails = new ProfileDetails();
                profileDetails.BottleHeight = Convert.ToDouble(doc.Descendants("bottleheight").First().Value);
                profileDetails.LabelHeight = Convert.ToDouble(doc.Descendants("labelheight").First().Value);
                profileDetails.FinishHeight = Convert.ToDouble(doc.Descendants("finishheight").First().Value);
                profileDetails.BottleVolume = Convert.ToDouble(doc.Descendants("bottlevolume").First().Value);
                profileDetails.LowBurstValue = Convert.ToDouble(doc.Descendants("lowburstvalue").First().Value);
                profileDetails.NeckBurstSize = Convert.ToDouble(doc.Descendants("neckgripsize").First().Value);
                profileDetails.PressureUnits = doc.Descendants("pressureunits").First().Value;
                profileDetails.P60orPr = doc.Descendants("p60orpr").First().Value;
                profileDetails.PressureSetpoint1 = Convert.ToDouble(doc.Descendants("pressuresetpoint1").First().Value);
                profileDetails.RampRate1 = Convert.ToDouble(doc.Descendants("ramprate1").First().Value);
                profileDetails.DwellTime1 = Convert.ToDouble(doc.Descendants("dwelltime1").First().Value);
                profileDetails.PressureSetpoint2 = Convert.ToDouble(doc.Descendants("pressuresetpoint2").First().Value);
                profileDetails.RampRate2 = Convert.ToDouble(doc.Descendants("ramprate2").First().Value);
                profileDetails.DwellTime2 = Convert.ToDouble(doc.Descendants("dwelltime2").First().Value);

                responseWithProfileDetailMessage.ProfileDetails = profileDetails;
                return responseWithProfileDetailMessage;
            }
            else
            {
                return responseMessage;
            }
        }


        private static MouldNumberAcknowledgeMessage CreateMouldNumberAcknowledgeMessage(XDocument doc)
        {
            // need to parse and extract the mould number
            MouldNumberAcknowledgeMessage ackMessage = new MouldNumberAcknowledgeMessage();
            ackMessage.MouldNumber = doc.Descendants("mould").First().Value;
            ackMessage.ProfileNumber = doc.Descendants("profile").First().Value;
            return ackMessage;
        }

        private static MouldSetResponseMessage CreateMouldNumberSetResponseMessage(XDocument doc)
        {
            // need to parse and extract the mould number
            MouldSetResponseMessage responseMessage = new MouldSetResponseMessage();
            responseMessage.SetNumber = Convert.ToInt32(doc.Descendants("setnum").First().Value);
            responseMessage.SetQuantity = Convert.ToInt32(doc.Descendants("setqty").First().Value);
            responseMessage.Profile = doc.Descendants("profile").First().Value;
            responseMessage.MouldNumbers = (from x in doc.Descendants("setlist").Descendants("set")
                                            select x.Value).ToList<string>();
            
            // check the profile number, a profile of 0 means the xml contains the
            // profile details also
            string profileNumber = doc.Descendants("profile").First().Value;
            if (profileNumber == "0")
            {
                MouldSetWithProfileDetailsResponseMessage responseWithProfileDetailMessage = new MouldSetWithProfileDetailsResponseMessage(responseMessage);
                ProfileDetails profileDetails = new ProfileDetails();
                profileDetails.BottleHeight = Convert.ToDouble(doc.Descendants("bottleheight").First().Value);
                profileDetails.LabelHeight = Convert.ToDouble(doc.Descendants("labelheight").First().Value);
                profileDetails.FinishHeight = Convert.ToDouble(doc.Descendants("finishheight").First().Value);
                profileDetails.BottleVolume = Convert.ToDouble(doc.Descendants("bottlevolume").First().Value);
                profileDetails.LowBurstValue = Convert.ToDouble(doc.Descendants("lowburstvalue").First().Value);
                profileDetails.NeckBurstSize = Convert.ToDouble(doc.Descendants("neckgripsize").First().Value);
                profileDetails.PressureUnits = doc.Descendants("pressureunits").First().Value;
                profileDetails.P60orPr = doc.Descendants("p60orpr").First().Value;
                profileDetails.PressureSetpoint1 = Convert.ToDouble(doc.Descendants("pressuresetpoint1").First().Value);
                profileDetails.RampRate1 = Convert.ToDouble(doc.Descendants("ramprate1").First().Value);
                profileDetails.DwellTime1 = Convert.ToDouble(doc.Descendants("dwelltime1").First().Value);
                profileDetails.PressureSetpoint2 = Convert.ToDouble(doc.Descendants("pressuresetpoint2").First().Value);
                profileDetails.RampRate2 = Convert.ToDouble(doc.Descendants("ramprate2").First().Value);
                profileDetails.DwellTime2 = Convert.ToDouble(doc.Descendants("dwelltime2").First().Value);
                
                responseWithProfileDetailMessage.ProfileDetails = profileDetails;
                
                return responseWithProfileDetailMessage;
            }
            else
            {
                return responseMessage;
            }
           
        }
    }
}
