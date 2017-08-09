using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Somex.Roburst.Integration.Common
{

    [Serializable, XmlRoot(ElementName = "roburst_profiles")]
    public class RoburstProfiles
    {
        [XmlElement("last_edit_date")]
        public string LastEditedOn { get; set; }
        [XmlArray(ElementName = "profiles")]
        [XmlArrayItem(typeof(ProfileDetails), ElementName = "profile")]
        public List<ProfileDetails> Profiles { get; set; } 

    }

    /// <summary>
    /// Profile details sent by iAFIS with the <see cref="MouldSetResponseMessage"/> or <see cref="MouldNumberResponseMessage"/> messages />
    /// </summary>
    /// 
    [XmlType("profile")]
    public class ProfileDetails
    {
        [XmlElement("uid")]
        public long UID { get; set; } 
        [XmlElement("name")]
        public string Name { get; set; }
        [XmlElement("number")]
        public string Number { get; set; }
        [XmlElement("line_number")]
        public int LineNumber { get; set; } 
        [XmlElement("bottle_height")]
        public double BottleHeight { get; set; }
        [XmlElement("label_height")]
        public double LabelHeight { get; set; }
        [XmlElement("finish_height")]
        public double FinishHeight { get; set; }
        [XmlElement("bottle_volume")]
        public double BottleVolume { get; set; }
        [XmlElement("low_burst_value")]
        public double LowBurstValue { get; set; }
        [XmlElement("neck_burst_size")]
        public double NeckBurstSize { get; set; }
        [XmlElement("pressure_units")]
        public string PressureUnits { get; set; }
        [XmlElement("p60_or_pr")]
        public string P60orPr { get; set; }
        [XmlElement("pressure_setpoint1")]
        public double PressureSetpoint1 { get; set; }
        [XmlElement("ramp_rate1")]
        public double RampRate1 { get; set; }
        [XmlElement("dwell_time1")]
        public double DwellTime1 { get; set; }
        [XmlElement("pressure_setpoint2")]
        public double PressureSetpoint2 { get; set; }
        [XmlElement("ramp_rate2")]
        public double RampRate2 { get; set; }
        [XmlElement("dwell_time2")]
        public double DwellTime2 { get; set; }
        [XmlElement("container_place_height_adjustment")]
        public double ContainerPlaceHeightAdjustment { get; set; }

        /// <summary>
        /// Copies the properties of this object to an existing instance
        /// </summary>
        /// <param name="instance"></param>
        /// <returns></returns>
        public ProfileDetails CopyTo(ProfileDetails instance)
        {
            instance.BottleHeight = this.BottleHeight;
            instance.BottleVolume = this.BottleVolume;
            instance.ContainerPlaceHeightAdjustment = this.ContainerPlaceHeightAdjustment;
            instance.DwellTime1 = this.DwellTime1;
            instance.DwellTime2 = this.DwellTime2;
            instance.FinishHeight = this.FinishHeight;
            instance.LabelHeight = this.LabelHeight;
            instance.LineNumber = this.LineNumber;
            instance.LowBurstValue = this.LowBurstValue;
            instance.Name = this.Name;
            instance.NeckBurstSize = this.NeckBurstSize;
            instance.Number = this.Number;
            instance.P60orPr = this.P60orPr;
            instance.PressureSetpoint1 = this.PressureSetpoint1;
            instance.PressureSetpoint2 = this.PressureSetpoint2;
            instance.PressureUnits = this.PressureUnits;
            instance.RampRate1 = this.RampRate1;
            instance.RampRate2 = this.RampRate2;

            return instance;
        }


    }


    

}
