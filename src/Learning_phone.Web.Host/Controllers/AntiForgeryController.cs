using Microsoft.AspNetCore.Antiforgery;
using Learning_phone.Controllers;

namespace Learning_phone.Web.Host.Controllers
{
    public class AntiForgeryController : Learning_phoneControllerBase
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
