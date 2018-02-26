using Microsoft.AspNetCore.Antiforgery;
using RS.AbpQuick.Controllers;

namespace RS.AbpQuick.Web.Host.Controllers
{
    public class AntiForgeryController : AbpQuickControllerBase
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
