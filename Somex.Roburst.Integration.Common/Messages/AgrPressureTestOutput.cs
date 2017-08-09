using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Somex.Roburst.Integration.Common
{
    public class AgrPressureTestOutput:IMessage
    {
        private bool _validData = false;
        private bool _terminateLevelReached = false;
        private bool _leakOccured = false;
        private bool _carrouselNotIndexing = false;
        private bool _criticalAlarm = false;

        public byte StatusWord { get; private set; }
        public byte SequenceNumber { get; set; }
        public double PressureReached { get; set; }
        public int CavityNumber { get; set; }


        public MessageType MessageType
        {
            get { return Common.MessageType.PressureTestOutput; }
            set { }

        }

        public AgrPressureTestOutput(int mouldNumber, decimal maxPressure, bool burst, bool isResultValid, bool isEndOfStroke,
            bool carouselNotIndexing, bool criticalAlarm, bool statusRequest = false)
        {
            CavityNumber = mouldNumber;
            PressureReached = (double)maxPressure;
            _validData = isResultValid;
            _terminateLevelReached = isEndOfStroke;
            _carrouselNotIndexing = carouselNotIndexing;
            _criticalAlarm = criticalAlarm;
            StatusWord = buildStatusWord(statusRequest);
        }

        private byte buildStatusWord(bool statusRequest)
        {
            if (_criticalAlarm)
                return 0x06;
            else if (_carrouselNotIndexing)
                return 0x05;
            else if ((!_validData || CavityNumber == 127 || CavityNumber == 0) & statusRequest == false)
                return 0x04;
            else if ((_terminateLevelReached || _leakOccured) & statusRequest == false)
                return 0x02;
            else
                return 0x01;       
        }

        public int getPressure(int multiplier)
        {
            return (int)(PressureReached * multiplier);
        }

    }
}
