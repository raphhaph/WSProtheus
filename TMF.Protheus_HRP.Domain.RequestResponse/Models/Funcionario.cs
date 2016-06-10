using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace TMF.Protheus_HRP.Domain.RequestResponse.Models
{
   public class Funcionario
   {
       [DataMember]
       public string Agencia { get; set; }
       [DataMember]
       public string AnoChegada { get; set; }
      
       [DataMember]
       public string Aposentado { get; set; }
       [DataMember]
       public string CBO { get; set; }
       [DataMember]
       public string CPF { get; set; }
       [DataMember]
       public string CTPSUF { get; set; }
       [DataMember]
       public string Cargo { get; set; }
       [DataMember]
       public string CarteiraHabilitacao { get; set; }
       [DataMember]
       public string CarteiraHabilitacaoCategoria { get; set; }
       [DataMember]
       public string CarteiraIdentidade { get; set; }
       [DataMember]
       public string CarteiraIdentidadeEmissao { get; set; }
       [DataMember]
       public string CarteiraIdentidadeUF { get; set; }
       [DataMember]
       public string CarteiraIdentidadeValidade { get; set; }
       [DataMember]
       public string CarteiraTrabalhoValidade { get; set; }
       [DataMember]
       public string CategoriaReservista { get; set; }
       [DataMember]
       public string ConjugeBrasileiro { get; set; }
       [DataMember]
       public string ContaCorrente { get; set; }
       [DataMember]
       public string DataAdmissao { get; set; }
       [DataMember]
       public string DataDemissao { get; set; }
       [DataMember]
       public string DataNascimento { get; set; }
       [DataMember]
       public string DataOpcaoFundoGarantia { get; set; }
       [DataMember]
       public string EmissaoCtps { get; set; }
       [DataMember]
       public string EstadoCivil { get; set; }
       [DataMember]
       public string EstadoNatal { get; set; }
       [DataMember]
       public string FormaPagamento { get; set; }
       [DataMember]
       public string GrauInstrucao { get; set; }
       [DataMember]
       public float Horario { get; set; }
       [DataMember]
       public float Jornada { get; set; }
       [DataMember]
       public string Matricula { get; set; }
       [DataMember]
       public string Nacionalidade { get; set; }
       [DataMember]
       public string Naturalidade { get; set; }
       [DataMember]
       public string Naturalizado { get; set; }
       [DataMember]
       public string Nome { get; set; }
       [DataMember]
       public string NomeBanc { get; set; }
       [DataMember]
       public string NomeMae { get; set; }
       [DataMember]
       public string NomePai { get; set; }
       [DataMember]
       public string NomeSindicato { get; set; }
       [DataMember]
       public string NumeroCtps { get; set; }
       [DataMember]
       public string NumeroOrdem { get; set; }
       [DataMember]
       public string NumeroReservista { get; set; }
       [DataMember]
       public string OrgaoEmissorRG { get; set; }
       [DataMember]
       public string PISPASEP { get; set; }
        [DataMember]
       public string PISPASEPEmissao { get; set; }
       [DataMember]
       public string PaisNascimento { get; set; }
       [DataMember]
       public float Salario { get; set; }
       [DataMember]
       public float SalarioHora { get; set; }
       [DataMember]
       public string Secao { get; set; }
       [DataMember]
       public string SerieCtps { get; set; }
       [DataMember]
       public string Situacao { get; set; }
       [DataMember]
       public string TipoVisto { get; set; }
       [DataMember]
       public string Sexo { get; set; }
       [DataMember]
       public string TituloEleitor { get; set; }
       [DataMember]
       public string TituloEleitorSecao { get; set; }
       [DataMember]
       public string TituloEleitorZona { get; set; }
       [DataMember]
       public string Cod_Empresa { get; set; }
       [DataMember]
       public string Cod_Filial { get; set; }
       [DataMember]
       public string Nome_Empresa { get; set; }
       [DataMember]
       public string Nome_Filial { get; set; }

   }
}
