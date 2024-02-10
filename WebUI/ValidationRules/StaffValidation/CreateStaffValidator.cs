using FluentValidation;
using WebUI.Dtos.StaffDto;

namespace WebUI.ValidationRules.StaffValidation
{
    public class CreateStaffValidator:AbstractValidator<CreateStaffDto>
    {
        public CreateStaffValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş bırakılamaz.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş bırakılamaz.");
            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Ad alanı maksimum 50 karakter olabilir.");
            RuleFor(x => x.Title).MaximumLength(100).WithMessage("Başlık alanı maksimum 100 karakter olabilir.");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Ad alanı minimum 2 karakter olmalıdır.");
            RuleFor(x => x.Title).MinimumLength(10).WithMessage("Başlık alanı minimum 10 karakter olmalıdır.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Görsel alanı boş bırakılamaz.");
        }
    }
}
