using FluentValidation;
using WebUI.Dtos.GuestDto;

namespace WebUI.ValidationRules.GuestValidation
{
    public class UpdateGuestValidator : AbstractValidator<UpdateGuestDto>
    {
        public UpdateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş bırakılamaz.");
            RuleFor(x => x.SurName).NotEmpty().WithMessage("Soyadı alanı boş bırakılamaz.");
            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir alanı boş bırakılamaz.");

            RuleFor(x => x.Name).MaximumLength(25).WithMessage("Ad alanı maksimum 25 karakter olmalıdır.");
            RuleFor(x => x.SurName).MaximumLength(50).WithMessage("Soyadı maksimum 50 karakter olmalıdır.");
            RuleFor(x => x.City).MaximumLength(15).WithMessage("Şehir maksimum 15 karakter olmalıdır.");

            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Ad alanı minimum 2 karakter olmalıdır.");
            RuleFor(x => x.SurName).MinimumLength(3).WithMessage("Soyadı minimum 3 karakter olmalıdır.");
            RuleFor(x => x.City).MinimumLength(3).WithMessage("Şehir minimum 3 karakter olmalıdır.");
        }
    }
}
