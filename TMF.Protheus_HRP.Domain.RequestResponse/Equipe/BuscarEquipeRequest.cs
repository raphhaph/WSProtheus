﻿using System.Runtime.Serialization;
using TMF.FollowME.Domain.RequestResponse.Base;

namespace TMF.FollowME.Domain.RequestResponse.Equipe
{
    [DataContract]
    public class BuscarEquipeRequest : RequestBaseIdioma
    {
        [DataMember]
        public int IdUsuarioMasterData { get; set; }
    }
}
