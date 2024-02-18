using FluentValidation;
using WebUI.Dtos.RoleDto;

namespace WebUI.ValidationRules.RoleValidation
{
    public class UpdateRoleValidator:AbstractValidator<UpdateRoleDto>
    {
        public UpdateRoleValidator()
        {
            RuleFor(x => x.RoleName).NotEmpty().WithMessage("Rol adı boş bırakılamaz");
            RuleFor(x => x.RoleName).MinimumLength(3).WithMessage("Rol adı minimum 3 karakter olmalıdır");
        }
    }
}
