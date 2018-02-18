using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using SamerCs.Controllers;

namespace SamerCs.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : SamerCsControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
