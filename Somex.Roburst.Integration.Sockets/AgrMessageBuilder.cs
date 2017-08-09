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
    public class AgrMessageBuilder
    {
        private byte _seqNumber = 0;
        public byte SeqNumber { get { return _seqNumber; } set { _seqNumber = value; } }

        public byte[] BuildForSerial(IMessage message)
        {

            switch (message.MessageType) 
            {
                case MessageType.CavityNumberDataRequest:
                    return BuildCavityNumberDataRequest(message as AgrCavityNumberDataRequest);
                case MessageType.AckMessage:
                    return BuildAckMessage(message as AgrAckMessage);
                case MessageType.NAckMessage:
                    return BuildNAckMessage(message as AgrNAckMessage);
                case MessageType.PressureTestOutput:
                    return BuildPressureTestOutput(message as AgrPressureTestOutput);
                default:
                    throw new ApplicationException("Uknown message");
            }

        }

        public byte[] BuildForSerial(IMessage message, byte seqNumber) 
        {
            _seqNumber = seqNumber;
            return BuildForSerial(message);
        }

        private byte[] BuildCavityNumberDataRequest(AgrCavityNumberDataRequest message)
        {
            incSeqNumber();

            byte start = 0x82;
            byte commandCode = 0x34;
            byte sequenceNumber =(byte) (0x7F & _seqNumber);
            byte checkSum = (byte)((commandCode + sequenceNumber) & 0x7F);
            byte stop = 0x83;

            return new byte[] { start, commandCode, sequenceNumber, checkSum, stop };
        }

        private byte[] BuildAckMessage(AgrAckMessage message)
        {
            incSeqNumber();

            byte start = 0x82;
            byte commandCode = 0x04;
            byte sequenceNumber = (byte)(0x7F & _seqNumber);
            byte commandCodeGood = message.RequestedCommandCode;
            byte sequenceGood = message.RequestedSequenceNumber;
            byte checkSum = (byte)((commandCode + sequenceNumber + commandCodeGood + sequenceGood) & 0x7F);
            byte stop = 0x83;

            return new byte[] { start, commandCode, sequenceNumber, commandCodeGood, sequenceGood, checkSum, stop };
        }

        private byte[] BuildNAckMessage(AgrNAckMessage message)
        {
            incSeqNumber();

            byte start = 0x82;
            byte commandCode = 0x03;
            byte sequenceNumber = (byte)(0x7F & _seqNumber);
            byte commandCodeBad = message.RequestedCommandCode;
            byte sequenceBad = message.RequestedSequenceNumber;
            byte checkSum = (byte)((commandCode + sequenceNumber + commandCodeBad + sequenceBad) & 0x7F);
            byte stop = 0x83;

            return new byte[] { start, commandCode, sequenceNumber, commandCodeBad, sequenceBad, checkSum, stop };
        }

        private byte[] BuildPressureTestOutput(AgrPressureTestOutput message)
        {
            incSeqNumber();

            byte start = 0x82;
            byte commandCode = 0x31;
            byte sequenceNumber = (byte)(0x7F & _seqNumber);
            byte statusWord = message.StatusWord;
            byte cavityNumberUpper = createCavityNumberUpper(message.CavityNumber);
            byte cavityNumberLower = (byte)( message.CavityNumber & 0x7F);
            int maxPressure = message.getPressure(10);
            byte maxPressureUpper = (byte)((maxPressure >> 7) & 0x07);
            byte maxPressureLower = (byte)(maxPressure & 0x7F);
            byte checkSum = (byte)((commandCode + sequenceNumber + statusWord + cavityNumberUpper + cavityNumberLower
                + maxPressureUpper + maxPressureLower) & 0x7F);
            byte stop = 0x83;

            return new byte[]{start,commandCode,sequenceNumber,statusWord,cavityNumberUpper,cavityNumberLower,
                maxPressureUpper,maxPressureLower,0x00,0x00,checkSum,stop};
        }

        private byte createCavityNumberUpper(int cavityNumber) 
        {
            //if (cavityNumber == 127)
            //    return 0x20;
            //else if (cavityNumber == 0)
            //    return 0x30;
            //else
                return 0x00;

        }

        private void incSeqNumber()
        {
            ++_seqNumber;
            if (_seqNumber >= 0x7F)
              _seqNumber = 0;
        }
    }
}
