using System.Runtime.Serialization;

namespace TMF.Protheus_HRP.Domain.RequestResponse.Base
{
    [DataContract]
    public class RequestResponseBase : IExtensibleDataObject
    {
        public ExtensionDataObject ExtensionData { get; set; }

    }
}
