using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using RS.AbpQuick.Controllers;

namespace RS.AbpQuick.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : AbpQuickControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
