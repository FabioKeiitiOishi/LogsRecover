using System;

namespace LogRecovery.Domain.Entities
{
    public class Log
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public DateTime RecordedTime { get; set; }
        public string UserAgent { get; set; }
    }
}
