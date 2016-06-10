using System.Collections.Generic;
using System.Runtime.Serialization;
using TMF.FollowME.Domain.RequestResponse.Base;

namespace TMF.FollowME.Domain.RequestResponse.Equipe
{
    [DataContract]
    public class BuscarEquipeResponse : ResponseBase
    {
        [DataMember]
        public List<Models.Equipe> ListaEquipe { get; set; }
    }
}
