using System.Threading.Tasks;
using Abp.Application.Services;
using Learning_phone.Sessions.Dto;

namespace Learning_phone.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
