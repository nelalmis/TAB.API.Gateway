using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TAB.API.Gateway.Controllers
{
    [Route("api/[controller]/[action]")]
    public class AuthenticationController : Controller
    {
        public AuthenticationController()
        {

        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
