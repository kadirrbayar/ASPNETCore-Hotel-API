using FluentValidation;
using WebUI.Dtos.SendMessageDto;

namespace WebUI.ValidationRules.SendMessage
{
    public class CreateSendMessageValidator:AbstractValidator<CreateSendMessageDto>
    {
        public CreateSendMessageValidator()
        {
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("Alıcı mail adresi boş bırakılamaz.").EmailAddress().WithMessage("Geçersiz mail adresi.");
            RuleFor(x => x.ReceiverName).NotEmpty().WithMessage("Alıcı ad alanı boş bırakılamaz.");
            RuleFor(x => x.ReceiverName).MinimumLength(2).WithMessage("Alıcı ad alanı minimum 2 karakter olmalıdır.");
            RuleFor(x => x.ReceiverName).MaximumLength(25).WithMessage("Alıcı ad alanı maksimum 25 karakter olabilir.");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş bırakılamaz.");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Konu alanı minimum 5 karakter olmalıdır.");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Konu alanı maksimum 50 karakter olabilir.");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj alanı boş bırakılamaz.");
            RuleFor(x => x.Message).MinimumLength(20).WithMessage("Mesaj alanı minimum 20 karakter olmalıdır.");
            RuleFor(x => x.Message).MaximumLength(500).WithMessage("Mesaj alanı maksimum 500 karakter olabilir.");
        }
    }
}
