using System.Collections.Generic;
using System.Runtime.Serialization;
using TMF.Protheus_HRP.Domain.RequestResponse.Base;

namespace TMF.Protheus_HRP.Domain.RequestResponse.CabFunc
{
    [DataContract]
    public class ListarCabFuncionarioResponse : ResponseBase
   {
        
        [DataMember]
        public List<Models.Funcionario> ListaFuncionario { get; set; }

   }
}
