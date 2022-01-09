using log4net;
using log4net.Config;
using log4net.Repository;
using log4net.Repository.Hierarchy;
using System.IO;
using System.Reflection;
using System.Xml;

namespace Core.CrossCuttingConcerns.Logging.log4net
{
    public class LoggerServiceBase
    {
        private readonly ILog _log;
        public LoggerServiceBase(string name)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(File.OpenRead("log4net.config"));

            ILoggerRepository loggerRepository = LogManager.CreateRepository(Assembly.GetEntryAssembly(), typeof(Hierarchy));
            XmlConfigurator.Configure(loggerRepository, xmlDocument["log4net"]);
            _log = LogManager.GetLogger(loggerRepository.Name, name);
        }

        public bool IsInfoEnabled => _log.IsInfoEnabled;
        public bool IsDebugEnabled => _log.IsDebugEnabled;
        public bool IsWarnEnabled => _log.IsWarnEnabled;
        public bool IsFatalEnabled => _log.IsFatalEnabled;
        public bool IsErrorEnabled => _log.IsErrorEnabled;

        public void Info(object message)
        {
            if (IsInfoEnabled)
                _log.Info(message);
        }

        public void Debug(object message)
        {
            if (IsDebugEnabled)
                _log.Debug(message);
        }

        public void Warn(object message)
        {
            if (IsWarnEnabled)
                _log.Warn(message);
        }

        public void Fatal(object message)
        {
            if (IsFatalEnabled)
                _log.Fatal(message);
        }

        public void Error(object message)
        {
            if (IsErrorEnabled)
                _log.Error(message);
        }
    }
}
