using System.Threading.Tasks;
using Abp.Application.Services;
using MAPCore.PhoneBook.Authorization.Accounts.Dto;

namespace MAPCore.PhoneBook.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
