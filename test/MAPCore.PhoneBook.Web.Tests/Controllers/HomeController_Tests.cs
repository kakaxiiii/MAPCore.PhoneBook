using System.Threading.Tasks;
using MAPCore.PhoneBook.Models.TokenAuth;
using MAPCore.PhoneBook.Web.Controllers;
using Shouldly;
using Xunit;

namespace MAPCore.PhoneBook.Web.Tests.Controllers
{
    public class HomeController_Tests: PhoneBookWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}