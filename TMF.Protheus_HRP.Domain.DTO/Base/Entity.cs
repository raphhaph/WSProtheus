using System;

namespace TMF.Protheus_HRP.Domain.DTO.Base
{
    [Serializable]
    public class Entity
    {
        public object ShallowCopy()
        {
            return MemberwiseClone();
        }
    }
}
