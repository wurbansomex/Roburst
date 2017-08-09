using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    /// <summary>
    /// If Profile sent by IAFIS is 0 in either the single mould response or set response messages then
    /// we need to query the profile details from the xml and return this message
    /// </summary>
    public class MouldSetWithProfileDetailsResponseMessage : MouldSetResponseMessage
    {

        public MouldSetWithProfileDetailsResponseMessage()
            : base()
        {
            this.MessageType = Common.MessageType.SampleSetWithProfileDetailResponse;
        }

        public MouldSetWithProfileDetailsResponseMessage(MouldSetResponseMessage responseMessage)
            : this()
        {
            base.MouldNumbers = responseMessage.MouldNumbers;
            base.Profile = responseMessage.Profile;
            base.SetNumber = responseMessage.SetNumber;
            base.SetQuantity = responseMessage.SetQuantity;
        }


        public ProfileDetails ProfileDetails { get; set; } 
    }
}
