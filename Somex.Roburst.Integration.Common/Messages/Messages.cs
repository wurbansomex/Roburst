using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Somex.Roburst.Integration.Common
{
    /// <summary>
    /// KCarey 23 July 2015
    /// </summary>
    public enum MessageType
    {
        StatusRequest,
        StatusReesponse,
        ModeChangeRequest,
        ModeResponse,
        SampleRequest,
        SampleResponse,
        SampleResponseWithProfileDetail,
        SampleReceivedAcknowledge,
        TestResult,
        SampleSetRequest,
        SampleSetResponse,
        SampleSetWithProfileDetailResponse,
        SampleSetReceivedAcknoowledge,
        Unknown,
        //AGR Messages
        CavityNumberDataRequest,
        AckMessage,
        NAckMessage,
        CavityNumberInputData,
        ChannelStatusRequest,
        PressureTestOutput,
    }
}
