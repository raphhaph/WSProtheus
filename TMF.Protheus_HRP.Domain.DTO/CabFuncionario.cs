using System;
using TMF.Protheus_HRP.Domain.DTO.Base;

namespace TMF.Protheus_HRP.Domain.DTO
{
    [Serializable]
   public class CabFuncionario:Entity
   {

        public string Agencia { get; set; }
        public string AnoChegada { get; set; }
        public string Aposentado { get; set; }
        public string CBO { get; set; }
        public string CPF { get; set; }
        public string CTPSUF { get; set; }
        public string Cargo { get; set; }
        public string CarteiraHabilitacao { get; set; }
        public string CarteiraHabilitacaoCategoria { get; set; }
        public string CarteiraIdentidade { get; set; }
        public string CarteiraIdentidadeEmissao { get; set; }

        public string CarteiraIdentidadeUF { get; set; }
        public string CarteiraIdentidadeValidade { get; set; }

        public string CarteiraTrabalhoValidade { get; set; }

        public string CategoriaReservista { get; set; }

        public string ConjugeBrasileiro { get; set; }

        public string ContaCorrente { get; set; }

        public string DataAdmissao { get; set; }

        public string DataDemissao { get; set; }

        public string DataNascimento { get; set; }

        public string DataOpcaoFundoGarantia { get; set; }

        public string EmissaoCtps { get; set; }

        public string EstadoCivil { get; set; }

        public string EstadoNatal { get; set; }

        public string FormaPagamento { get; set; }

        public string GrauInstrucao { get; set; }

        public float Horario { get; set; }

        public float Jornada { get; set; }

        public string Matricula { get; set; }

        public string Nacionalidade { get; set; }

        public string Naturalidade { get; set; }

        public string Naturalizado { get; set; }

        public string Nome { get; set; }

        public string NomeBanc { get; set; }

        public string NomeMae { get; set; }

        public string NomePai { get; set; }

        public string NomeSindicato { get; set; }

        public string NumeroCtps { get; set; }
        public string NumeroOrdem { get; set; }
        public string NumeroReservista { get; set; }

        public string OrgaoEmissorRG { get; set; }

        public string PISPASEP { get; set; }

        public string PISPASEPEmissao { get; set; }

        public string PaisNascimento { get; set; }

        public float Salario { get; set; }

        public float SalarioHora { get; set; }

        public string Secao { get; set; }

        public string SerieCtps { get; set; }

        public string Situacao { get; set; }

        public string TipoVisto { get; set; }

        public string Sexo { get; set; }

        public string TituloEleitor { get; set; }

        public string TituloEleitorSecao { get; set; }

        public string TituloEleitorZona { get; set; }

        public string Cod_Empresa { get; set; }

        public string Cod_Filial { get; set; }

        public string Nome_Empresa { get; set; }

        public string Nome_Filial { get; set; }

        
        

   }
}
