using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ExpenseManagement.Utils
{
    internal class Logger
    {
        private static readonly string LogFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error_logs.json");

        public static void LogError(Exception ex)
        {
            var log = new List<object>();
            if (File.Exists(LogFilePath))
            {
                var existingLogs = JsonConvert.DeserializeObject<List<object>>(File.ReadAllText(LogFilePath)) ?? new List<object>();
                log.AddRange(existingLogs);
            }

            log.Add(new
            {
                Date = DateTime.Now,
                Message = ex.Message,
                StackTrace = ex.StackTrace
            });

            var json = JsonConvert.SerializeObject(log, Formatting.Indented);
            File.WriteAllText(LogFilePath, json);
        }

    }
}
