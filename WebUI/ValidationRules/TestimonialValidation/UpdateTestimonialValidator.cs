using FluentValidation;
using WebUI.Dtos.TestimonialDto;

namespace WebUI.ValidationRules.TestimonialValidation
{
    public class UpdateTestimonialValidator: AbstractValidator<UpdateTestimonialDto>
    {
        public UpdateTestimonialValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez.");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez.");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Görsel alanı boş geçilemez.");

            RuleFor(x => x.Name).MaximumLength(25).WithMessage("Ad alanı maksimum 25 karakter olmalıdır.");
            RuleFor(x => x.Title).MaximumLength(120).WithMessage("Başlık alanı maksimum 120 karakter olmalıdır.");
            RuleFor(x => x.Description).MaximumLength(300).WithMessage("Açıklama alanı maksimum 300 karakter olmalıdır.");

            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Ad alanı minimum 2 karakter olmalıdır.");
            RuleFor(x => x.Title).MinimumLength(25).WithMessage("Başlık alanı minimum 25 karakter olmalıdır.");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Açıklama alanı minimum 50 karakter olmalıdır.");
        }
    }
}
