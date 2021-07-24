using System.Threading.Tasks;
using MAPCore.PhoneBook.Configuration.Dto;

namespace MAPCore.PhoneBook.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
