using Abp.Application.Services;
using MAPCore.PhoneBook.MultiTenancy.Dto;

namespace MAPCore.PhoneBook.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

