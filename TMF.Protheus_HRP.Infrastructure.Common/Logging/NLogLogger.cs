using System;
using NLog;

namespace TMF.Protheus_HRP.Infrastructure.Common.Logging
{
    public class NLogLogger : ILogger
    {
        #region ILogger Members

        private readonly Logger _appExLogger;

        public NLogLogger()
        {
            _appExLogger = LogManager.GetLogger("AppExceptionLog");
        }
        public void LogError(string message)
        {
            _appExLogger.Error(message);
        }

        public void LogException(Exception ex)
        {
            _appExLogger.Error(ex);
        }
        public void LogException(string message, Exception ex)
        {
            _appExLogger.Error(message, ex);
        }
        #endregion
    }
}
