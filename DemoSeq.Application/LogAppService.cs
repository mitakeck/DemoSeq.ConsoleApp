using DemoSeq.Application.Commands;
using DemoSeq.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoSeq.Application
{
    public class LogAppService : ILogAppService
    {
        private readonly ILogRepository _logRepository;

        public LogAppService(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }

        public Task CreateLogAsync(CreateLogCommand command)
        {
            return _logRepository.SaveAsync(new LogEntity(
                command.ID,
                command.Message,
                command.Created
            ));
        }
    }
}
