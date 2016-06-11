using System;
using System.Collections.Generic;

namespace TMF.Protheus_HRP.Domain.DTO
{
    public class Demonstrativo
    {
        public Demonstrativo()
        {
            Eventos = new List<Evento>();
            BancoDeHoras = new List<Evento>();
            Bases = new List<Evento>();
            Cooperativas = new List<Evento>();
            Informativos = new List<Evento>();
            Recolhimentos = new List<RecolhimentoFGTS>();
        }
        public string Agencia { get; set; }

        public string Banco { get; set; }

        public List<Evento> BancoDeHoras { get; set; }

        public List<Evento> Bases { get; set; }

        public string CPF { get; set; }

        public string CargaHoraria { get; set; }

        public string Cargo { get; set; }

        public string ContaCorrente { get; set; }

        public List<Evento> Cooperativas { get; set; }

        public string DataAdmissao { get; set; }

        public string DataPagamento { get; set; }

        public List<Evento> Eventos { get; set; }

        public List<Evento> Informativos { get; set; }

        public string Matricula { get; set; }

        public string Nome { get; set; }

        public string QuantidadeDependentesIR { get; set; }

        public string QuantidadeDependenteSalarioFamilia { get; set; }

        public List<RecolhimentoFGTS> Recolhimentos { get; set; }

        public string Referencia { get; set; }

        public Decimal Salario { get; set; }

        public string Secao { get; set; }

        public string TipoSalario { get; set; }

        public string UnidadeOrganizacional { get; set; }
    }
}
