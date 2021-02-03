using LogRecovery.Domain.Models;
using System;

namespace LogRecovery.Domain.Entities
{
    public class Log : Entity
    {
        public string Ip { get; set; }
        public DateTime RecordedTime { get; set; }
        public string UserAgent { get; set; }
    }
}
