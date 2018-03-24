using System.Threading.Tasks;
using Abp.Application.Services;
using Learning_phone.Authorization.Accounts.Dto;

namespace Learning_phone.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
