using FluentValidation;
using WebUI.Dtos.RoomDto;

namespace WebUI.ValidationRules.RoomValidation
{
    public class UpdateRoomValidator : AbstractValidator<UpdateRoomDto>
    {
        public UpdateRoomValidator() 
        {
            RuleFor(x => x.RoomNumber).NotEmpty().WithMessage("Oda numarası alanı boş geçilemez");
            RuleFor(x => x.RoomCoverImage).NotEmpty().WithMessage("Oda görseli alanı boş geçilemez");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat alanı boş geçilemez");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş geçilemez");
            RuleFor(x => x.BathCount).NotEmpty().WithMessage("Banyo sayısı alanı boş geçilemez");
            RuleFor(x => x.BedCount).NotEmpty().WithMessage("Yatak sayısı alanı boş geçilemez");
            RuleFor(x => x.Wifi).NotEmpty().WithMessage("Wifi alanı boş geçilemez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklama alanı boş geçilemez");

            RuleFor(x => x.RoomNumber).MaximumLength(6).WithMessage("Oda numarası alanı maksimum 6 karakter olmalıdır.");
            RuleFor(x => x.Title).MaximumLength(20).WithMessage("Başlık alanı maksimum 20 karakter olmalıdır.");
            RuleFor(x => x.BathCount).MaximumLength(2).WithMessage("Banyo sayısı alanı maksimum 2 karakter olmalıdır.");
            RuleFor(x => x.BedCount).MaximumLength(2).WithMessage("Yatak sayısı alanı maksimum 2 karakter olmalıdır.");
            RuleFor(x => x.Wifi).MaximumLength(3).WithMessage("Wifi alanı maksimum 3 karakter olmalıdır.");
            RuleFor(x => x.Description).MaximumLength(450).WithMessage("Açıklama alanı maksimum 450 karakter olmalıdır.");

            RuleFor(x => x.RoomNumber).MinimumLength(1).WithMessage("Oda numarası alanı minimum 1 karakter olmalıdır.");
            RuleFor(x => x.Title).MinimumLength(10).WithMessage("Başlık alanı minimum 10 karakter olmalıdır.");
            RuleFor(x => x.BathCount).MinimumLength(1).WithMessage("Banyo sayısı alanı minimum 1 karakter olmalıdır.");
            RuleFor(x => x.BedCount).MinimumLength(1).WithMessage("Yatak sayısı alanı minimum 1 karakter olmalıdır.");
            RuleFor(x => x.Wifi).MinimumLength(3).WithMessage("Wifi alanı minimum 3 karakter olmalıdır.");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Açıklama alanı minimum 50 karakter olmalıdır.");

            RuleFor(x => x.Price).Must(BeAValidNumber).WithMessage("Fiyat alanı sadece sayısal değerler kabul edilmektedir.");
        }
        private bool BeAValidNumber(int value)
        {
            return value >= 0;
        }
    }
}
