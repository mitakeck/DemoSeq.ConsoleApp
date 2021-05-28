using System;
using System.Collections.Generic;
using System.Text;

namespace DemoSeq.Domain
{
    public class LogEntity
    {
        private string _id;
        public string ID
        {
            get { return _id; }
            private set
            {
                _id = value;
            }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            private set
            {
                _message = value;
            }
        }

        private DateTime _created;
        public DateTime Created
        {
            get { return _created; }
            private set
            {
                _created = value;
            }
        }

        public LogEntity(string id, string message, DateTime created)
        {
            ID = id;
            Message = message;
            Created = created;
        }
    }
}
