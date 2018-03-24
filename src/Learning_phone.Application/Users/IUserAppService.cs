using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Learning_phone.Roles.Dto;
using Learning_phone.Users.Dto;

namespace Learning_phone.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
