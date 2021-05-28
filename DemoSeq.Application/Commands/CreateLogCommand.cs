using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSeq.Application.Commands
{
    public class CreateLogCommand
    {
        public string ID { get; set; }
        public string Message { get; set; }
        public DateTime Created { get; set; }
    }
}
