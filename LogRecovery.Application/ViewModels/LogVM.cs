using System;

namespace LogRecovery.Application.ViewModels
{
    public class LogVM
    {
        public int Id { get; set; }
        public string Ip { get; set; }
        public DateTime RecordedTime { get; set; }
        public string UserAgent { get; set; }
    }
}
