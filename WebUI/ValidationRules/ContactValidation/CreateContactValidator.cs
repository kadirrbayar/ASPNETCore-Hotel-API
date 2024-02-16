using FluentValidation;
using WebUI.Dtos.ContactDto;

namespace WebUI.ValidationRules.ContactValidation
{
    public class CreateContactValidator : AbstractValidator<CreateContactDto>
    {
        public CreateContactValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş bırakılamaz.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş bırakılamaz.").EmailAddress().WithMessage("Geçersiz mail adresi.");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj alanı boş bırakılamaz.");
            
            RuleFor(x => x.Name).MaximumLength(25).WithMessage("Ad alanı maksimum 25 karakter olmalıdır.");
            RuleFor(x => x.Mail).MaximumLength(120).WithMessage("Mail alanı maksimum 120 karakter olmalıdır.").EmailAddress().WithMessage("Geçersiz mail adresi.");
            RuleFor(x => x.Message).MaximumLength(200).WithMessage("Mesaj alanı maksimum 200 karakter olmalıdır.");
            
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Ad alanı minimum 2 karakter olmalıdır.");
            RuleFor(x => x.Mail).MinimumLength(12).WithMessage("Mail alanı minimum 12 karakter olmalıdır.").EmailAddress().WithMessage("Geçersiz mail adresi.");
            RuleFor(x => x.Message).MinimumLength(50).WithMessage("Mesaj alanı minimum 50 karakter olmalıdır.");
        }
    }
}
