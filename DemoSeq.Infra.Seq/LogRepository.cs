using DemoSeq.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Serilog;

namespace DemoSeq.Infra.Seq
{
    public class LogRepository : ILogRepository
    {
        public LogRepository()
        {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.Seq("http://localhost:5341")
                .CreateLogger();
        }
        public Task SaveAsync(LogEntity entity)
        {
            Log.Information("{ID}:{Message} {@Context}", entity.ID, entity.Message, @entity);

            return Task.CompletedTask;
        }
    }
}
