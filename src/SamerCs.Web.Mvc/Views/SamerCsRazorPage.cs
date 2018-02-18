using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace SamerCs.Web.Views
{
    public abstract class SamerCsRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected SamerCsRazorPage()
        {
            LocalizationSourceName = SamerCsConsts.LocalizationSourceName;
        }
    }
}
