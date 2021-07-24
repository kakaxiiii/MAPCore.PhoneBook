using System.Collections.Generic;
using MAPCore.PhoneBook.Roles.Dto;

namespace MAPCore.PhoneBook.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}