﻿using System.Runtime.Serialization;

namespace TMF.Protheus_HRP.Domain.RequestResponse.Models
{
    [DataContract]
    public class DadoGenerico
    {
        [DataMember]
        public string Codigo { get; set; }
        [DataMember]
        public string Descricao { get; set; }

    }
}
