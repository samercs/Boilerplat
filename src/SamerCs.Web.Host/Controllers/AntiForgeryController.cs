using Microsoft.AspNetCore.Antiforgery;
using SamerCs.Controllers;

namespace SamerCs.Web.Host.Controllers
{
    public class AntiForgeryController : SamerCsControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
