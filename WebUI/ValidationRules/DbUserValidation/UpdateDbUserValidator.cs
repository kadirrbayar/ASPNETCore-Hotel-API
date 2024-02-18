using FluentValidation;
using WebUI.Dtos.DbUserDto;

namespace WebUI.ValidationRules.DbUserValidation
{
    public class UpdateDbUserValidator:AbstractValidator<UpdateDbUserDto>
    {
        public UpdateDbUserValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad alanı boş geçilemez");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez").EmailAddress().WithMessage("Geçersiz mail adresi.");

            RuleFor(x => x.PasswordConfirm).Equal(x => x.Password).WithMessage("Şifreler eşleşmiyor");

            RuleFor(x => x.Username).MaximumLength(120).WithMessage("Kullanıcı adı alanı maksimum 120 karakter olmalıdır.");
            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Kullanıcı adı alanı minimum 5 karakter olmalıdır.");

            RuleFor(x => x.Name).MaximumLength(25).WithMessage("Ad alanı maksimum 25 karakter olmalıdır.");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Ad alanı minimum 2 karakter olmalıdır.");

            RuleFor(x => x.Surname).MaximumLength(30).WithMessage("Soyadı alanı maksimum 30 karakter olmalıdır.");
            RuleFor(x => x.Surname).MinimumLength(3).WithMessage("Soyadı alanı minimum 3 karakter olmalıdır.");

            RuleFor(x => x.Mail).MaximumLength(120).WithMessage("Mail alanı maksimum 120 karakter olmalıdır.");
            RuleFor(x => x.Mail).MinimumLength(12).WithMessage("Mail alanı minimum 12 karakter olmalıdır.");
        }
    }
}
