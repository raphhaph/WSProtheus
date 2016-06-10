using System;
using System.Collections.Generic;
using TMF.Protheus_HRP.Domain.DTO;



namespace TMF.Protheus_HRP.DataAccess.Contracts
{
    public interface ICabFunDal
   {

       List<MatriculaFilial> BuscarMatriculaFilial(string pMatricula, string pEmpresa, string pFilial);

       List<CabFuncionario> BuscarCabFuncionario(string pMatricula, string pEmpresa, string pFilial);
       
   }
}
