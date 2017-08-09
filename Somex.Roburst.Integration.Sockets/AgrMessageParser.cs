using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Somex.Roburst.Integration.Common;

namespace Somex.Roburst.Integration.Sockets
{
    public class AgrMessageParser
    {

        public static IMessage CreateMessage(byte[] data)
        {
            if (data[0] == 0x82) {
                switch (data[1]){
                    case 0x04: //data request ack
                        return processAGRAck(data);
                    case 0x03: //data request nack
                        return processAGRNAck(data);
                    case 0x08: //cavity number
                        return processCavityNumber(data);
                    case 0x35: //status request
                        return processStatusRequest(data);     
                }
            }
            throw new MessageParseException(string.Format("Unknown data format received from client, '{0}'", data));
        }

        private static IMessage processAGRAck(byte[] data){
            if (data.Length == 7) {
                if (compareCheckSum(new byte[] { data[1], data[2], data[3], data[4] }, data[5]))
                    return new AgrAckMessage(data[4],data[3]) {SequenceNumber = data[2]};
            }
            return new AgrNAckMessage() { MessageType = MessageType.Unknown};
        }

        private static IMessage processAGRNAck(byte[] data)
        {
            if (data.Length == 7)
            {
                if (compareCheckSum(new byte[] { data[1], data[2], data[3], data[4] }, data[5]))
                    return new AgrNAckMessage(data[4], data[3]) { SequenceNumber = data[2]};
            }
            return new AgrNAckMessage() { MessageType = MessageType.Unknown };
        }

        private static IMessage processCavityNumber(byte[] data)
        {
            if (data.Length == 7)
            {
                if (compareCheckSum(new byte[] { data[1], data[2], data[3], data[4] }, data[5]))
                {
                    bool bottleNumberNotKnown = (data[3]==0x00 ? false : true);

                    return new AgrCavityNumberInputData() { SequenceNumber = data[2], CavityNumber = data[4], CommandCode = data[1],BottleNumberNotKnown = bottleNumberNotKnown };
                }
            }
            return new AgrNAckMessage() { MessageType = MessageType.Unknown };
        }

        private static IMessage processStatusRequest(byte[] data)
        {
            if (data.Length == 5)
            {
                if (compareCheckSum(new byte[] { data[1], data[2] }, data[3]))
                    return new AgrChannelStatusRequest() { SequenceNumber = data[2], CommandCode= data[1] };
            }
            return new AgrNAckMessage() { MessageType = MessageType.Unknown };
        }

        private static bool compareCheckSum(byte[] dataToCalculate, byte checkSumToCompare) {
            byte[] data = dataToCalculate;
            byte checkSumCalculated = 0;
            for (int i = 0; i < data.Length; i++) {
                checkSumCalculated += data[i];
            }
            checkSumCalculated = (byte)(checkSumCalculated & 0x7F);
            //if (checkSumCalculated == checkSumToCompare)
                return true;
           // else
            //   return false;
        }
    }
}
