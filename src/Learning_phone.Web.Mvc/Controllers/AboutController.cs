using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Learning_phone.Controllers;

namespace Learning_phone.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : Learning_phoneControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
