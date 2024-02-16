using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoLayer.Dtos.SendMessageDto
{
    public class CreateSendMessageDto
    {
        public string? SenderName { get; set; }
        public string? SenderMail { get; set; }
        public string? ReceiverName { get; set; }
        public string? ReceiverMail { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public DateTime Date { get; set; }
    }
}
