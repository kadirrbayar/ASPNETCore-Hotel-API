using FluentValidation;
using WebUI.Dtos.LoginDto;

namespace WebUI.ValidationRules.LoginValidation
{
    public class CreateLoginValidator:AbstractValidator<LoginDto>
    {
        public CreateLoginValidator()
        {
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez");

            RuleFor(x => x.Username).MaximumLength(120).WithMessage("Kullanıcı adı alanı maksimum 120 karakter olmalıdır.");
            RuleFor(x => x.Username).MinimumLength(5).WithMessage("Kullanıcı adı alanı minimum 5 karakter olmalıdır.");
        }
    }
}
