using System.Runtime.Serialization;
using TMF.Protheus_HRP.Domain.RequestResponse.Base;

namespace TMF.Protheus_HRP.Domain.RequestResponse.CabFunc
{
    [DataContract]
    public class BuscarCabFuncionarioRequest
    {

        [DataMember]
        public string Empresa { get; set; }
        
        [DataMember]
        public string Filial { get; set; }

        [DataMember]
        public string Matricula { get; set; }

        [DataMember]
        public string Usuario { get; set; }
        
        [DataMember]
        public string Senha { get; set; }



    }
}
