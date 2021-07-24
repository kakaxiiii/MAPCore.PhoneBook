using System.Collections.Generic;
using MAPCore.PhoneBook.Roles.Dto;

namespace MAPCore.PhoneBook.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
