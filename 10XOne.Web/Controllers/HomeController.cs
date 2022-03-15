using _10XOne.Infrastructure.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace _10XOne.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPartnerService _partnerService;

        public HomeController(IPartnerService partnerService)
        {
            _partnerService = partnerService;
        }

        public IActionResult Index()
        {
            var partners = _partnerService.Calculate();
            return View("Index", partners);
        }

    }
}
