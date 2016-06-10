using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Infrastructure.Database.DataAccess;
using Infrastructure.Database.Extensions;
using TMF.FollowME.DataAccess.Contracts;
using TMF.FollowME.Domain.DTO;

namespace TMF.FollowME.DataAccess.Implementation
{
    public class ClienteAssuntoDal : DataContext, IClienteAssuntoDal
    {
        public ClienteAssuntoDal(string connectionName) 
            : base(connectionName)
        {
        }
        public ClienteAssunto BuscarClienteAssunto(int idClienteAssunto)
        {
            ClienteAssunto clienteAssunto;
            var parameters = new List<IDbDataParameter>
                        {
                            new SqlParameter("@idClienteAssunto", SqlDbType.Int){Value = idClienteAssunto}
                        };
            using (var reader = ExecuteReader(@"SELECT idClienteAssunto
	                                                  ,idClienteMasterData
	                                                  ,idEmpresaMasterData
	                                                  ,idFilialMasterData
	                                                  ,SlaTotal
	                                                  ,dataAtualizacao
	                                                  ,idUsuarioMasterDataAtualizacao
	                                                  ,idAssunto
                                                FROM tblClienteAssunto (NOLOCK)
                                                WHERE idClienteAssunto = @idClienteAssunto"
                                                , CommandType.Text
                                                , parameters))
            {
                clienteAssunto = reader.Map(dr => new ClienteAssunto
                {
                    IdClienteAssunto = (int)dr["idClienteAssunto"],
                    IdClienteMasterData = (int)dr["idClienteMasterData"],
                    IdEmpresaMasterData = (int)dr["idEmpresaMasterData"],
                    IdFilialMasterData = (int)dr["idFilialMasterData"],
                    SlaTotal = (int)dr["SlaTotal"],
                    DataAtualizacao = Convert.ToDateTime(dr["dataAtualizacao"]),
                    IdUsuarioMasterDataAtualizacao = (int)dr["idUsuarioMasterDataAtualizacao"],
                    IdAssunto = (int)dr["idAssunto"]
                }).FirstOrDefault();
            }

            return clienteAssunto;
        }
        public List<ClienteAssunto> BuscarClienteAssuntoPorFilial(int idFilialMasterData)
        {
            List<ClienteAssunto> listaClienteAssunto;
            var parameters = new List<IDbDataParameter>
                        {
                            new SqlParameter("@idFilialMasterData", SqlDbType.Int){Value = idFilialMasterData}
                        };
            using (var reader = ExecuteReader(@"SELECT idClienteAssunto
	                                                  ,idClienteMasterData
	                                                  ,idEmpresaMasterData
	                                                  ,idFilialMasterData
	                                                  ,SlaTotal
	                                                  ,dataAtualizacao
	                                                  ,idUsuarioMasterDataAtualizacao
	                                                  ,idAssunto
                                                FROM tblClienteAssunto (NOLOCK)
                                                WHERE idClienteAssunto = @idFilialMasterData"
                                                , CommandType.Text
                                                , parameters))
            {
                listaClienteAssunto = reader.Map(dr => new ClienteAssunto
                {
                    IdClienteAssunto = (int)dr["idClienteAssunto"],
                    IdClienteMasterData = (int)dr["idClienteMasterData"],
                    IdEmpresaMasterData = (int)dr["idEmpresaMasterData"],
                    IdFilialMasterData = (int)dr["idFilialMasterData"],
                    SlaTotal = (int)dr["SlaTotal"],
                    DataAtualizacao = Convert.ToDateTime(dr["dataAtualizacao"]),
                    IdUsuarioMasterDataAtualizacao = (int)dr["idUsuarioMasterDataAtualizacao"],
                    IdAssunto = (int)dr["idAssunto"]
                });
            }

            return listaClienteAssunto;
        }
        public List<ClienteAssunto> BuscarClienteAssuntoPorEmpresa(int idEmpresaMasterData)
        {
            List<ClienteAssunto> listaClienteAssunto;
            var parameters = new List<IDbDataParameter>
                        {
                            new SqlParameter("@idEmpresaMasterData", SqlDbType.Int){Value = idEmpresaMasterData}
                        };
            using (var reader = ExecuteReader(@"SELECT idClienteAssunto
	                                                  ,idClienteMasterData
	                                                  ,idEmpresaMasterData
	                                                  ,idFilialMasterData
	                                                  ,SlaTotal
	                                                  ,dataAtualizacao
	                                                  ,idUsuarioMasterDataAtualizacao
	                                                  ,idAssunto
                                                FROM tblClienteAssunto (NOLOCK)
                                                WHERE idClienteAssunto = @idEmpresaMasterData"
                                                , CommandType.Text
                                                , parameters))
            {
                listaClienteAssunto = reader.Map(dr => new ClienteAssunto
                {
                    IdClienteAssunto = (int)dr["idClienteAssunto"],
                    IdClienteMasterData = (int)dr["idClienteMasterData"],
                    IdEmpresaMasterData = (int)dr["idEmpresaMasterData"],
                    IdFilialMasterData = (int)dr["idFilialMasterData"],
                    SlaTotal = (int)dr["SlaTotal"],
                    DataAtualizacao = Convert.ToDateTime(dr["dataAtualizacao"]),
                    IdUsuarioMasterDataAtualizacao = (int)dr["idUsuarioMasterDataAtualizacao"],
                    IdAssunto = (int)dr["idAssunto"]
                });
            }

            return listaClienteAssunto;
        }
        public List<ClienteAssunto> BuscarClienteAssuntoPorCliente(int idClienteMasterData)
        {
            List<ClienteAssunto> listaClienteAssunto;
            var parameters = new List<IDbDataParameter>
                        {
                            new SqlParameter("@idClienteMasterData", SqlDbType.Int){Value = idClienteMasterData}
                        };
            using (var reader = ExecuteReader(@"SELECT idClienteAssunto
	                                                  ,idClienteMasterData
	                                                  ,idEmpresaMasterData
	                                                  ,idFilialMasterData
	                                                  ,SlaTotal
	                                                  ,dataAtualizacao
	                                                  ,idUsuarioMasterDataAtualizacao
	                                                  ,idAssunto
                                                FROM tblClienteAssunto (NOLOCK)
                                                WHERE idClienteAssunto = @idClienteMasterData"
                                                , CommandType.Text
                                                , parameters))
            {
                listaClienteAssunto = reader.Map(dr => new ClienteAssunto
                {
                    IdClienteAssunto = (int)dr["idClienteAssunto"],
                    IdClienteMasterData = (int)dr["idClienteMasterData"],
                    IdEmpresaMasterData = (int)dr["idEmpresaMasterData"],
                    IdFilialMasterData = (int)dr["idFilialMasterData"],
                    SlaTotal = (int)dr["SlaTotal"],
                    DataAtualizacao = Convert.ToDateTime(dr["dataAtualizacao"]),
                    IdUsuarioMasterDataAtualizacao = (int)dr["idUsuarioMasterDataAtualizacao"],
                    IdAssunto = (int)dr["idAssunto"]
                });
            }

            return listaClienteAssunto;
        }
        public ClienteAssunto BuscarClienteAssuntoPorFilial(long idFilialMasterData, int idAssunto)
        {
            ClienteAssunto clienteAssunto;
            var parameters = new List<IDbDataParameter>
                        {
                            new SqlParameter("@idFilialMasterData", SqlDbType.Int){Value = idFilialMasterData},
                            new SqlParameter("@idAssunto", SqlDbType.Int){Value = idAssunto}
                        };
            using (var reader = ExecuteReader(@"SELECT idClienteAssunto
	                                                  ,idClienteMasterData
	                                                  ,idEmpresaMasterData
	                                                  ,idFilialMasterData
	                                                  ,SlaTotal
	                                                  ,dataAtualizacao
	                                                  ,idUsuarioMasterDataAtualizacao
	                                                  ,idAssunto
                                                FROM tblClienteAssunto (NOLOCK)
                                                WHERE idFilialMasterData = @idFilialMasterData
                                                 AND idAssunto = @idAssunto"
                                                , CommandType.Text
                                                , parameters))
            {
                clienteAssunto = reader.Map(dr => new ClienteAssunto
                {
                    IdClienteAssunto = (int)dr["idClienteAssunto"],
                    IdClienteMasterData = (int)dr["idClienteMasterData"],
                    IdEmpresaMasterData = (int)dr["idEmpresaMasterData"],
                    IdFilialMasterData = (int)dr["idFilialMasterData"],
                    SlaTotal = (int)dr["SlaTotal"],
                    DataAtualizacao = Convert.ToDateTime(dr["dataAtualizacao"]),
                    IdUsuarioMasterDataAtualizacao = (int)dr["idUsuarioMasterDataAtualizacao"],
                    IdAssunto = (int)dr["idAssunto"]
                }).FirstOrDefault();
            }
            return clienteAssunto;
        }
        public ClienteAssunto BuscarClienteAssuntoPorEmpresa(int idEmpresaMasterData, int idAssunto)
        {
            ClienteAssunto clienteAssunto;
            var parameters = new List<IDbDataParameter>
                        {
                            new SqlParameter("@idEmpresaMasterData", SqlDbType.Int){Value = idEmpresaMasterData},
                            new SqlParameter("@idAssunto", SqlDbType.Int){Value = idAssunto}
                        };
            using (var reader = ExecuteReader(@"SELECT idClienteAssunto
	                                                  ,idClienteMasterData
	                                                  ,idEmpresaMasterData
	                                                  ,idFilialMasterData
	                                                  ,SlaTotal
	                                                  ,dataAtualizacao
	                                                  ,idUsuarioMasterDataAtualizacao
	                                                  ,idAssunto
                                                FROM tblClienteAssunto (NOLOCK)
                                                WHERE idClienteAssunto = @idEmpresaMasterData
                                                 AND idAssunto = @idAssunto"
                                                , CommandType.Text
                                                , parameters))
            {
                clienteAssunto = reader.Map(dr => new ClienteAssunto
                {
                    IdClienteAssunto = (int)dr["idClienteAssunto"],
                    IdClienteMasterData = (int)dr["idClienteMasterData"],
                    IdEmpresaMasterData = (int)dr["idEmpresaMasterData"],
                    IdFilialMasterData = (int)dr["idFilialMasterData"],
                    SlaTotal = (int)dr["SlaTotal"],
                    DataAtualizacao = Convert.ToDateTime(dr["dataAtualizacao"]),
                    IdUsuarioMasterDataAtualizacao = (int)dr["idUsuarioMasterDataAtualizacao"],
                    IdAssunto = (int)dr["idAssunto"]
                }).FirstOrDefault();
            }
            return clienteAssunto;
        }
        public ClienteAssunto BuscarClienteAssuntoPorCliente(int idClienteMasterData, int idAssunto)
        {
            ClienteAssunto clienteAssunto;
            var parameters = new List<IDbDataParameter>
                        {
                            new SqlParameter("@idClienteMasterData", SqlDbType.Int){Value = idClienteMasterData},
                            new SqlParameter("@idAssunto", SqlDbType.Int){Value = idAssunto}
                        };
            using (var reader = ExecuteReader(@"SELECT idClienteAssunto
	                                                  ,idClienteMasterData
	                                                  ,idEmpresaMasterData
	                                                  ,idFilialMasterData
	                                                  ,SlaTotal
	                                                  ,dataAtualizacao
	                                                  ,idUsuarioMasterDataAtualizacao
	                                                  ,idAssunto
                                                FROM tblClienteAssunto (NOLOCK)
                                                WHERE idClienteAssunto = @idClienteMasterData
                                                 AND idAssunto = @idAssunto"
                                                , CommandType.Text
                                                , parameters))
            {
                clienteAssunto = reader.Map(dr => new ClienteAssunto
                {
                    IdClienteAssunto = (int)dr["idClienteAssunto"],
                    IdClienteMasterData = (int)dr["idClienteMasterData"],
                    IdEmpresaMasterData = (int)dr["idEmpresaMasterData"],
                    IdFilialMasterData = (int)dr["idFilialMasterData"],
                    SlaTotal = (int)dr["SlaTotal"],
                    DataAtualizacao = Convert.ToDateTime(dr["dataAtualizacao"]),
                    IdUsuarioMasterDataAtualizacao = (int)dr["idUsuarioMasterDataAtualizacao"],
                    IdAssunto = (int)dr["idAssunto"]
                }).FirstOrDefault();
            }
            return clienteAssunto;
        }
    }
}
