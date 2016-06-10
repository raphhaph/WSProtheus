using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Infrastructure.Database.DataAccess;
using Infrastructure.Database.Extensions;
using TMF.Protheus_HRP.DataAccess.Contracts;
using TMF.Protheus_HRP.Domain.DTO;
using System.Text;

namespace TMF.Protheus_HRP.DataAccess.Implementation
{
    public class CabFunDal : DataContext, ICabFunDal
   {

        public CabFunDal(string connectionName)
            : base(connectionName)
        { }

      public List<MatriculaFilial> BuscarMatriculaFilial(string pMatricula, string pEmpresa, string pFilial)
       {

           var parameters = new List<IDbDataParameter>
            {
                new SqlParameter("@RA_MAT", SqlDbType.VarChar){Value    = pMatricula},
                new SqlParameter("@RA_FILIAL", SqlDbType.VarChar){Value = pFilial},
            };


           StringBuilder str = new StringBuilder();

           str.Append(" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ");
           str.Append(" SELECT  Count(1) RA_MAT ");
           str.AppendFormat(" From    [TOTVS].[TMF_GLOBAL_P11].dbo.SRA{0}{1} ", pEmpresa, "0");
           str.Append(" Where   RA_MAT          =       @RA_MAT ");
           str.Append(" AND     RA_FILIAL       =       @RA_FILIAL ");
           str.Append(" AND     D_E_L_E_T_      <>      '*' ");

           using (var reader = ExecuteReader(str.ToString(), CommandType.Text, parameters))
           {
               var ListaMatriculaFilial = reader.Map(dr => new MatriculaFilial
                                                           {
                                                               D_E_L_E_T_E  = string.Empty,
                                                               RA_FILIAL    = string.Empty,
                                                               RA_Matricula = dr["RA_MAT"].ToString() 
                                                           }
                                                    );
               return ListaMatriculaFilial;
           }
       
       }


