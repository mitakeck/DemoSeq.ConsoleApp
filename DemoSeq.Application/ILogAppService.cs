using DemoSeq.Application.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoSeq.Application
{
    public interface ILogAppService
    {
        public Task CreateLogAsync(CreateLogCommand command);
    }
}
