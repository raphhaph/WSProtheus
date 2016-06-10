using System;
using System.Runtime.Serialization;

namespace TMF.Protheus_HRP.Domain.RequestResponse.FaultContracts
{
    [DataContract(Namespace = "FollowME.FaultContracts")]
    public class ServiceError
    {
        public ServiceError(string errorCode, string message)
        {
            ErrorCode = errorCode;
            Message = message;
        }
        [DataMember]
        public String ErrorCode { get; private set; }
        [DataMember]
        public String Message { get; private set; }
    }
}
