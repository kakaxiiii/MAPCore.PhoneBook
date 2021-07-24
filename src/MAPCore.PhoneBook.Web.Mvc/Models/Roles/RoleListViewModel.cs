using System.Collections.Generic;
using MAPCore.PhoneBook.Roles.Dto;

namespace MAPCore.PhoneBook.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
