using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TMF.Protheus_HRP.Domain.RequestResponse.Models
{
    public class DadoGenerico
   {
       [DataMember]
       public string Codigo { get; set; }
       [DataMember]
       public string Descricao { get; set; }

   }
}
