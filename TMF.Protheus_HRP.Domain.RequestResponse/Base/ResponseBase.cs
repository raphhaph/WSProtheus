using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TMF.Protheus_HRP.Domain.RequestResponse.Base
{
    [DataContract]
    public class ResponseBase : RequestResponseBase
    {
        public ResponseBase()
        {
            BusinessErrors = new List<string>();
            IsValid = true;
        }

        /// <summary>
        /// The property holds message from business validations.
        /// </summary>
        [DataMember]
        public List<string> BusinessErrors { get; set; }

        /// <summary>
        /// Is true when a business error happens.
        /// </summary>
        [DataMember]
        public bool IsValid { get; set; }
    }
}
