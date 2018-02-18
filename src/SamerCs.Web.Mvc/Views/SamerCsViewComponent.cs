using Abp.AspNetCore.Mvc.ViewComponents;

namespace SamerCs.Web.Views
{
    public abstract class SamerCsViewComponent : AbpViewComponent
    {
        protected SamerCsViewComponent()
        {
            LocalizationSourceName = SamerCsConsts.LocalizationSourceName;
        }
    }
}
