using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TMF.Protheus_HRP.Domain.RequestResponse.Models
{
    [DataContract]
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
        [DataMember]
        public string Agencia { get; set; }
        [DataMember]

        public string Banco { get; set; }
        [DataMember]

        public List<Evento> BancoDeHoras { get; set; }
        [DataMember]

        public List<Evento> Bases { get; set; }
        [DataMember]

        public string CPF { get; set; }
        [DataMember]

        public string CargaHoraria { get; set; }
        [DataMember]

        public string Cargo { get; set; }
        [DataMember]

        public string ContaCorrente { get; set; }
        [DataMember]

        public List<Evento> Cooperativas { get; set; }
        [DataMember]

        public DateTime DataAdmissao { get; set; }
        [DataMember]

        public DateTime DataPagamento { get; set; }
        [DataMember]

        public List<Evento> Eventos { get; set; }
        [DataMember]

        public List<Evento> Informativos { get; set; }
        [DataMember]

        public string Matricula { get; set; }
        [DataMember]

        public string Nome { get; set; }
        [DataMember]

        public string QuantidadeDependentesIR { get; set; }
        [DataMember]

        public string QuantidadeDependenteSalarioFamilia { get; set; }
        [DataMember]

        public List<RecolhimentoFGTS> Recolhimentos { get; set; }
        [DataMember]

        public string Referencia { get; set; }
        [DataMember]

        public Decimal Salario { get; set; }
        [DataMember]

        public string Secao { get; set; }
        [DataMember]

        public string TipoSalario { get; set; }
        [DataMember]

        public string UnidadeOrganizacional { get; set; }
    }
}
