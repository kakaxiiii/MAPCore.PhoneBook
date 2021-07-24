using System.Threading.Tasks;
using Abp.Application.Services;
using MAPCore.PhoneBook.Sessions.Dto;

namespace MAPCore.PhoneBook.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
