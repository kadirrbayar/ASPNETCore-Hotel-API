using FluentValidation;
using WebUI.Dtos.AboutDto;

namespace WebUI.ValidationRules.AboutValidation
{
    public class UpdateAboutValidator : AbstractValidator<UpdateAboutDto>
    {
        public UpdateAboutValidator()
        {
            RuleFor(x => x.Title1).NotEmpty().WithMessage("Başlık alanı boş geçilemez.");
            RuleFor(x => x.Title2).NotEmpty().WithMessage("Başlık2 alanı boş geçilemez.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez.");
            RuleFor(x => x.Title1).MaximumLength(20).WithMessage("Başlık alanı maksimum 20 karakter olmalıdır.");
            RuleFor(x => x.Title2).MaximumLength(20).WithMessage("Başlık2 alanı maksimum 20 karakter olmalıdır.");
            RuleFor(x => x.Description).MaximumLength(120).WithMessage("Açıklama alanı maksimum 120 karakter olmalıdır.");
            RuleFor(x => x.Title1).MinimumLength(10).WithMessage("Başlık alanı minimum 10 karakter olmalıdır.");
            RuleFor(x => x.Title2).MinimumLength(10).WithMessage("Başlık2 alanı minimum 10 karakter olmalıdır.");
            RuleFor(x => x.Description).MinimumLength(25).WithMessage("Açıklama alanı minimum 25 karakter olmalıdır.");
            RuleFor(x => x.RoomCount).Must(BeAValidNumber).WithMessage("Sadece sayı bilgisi girilmelidir.");
            RuleFor(x => x.StaffCount).Must(BeAValidNumber).WithMessage("Sadece sayı bilgisi girilmelidir.");
            RuleFor(x => x.CustomerCount).Must(BeAValidNumber).WithMessage("Sadece sayı bilgisi girilmelidir.");
        }

        private bool BeAValidNumber(int value)
        {
            return value >= 0;
        }
    }
}
