using FluentValidation;
using WebUI.Dtos.ServiceDto;

namespace WebUI.ValidationRules.ServiceValidation
{
    public class CreateServiceValidator : AbstractValidator<CreateServiceDto>
    {
        public CreateServiceValidator()
        {
            RuleFor(x => x.Icon).NotEmpty().WithMessage("İkon alanı boş bırakılamaz.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş bırakılamaz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş bırakılamaz.");
            
            RuleFor(x => x.Title).MaximumLength(50).WithMessage("Başlık alanı maksimum 50 karakter olmalıdır.");
            RuleFor(x => x.Description).MaximumLength(200).WithMessage("Açıklama alanı maksimum 200 karakter olmalıdır.");
            
            RuleFor(x => x.Title).MinimumLength(10).WithMessage("Başlık alanı minimum 10 karakter olmalıdır.");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Açıklama alanı minimum 50 karakter olmalıdır.");
        }
    }
}
