using FluentValidation;
using FluentValidation.AspNetCore;
using WebUI.Dtos.RoleDto;

namespace WebUI.ValidationRules.RoleValidation
{
    public class CreateRoleValidator: AbstractValidator<CreateRoleDto>
    {
        public CreateRoleValidator()
        {
            RuleFor(x => x.RoleName).NotEmpty().WithMessage("Rol adı boş bırakılamaz");
            RuleFor(x => x.RoleName).MinimumLength(3).WithMessage("Rol adı minimum 3 karakter olmalıdır");
        }
    }
}
