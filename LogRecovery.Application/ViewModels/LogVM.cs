using System;
using System.ComponentModel.DataAnnotations;

namespace LogRecovery.Application.ViewModels
{
    public class LogVM
    {
        public int Id { get; set; }
        [Required]
        public string Ip { get; set; }
        [Required]
        public DateTime RecordedTime { get; set; }
        [Required]
        public string UserAgent { get; set; }
    }
}
