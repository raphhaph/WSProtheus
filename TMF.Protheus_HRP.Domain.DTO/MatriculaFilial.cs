using System;
using TMF.Protheus_HRP.Domain.DTO.Base;

namespace TMF.Protheus_HRP.Domain.DTO
{
    [Serializable]
    public class MatriculaFilial : Entity
    {
        public string RA_Matricula { get; set; }
        public string RA_FILIAL { get; set; }
        public string D_E_L_E_T_E { get; set; }

    }
}
