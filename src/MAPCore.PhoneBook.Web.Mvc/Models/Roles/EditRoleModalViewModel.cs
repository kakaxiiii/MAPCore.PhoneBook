using Abp.AutoMapper;
using MAPCore.PhoneBook.Roles.Dto;
using MAPCore.PhoneBook.Web.Models.Common;

namespace MAPCore.PhoneBook.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
