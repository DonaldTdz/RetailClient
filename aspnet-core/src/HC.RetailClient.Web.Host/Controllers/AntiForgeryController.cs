using Microsoft.AspNetCore.Antiforgery;
using HC.RetailClient.Controllers;

namespace HC.RetailClient.Web.Host.Controllers
{
    public class AntiForgeryController : RetailClientControllerBase
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
