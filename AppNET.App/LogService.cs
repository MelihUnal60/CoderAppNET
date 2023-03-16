using AppNET.Domain.Entities.LogAggregate;
using AppNET.Domain.Interfaces;
using AppNET.Infrastructure;
using AppNET.Infrastructure.IOToTXT;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace AppNET.App
{
    public class LogService : ILogService
    {
        
        public static List<Log> logList = new List<Log>();
        private readonly IRepository<Log> logRepository;

        public LogService()
        {
            logRepository = IOCContainer.Resolve<IRepository<Log>>();
        }

        public void ErrorLog(string message)
        {
            Log errorLog = new Log(LogType.Error, message);
            errorLog._logDate = DateTime.Now;
            logList.Add(errorLog);
            SaveLog(errorLog._logType, message);
        }

        public List<Log> GetLogList()
        {
            return logList;
        }

        public void InfoLog(string message)
        {
            Log infoLog = new Log(LogType.Information, message);
            infoLog._logDate = DateTime.Now;
            logList.Add(infoLog);
            SaveLog(infoLog._logType, message);
            
        }

        public void SaveLog(LogType logType,string logMessage)
        {
            //var log = new Log(logType, logMessage);
            //var jsonLog = JsonSerializer.Serialize(log, new JsonSerializerOptions { IncludeFields = true });
            Log log = new Log(logType,logMessage);
            log._logDate= DateTime.Now;
            
            
            WriteLogToTxt(log,ConsFileRoad.LOG_DOSYA_YOLU);
            
        }
        public void WriteLogToTxt(Log log,string fileRoad)
        {
            File.WriteAllText(ConsFileRoad.LOG_DOSYA_YOLU, JsonSerializer.Serialize(log));
        }

        public void SuccessLog(string message)
        {
            Log successLog = new Log(LogType.Success, message);
            successLog._logDate = DateTime.Now;
            logList.Add(successLog);
            SaveLog(successLog._logType, message);
        }
    }

    
}
