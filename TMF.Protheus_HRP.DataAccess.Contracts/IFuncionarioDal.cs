using TMF.Protheus_HRP.Domain.DTO;
namespace TMF.Protheus_HRP.DataAccess.Contracts
{
    public interface IFuncionarioDal
    {
        Funcionario BuscarFuncionario(string matricula, string pFilial, string pEmpresa);
    }
}
