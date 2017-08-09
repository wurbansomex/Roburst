using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    /// <summary>
    /// Message sent to iAFIS at the end of each cycle
    /// </summary>
    public class TestResultMessage : IMessage
    {
        public MessageType MessageType
        {
            get { return Common.MessageType.TestResult; }
            set { }
        }


        public int ID { get; set; }

        /// <summary>
        /// Format yyyy-mm-ddThh:mm:ss
        /// </summary>
        public string Time { get; set; } 
        public string Mould { get; set; }
        public decimal MaxPressure { get; set; }
        public string PressureUnit { get; set; }
        public string PressureValue { get; set; }
        public bool DidBurst { get; set; }
        public string Profile { get; set; }
        public bool IsResultValid { get; set; } 

        /// <summary>
        /// Test Pressure Setpoint Stage 1 and 2
        /// </summary>
        public List<double> TestPressureList { get; set; } 

        /// <summary>
        /// Test Pressure Ramp Rate Stage 1 and 2
        /// </summary>
        public List<double> TestRampList { get; set; }

        /// <summary>
        /// Test Pressure Dwell Time for Stage 1 and 2
        /// </summary>
        public List<double> TestDwellTimeList { get; set; } 


    }
}