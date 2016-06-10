using System;
using System.Runtime.Serialization;
using TMF.FollowME.Domain.RequestResponse.Base;

namespace TMF.FollowME.Domain.RequestResponse.Equipe
{
    [DataContract]
    public class BuscarEquipeDoProcessoRequest : RequestBaseIdioma
    {
        [DataMember]
        public Int64 IdProcesso { get; set; }
    }
}
