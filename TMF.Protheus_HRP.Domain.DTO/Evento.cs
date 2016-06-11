using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMF.Protheus_HRP.Domain.DTO
{
    public class Evento
    {
       
        public string CodigoRubrica { get; set; }
       
        public string DescricaoRubrica { get; set; }

        public Decimal Quantidade { get; set; }
       
        public Decimal Valor { get; set; }

        public Decimal Desconto { get; set; }
       
        public string Base { get; set; }
    }
}
