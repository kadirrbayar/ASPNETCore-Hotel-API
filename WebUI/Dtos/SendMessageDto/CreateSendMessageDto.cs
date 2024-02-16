namespace WebUI.Dtos.SendMessageDto
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
