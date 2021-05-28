using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DemoSeq.Domain
{
    public interface ILogRepository
    {
        public Task SaveAsync(LogEntity entity);
    }
}
