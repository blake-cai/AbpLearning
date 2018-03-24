using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Learning_phone.Roles.Dto;

namespace Learning_phone.Roles
{
    public interface IRoleAppService : IAsyncCrudAppService<RoleDto, int, PagedResultRequestDto, CreateRoleDto, RoleDto>
    {
        Task<ListResultDto<PermissionDto>> GetAllPermissions();
    }
}
