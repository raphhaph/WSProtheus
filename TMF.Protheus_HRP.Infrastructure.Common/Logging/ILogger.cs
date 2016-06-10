using System;

namespace TMF.Protheus_HRP.Infrastructure.Common.Logging
{
   public interface ILogger
    {
        void LogError(string message);
        void LogException(Exception ex);
        void LogException(string message, Exception ex);
    }
}
