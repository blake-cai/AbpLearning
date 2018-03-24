using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Learning_phone.MultiTenancy.Dto;

namespace Learning_phone.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
