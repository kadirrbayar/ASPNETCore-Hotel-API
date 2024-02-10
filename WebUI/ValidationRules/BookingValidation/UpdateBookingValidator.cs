using FluentValidation;
using WebUI.Dtos.BookingDto;

namespace WebUI.ValidationRules.BookingValidation
{
    public class UpdateBookingValidator : AbstractValidator<UpdateBookingDto>
    {
        public UpdateBookingValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez.");
            RuleFor(x => x.Mail).NotEmpty().WithMessage("Mail alanı boş geçilemez.").EmailAddress().WithMessage("Geçersiz mail adresi.");

            RuleFor(x => x.Name).MaximumLength(50).WithMessage("Ad alanı maksimum 50 karakter olmalıdır.");
            RuleFor(x => x.Mail).MaximumLength(200).WithMessage("Mail alanı maksimum 200 karakter olmalıdır.").EmailAddress().WithMessage("Geçersiz mail adresi.");

            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Ad alanı minimum 2 karakter olmalıdır.");
            RuleFor(x => x.Mail).MinimumLength(12).WithMessage("Mail alanı minimum 12 karakter olmalıdır.").EmailAddress().WithMessage("Geçersiz mail adresi.");

            RuleFor(x => x.CheckIn).NotEmpty().WithMessage("Giriş tarihi alanı boş geçilemez.");
            RuleFor(x => x.CheckOut).NotEmpty().WithMessage("Çıkış tarihi alanı boş geçilemez.");

            RuleFor(x => x.AdultCount).NotEmpty().WithMessage("Yetişkin sayısı alanı boş geçilemez.");
            RuleFor(x => x.ChildCount).NotEmpty().WithMessage("Çocuk sayısı alanı boş geçilemez.");
            RuleFor(x => x.RoomCount).NotEmpty().WithMessage("Oda sayısı alanı boş geçilemez.");

            RuleFor(x => x.SpecialRequest).MaximumLength(200).WithMessage("Özel istek alanı maksimum 200 karakter olmalıdır.");
        }
    }
}
