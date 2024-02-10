using FluentValidation;
using WebUI.Dtos.SubscribeDto;

namespace WebUI.ValidationRules.SubscribeValidation
{
    public class CreateSubscribeValidator:AbstractValidator<CreateSubscribeDto>
    {
        public CreateSubscribeValidator()
        {
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş bırakılamaz.").EmailAddress().WithMessage("Geçersiz mail adresi.");
            RuleFor(x => x.Mail).MaximumLength(120).WithMessage("Mail alanı maksimum 120 karakter olabilir.").EmailAddress().WithMessage("Geçersiz mail adresi.");
            RuleFor(x => x.Mail).MinimumLength(12).WithMessage("Mail alanı minimum 12 karakter olabilir.").EmailAddress().WithMessage("Geçersiz mail adresi.");
        }
    }
}
