using Abp.Application.Services;
using Abp.Application.Services.Dto;
using HC.RetailClient.MultiTenancy.Dto;

namespace HC.RetailClient.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
