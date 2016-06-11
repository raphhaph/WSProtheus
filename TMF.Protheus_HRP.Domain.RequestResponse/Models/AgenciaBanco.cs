using System.Runtime.Serialization;

namespace TMF.Protheus_HRP.Domain.RequestResponse.Models
{
    [DataContract]
    public class AgenciaBanco
    {
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string CodigoBanco { get; set; }
        [DataMember]
        public string Descricao { get; set; }

    }
}
