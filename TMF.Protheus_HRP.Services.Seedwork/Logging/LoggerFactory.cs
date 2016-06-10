using TMF.Protheus_HRP.Infrastructure.Common.Logging;

namespace TMF.Protheus_HRP.Services.Seedwork.Logging
{
    internal class LoggerFactory
    {
        private static ILogger _logger;

        internal static void SetCurrent(ILogger logger)
        {
            _logger = logger;
        }
        internal static ILogger CurrentLogger
        {
            get
            {
                return _logger;
            }
        }
    }
}