      public List<CabFuncionario> BuscarCabFuncionario(string pMatricula, string pEmpresa, string pFilial)
      {

          var parameters = new List<IDbDataParameter>
            {
                new SqlParameter("@RA_MAT", SqlDbType.VarChar){Value    = pMatricula},
                new SqlParameter("@RA_FILIAL", SqlDbType.VarChar){Value = pFilial},
            };


          StringBuilder str = new StringBuilder();

          str.Append(" SET TRANSACTION ISOLATION LEVEL READ UNCOMMITTED; ");
          str.Append(" SELECT  SUBSTRING(SRA.RA_BCDEPSA,5,5) as Agencia,  ");
          str.Append(" SUBSTRING(Isnull(SRA.RA_DATCHEG,''), 7, 2)  + '/' + SUBSTRING(Isnull(SRA.RA_DATCHEG,''), 5,2)   + '/' + SUBSTRING(Isnull(SRA.RA_DATCHEG,''), 7, 2) as AnoChegada, ");
          str.Append(" IsNull(SRA.RA_EAPOSEN,'') as Aposentado, ");
          str.Append(" SRA.RA_CBO + '-' + SRJ_Func.RJ_DESC  as CBO, ");
          str.Append(" IsNull(SRA.RA_CIC,'') as CPF, ");
          str.Append(" IsNull(SRA.RA_UFCP,'') AS CTPSUF, ");
          str.Append(" IsNull(RA_CODFUNC,'')  As Cargo, ");
          str.Append(" IsNull(RA_HABILIT,'') As CarteiraHabilitacao, ");
          str.Append(" '' As CarteiraHabilitacaoCategoria, ");
          str.Append(" IsNull(RA_RG,'') As CarteiraIdentidade, ");
          str.Append(" SUBSTRING(Isnull(SRA.RA_DTRGEXP,''), 7, 2)  + '/' + SUBSTRING(Isnull(SRA.RA_DTRGEXP,''), 5,2)   + '/' + SUBSTRING(Isnull(SRA.RA_DTRGEXP,''), 7, 2) as CarteiraIdentidadeEmissao, ");
          str.Append(" IsNull(RA_RGUF,'')  As CarteiraIdentidadeUF, ");
          str.Append(" '' As CarteiraIdentidadeValidade, ");
          str.Append(" '' As CarteiraTrabalhoValidade, ");
          str.Append(" '' As CategoriaReservista, ");
          str.Append(" '' As ConjugeBrasileiro, ");
          str.Append(" IsNull(RA_CTDEPSA,'') As ContaCorrente, ");
          str.Append(" SUBSTRING(Isnull(SRA.RA_ADMISSA,''), 7, 2)  + '/' + SUBSTRING(Isnull(SRA.RA_ADMISSA,''), 5,2)   + '/' + SUBSTRING(Isnull(SRA.RA_ADMISSA,''), 7, 2)   as DataAdmissao, ");
          str.Append(" SUBSTRING(Isnull(SRA.RA_DEMISSA,''), 7, 2)  + '/' + SUBSTRING(Isnull(SRA.RA_DEMISSA,''), 5,2)   + '/' + SUBSTRING(Isnull(SRA.RA_DEMISSA,''), 7, 2)   As DataDemissao,  ");
          str.Append(" SUBSTRING(Isnull(SRA.RA_NASC,''), 7, 2)  + '/' + SUBSTRING(Isnull(SRA.RA_NASC,''), 5,2)   + '/' + SUBSTRING(Isnull(SRA.RA_NASC,''), 7, 2)            As DataNascimento, ");
          str.Append(" SUBSTRING(Isnull(SRA.RA_OPCAO,''), 7, 2)  + '/' + SUBSTRING(Isnull(SRA.RA_OPCAO,''), 5,2)   + '/' + SUBSTRING(Isnull(SRA.RA_OPCAO,''), 7, 2)         As DataOpcaoFundoGarantia, ");
          str.Append(" SUBSTRING(Isnull(SRA.RA_DTCPEXP,''), 7, 2)  + '/' + SUBSTRING(Isnull(SRA.RA_DTCPEXP,''), 5,2)   + '/' + SUBSTRING(Isnull(SRA.RA_DTCPEXP,''), 7, 2) As EmissaoCtps, ");
          str.Append(" IsNull(SRA.RA_ESTCIVI,'') As EstadoCivil, ");
          str.Append(" IsNull(SRA.RA_NATURAL,'') As EstadoNatal, ");
          str.Append(" IsNull(SRA.RA_TIPOPGT,'')  + '/' + IsNull(SX5_26.X5_DESCRI,'') As  FormaPagamento,  ");
          str.Append(" IsNull(SRA.RA_GRINRAI,'') + '/' + IsNull(SX5_26.X5_DESCRI,'')  As    GrauInstrucao, ");
          str.Append(" 0        As Horario,   ");
          str.Append(" IsNull(SRA.RA_HRSMES,'') As  Jornada,  ");
          str.Append(" IsNull(SRA.RA_MAT,'') As Matricula,    ");
          str.AppendFormat(" IsNull(SRA.RA_NACIONA,'') {0}{1}{2}", "+ ' - ' +", "SX5_34.X5_DESCRI", " As Nacionalidade,  ");
          str.Append(" IsNull(SRA.RA_MUNNASC,'') As Naturalidade,    ");
          str.Append(" IsNull('','') As Naturalizado,   ");
          str.Append(" IsNull(SRA.RA_NOME,'') As  Nome,  ");
          str.Append(" Substring(IsNull(RA_BCDEPSA,''),1,3) + ' - ' +  SA6.A6_NOME As NomeBanc,   ");
          str.Append(" IsNull(SRA.RA_MAE,'') As  NomeMae,  ");
          str.Append(" IsNull(SRA.RA_PAI,'') As  NomePai,  ");
          str.Append(" IsNull('','') As NomeSindicato,   ");
          str.Append(" IsNull(SRA.RA_NUMCP,'') As NumeroCtps,   ");
          str.Append(" IsNull('','') As  NumeroOrdem,  ");
          str.Append(" IsNull(SRA.RA_RESERVI,'') As NumeroReservista,   ");
          str.Append(" IsNull(SRA.RA_ORGEMRG,'') As    OrgaoEmissorRG, ");
          str.Append(" IsNull(SRA.RA_PIS,'') As  PISPASEP,  ");
          str.Append(" IsNull('','') As PISPASEPEmissao,   ");
          str.Append(" IsNull(SRA.RA_NACIONA,'') As PaisNascimento,   ");
          str.Append(" IsNull(RA_SALARIO,'') As Salario,   ");
          str.Append(" Case When (SRA.RA_SALARIO Is not Null and SRA.RA_HRSMES Is not Null) Then CAST(SRA.RA_SALARIO as float) / Cast(SRA.RA_HRSMES as float) Else 0 End SalarioHora,  ");
          str.Append(" IsNull('','') As  Secao,  ");
          str.Append(" IsNull(SRA.RA_SERCP,'') As SerieCtps, ");
          str.Append(" IsNull(SRA.RA_SITFOLH,'') + ' - ' + SX5_31.X5_DESCRI  As  Situacao,  ");
          str.Append(" IsNull('','') As TipoVisto,   ");
          str.Append(" IsNull(SRA.RA_SEXO,'') + ' - ' +  CASE When SRA.RA_SEXO = 'M' Then 'Masculino' Else 'Feminino'  End Sexo, ");
          str.Append(" IsNull(RA_TITULOE,'') As TituloEleitor,   ");
          str.Append(" IsNull(RA_SECAO,'') As TituloEleitorSecao,   ");
          str.Append(" IsNull(RA_ZONASEC,'') As TituloEleitorZona,    ");
          str.AppendFormat(" '{0}' As Cod_Empresa,   ", pEmpresa);
          str.AppendFormat(" '{0}' As Cod_Filial,   ", pFilial);
          str.Append(" '' As  Nome_Empresa,  ");
          str.Append(" '' As  Nome_Filial  ");


          str.AppendFormat(" From    [TOTVS].[TMF_GLOBAL_P11].dbo.SRA{0}{1} SRA", pEmpresa, "0");
          str.AppendFormat(" Left Join    SX5{0}{1} SX5_26", pEmpresa, "0");
          str.AppendFormat(" On SX5_26.X5_CHAVE = SRA.RA_GRINRAI AND SX5_26.X5_TABELA = '26' AND D_E_L_E_T_ = ' ' AND SX5_26.X5_FILIAL  = '@RA_FILIAL'  ");
          str.AppendFormat(" Left Join    SX5{0}{1} SX5_40", pEmpresa, "0");
          str.AppendFormat(" On SX5_40.X5_CHAVE = SRA.RA_TIPOPGT AND SX5_40.X5_TABELA = '40' AND D_E_L_E_T_ = ' ' AND SX5_40.X5_FILIAL  =  '@RA_FILIAL'  ");
          str.AppendFormat(" Left Join    SX5{0}{1} SX5_31", pEmpresa, "0");
          str.AppendFormat(" On SX5_31.X5_CHAVE = SRA.RA_SITFOLH AND SX5_31.X5_TABELA = '31' AND D_E_L_E_T_ = ' ' AND SX5_31.X5_FILIAL  =  '@RA_FILIAL'  ");
          str.AppendFormat(" Left Join    SX5{0}{1} SX5_34", pEmpresa, "0");
          str.AppendFormat(" On SX5_34.X5_CHAVE = SRA.RA_NACIONA AND SX5_34.X5_TABELA = '34' AND D_E_L_E_T_ = ' ' AND SX5_34.X5_FILIAL  =  '@RA_FILIAL'  ");
          str.AppendFormat(" Left Join    SX5{0}{1} SX5_33", pEmpresa, "0");
          str.AppendFormat(" On SX5_33.X5_CHAVE = SRA.RA_ESTCIVI AND SX5_33.X5_TABELA = '33' AND D_E_L_E_T_ = ' ' AND SX5_33.X5_FILIAL  =  '@RA_FILIAL'  ");
          str.AppendFormat(" Left Join    SA6{0}{1} SA6", pEmpresa, "0");
          str.AppendFormat(" On  A6_COD = SUBSTRING(SRA.RA_BCDEPSA,1,3) AND SA6.A6_FILIAL      =  @RA_FILIAL AND D_E_L_E_T_ = ' '  ");
          str.AppendFormat(" Left Join    SRJ{0}{1} SRJ_Func", pEmpresa, "0");
          str.AppendFormat(" On  SRJ_Func.RJ_FUNCAO = SRA.RA_CODFUNC AND SRJ_Func.RJ_FILIAL     =  @RA_FILIAL AND D_E_L_E_T_ = ' '  ");
          str.AppendFormat(" Left Join    SRJ{0}{1} SRJ_CBO", pEmpresa, "0");
          str.AppendFormat(" On  SRJ_CBO.RJ_CODCBO = SRA.RA_CBO AND SRJ_CBO.RJ_FILIAL           =  @RA_FILIAL AND D_E_L_E_T_ = ' '  ");

          str.Append(" Where   SRA.RA_MAT          =       @RA_MAT ");
          str.Append(" AND     SRA.RA_FILIAL       =       @RA_FILIAL ");
          str.Append(" AND     SRA.D_E_L_E_T_      <>      '*' ");

          using (var reader = ExecuteReader(str.ToString(), CommandType.Text, parameters))
          {
              var ListaMatriculaFilial = reader.Map(dr => new CabFuncionario
              {
                  Agencia                           = dr["Agencia"].ToString(),
                  AnoChegada                        = dr["AnoChegada"].ToString(),
                  Aposentado                        = dr["Aposentado"].ToString(),
                  CBO                               = dr["CBO"].ToString(),
                  CPF                               = dr["CPF"].ToString(),
                  CTPSUF                            = dr["CTPSUF"].ToString(),
                  Cargo                             = dr["Cargo"].ToString(),
                  CarteiraHabilitacao               = dr["CarteiraHabilitacao"].ToString(),
                  CarteiraHabilitacaoCategoria      = dr["CarteiraHabilitacaoCategoria"].ToString(),
                  CarteiraIdentidade                = dr["CarteiraIdentidade"].ToString(),
                  CarteiraIdentidadeEmissao         = dr["CarteiraIdentidadeEmissao"].ToString(),
                  CarteiraIdentidadeUF              = dr["CarteiraIdentidadeUF"].ToString(),
                  CarteiraIdentidadeValidade        = dr["CarteiraIdentidadeValidade"].ToString(),
                  CarteiraTrabalhoValidade          = dr["CarteiraTrabalhoValidade"].ToString(),
                  CategoriaReservista               = dr["CategoriaReservista"].ToString(),
                  ConjugeBrasileiro                 = dr["ConjugeBrasileiro"].ToString(),
                  ContaCorrente                     = dr["ContaCorrente"].ToString(),
                  DataAdmissao                      = dr["DataAdmissao"].ToString(),
                  DataDemissao                      = dr["DataDemissao"].ToString(),
                  DataNascimento                    = dr["DataNascimento"].ToString(),
                  DataOpcaoFundoGarantia            = dr["DataOpcaoFundoGarantia"].ToString(),
                  EmissaoCtps                       = dr["EmissaoCtps"].ToString(),
                  EstadoCivil                       = dr["EstadoCivil"].ToString(),
                  EstadoNatal                       = dr["EstadoNatal"].ToString(),
                  FormaPagamento                    = dr["FormaPagamento"].ToString(),
                  GrauInstrucao                     = dr["GrauInstrucao"].ToString(),
                  Horario                           = Convert.ToSingle(dr["Horario"]),
                  Jornada                           = Convert.ToSingle(dr["Jornada"]),
                  Matricula                         = dr["Matricula"].ToString(),
                  Nacionalidade                     = dr["Nacionalidade"].ToString(),
                  Naturalidade                      = dr["Naturalidade"].ToString(),
                  Naturalizado                      = dr["Naturalizado"].ToString(),
                  Nome                              = dr["Nome"].ToString(),
                  NomeBanc                          = dr["NomeBanc"].ToString(),
                  NomeMae                           = dr["NomeMae"].ToString(),
                  NomePai                           = dr["NomePai"].ToString(),
                  NomeSindicato                     = dr["NomeSindicato"].ToString(),
                  NumeroCtps                        = dr["NumeroCtps"].ToString(),
                  NumeroOrdem                       = dr["NumeroOrdem"].ToString(),
                  NumeroReservista                  = dr["NumeroReservista"].ToString(),
                  OrgaoEmissorRG                    = dr["OrgaoEmissorRG"].ToString(),
                  PISPASEP                          = dr["PISPASEP"].ToString(),
                  PISPASEPEmissao                   = dr["PISPASEPEmissao"].ToString(),
                  PaisNascimento                    = dr["PaisNascimento"].ToString(),
                  Salario                           = Convert.ToSingle(dr["Salario"]),
                  SalarioHora                       = Convert.ToSingle(dr["SalarioHora"]),
                  Secao                             = dr["Secao"].ToString(),
                  SerieCtps                         = dr["SerieCtps"].ToString(),
                  Situacao                          = dr["Situacao"].ToString(),
                  TipoVisto                         = dr["TipoVisto"].ToString(),
                  Sexo                              = dr["Sexo"].ToString(),
                  TituloEleitor                     = dr["TituloEleitor"].ToString(),
                  TituloEleitorSecao                = dr["TituloEleitorSecao"].ToString(),
                  TituloEleitorZona                 = dr["TituloEleitorZona"].ToString(),
                  Cod_Empresa                       = dr["Cod_Empresa"].ToString(),
                  Cod_Filial                        = dr["Cod_Filial"].ToString(),
                  Nome_Empresa                      = dr["Nome_Empresa"].ToString(),
                  Nome_Filial                       = dr["Nome_Filial"].ToString(),
                  
              }
                                                   );
              return ListaMatriculaFilial;
          }

      }

   }
}
