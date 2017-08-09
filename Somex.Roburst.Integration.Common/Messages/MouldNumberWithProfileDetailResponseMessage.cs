using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{

    /// <summary>
    /// If Profile sent by IAFIS is 0 in the single mould response 
    /// then we need to query the profile details from the xml and return this message
    /// </summary>
    public class MouldNumberWithProfileDetailResponseMessage : MouldNumberResponseMessage
    {

        public  MouldNumberWithProfileDetailResponseMessage ()
	    {
            this.MessageType = Common.MessageType.SampleResponseWithProfileDetail;
	    }   

        public MouldNumberWithProfileDetailResponseMessage(MouldNumberResponseMessage mouldNumberResponseMessage)
            : this()
        {
            base.MouldNumber = mouldNumberResponseMessage.MouldNumber;
            base.ProfileNumber = mouldNumberResponseMessage.ProfileNumber;
        }

        public ProfileDetails ProfileDetails { get; set; } 
    }
}
