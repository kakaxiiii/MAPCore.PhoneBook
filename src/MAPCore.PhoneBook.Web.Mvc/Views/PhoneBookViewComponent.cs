using Abp.AspNetCore.Mvc.ViewComponents;

namespace MAPCore.PhoneBook.Web.Views
{
    public abstract class PhoneBookViewComponent : AbpViewComponent
    {
        protected PhoneBookViewComponent()
        {
            LocalizationSourceName = PhoneBookConsts.LocalizationSourceName;
        }
    }
}
