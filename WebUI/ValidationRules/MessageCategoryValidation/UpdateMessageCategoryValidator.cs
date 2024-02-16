using FluentValidation;
using WebUI.Dtos.MessageCategoryDto;

namespace WebUI.ValidationRules.MessageCategoryValidation
{
    public class UpdateMessageCategoryValidator : AbstractValidator<UpdateMessageCategoryDto>
    {
        public UpdateMessageCategoryValidator() 
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adı boş bırakılamaz.");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Kategori adı maksimum 50 karakter olabilir");
            RuleFor(x => x.CategoryName).MinimumLength(8).WithMessage("Kategori adı minimum 8 karakter olmalıdır.");
        }
    }
}
