using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebApplication.Services;

namespace WebApplication.Controllers
{
    public class GuidController : Controller
    {
        private IGuidWrapper1 wrapper1;
        private IGuidWrapper2 wrapper2;

        public GuidController(IGuidWrapper1 wrapper1, IGuidWrapper2 wrapper2)
        {
            this.wrapper1 = wrapper1;
            this.wrapper2 = wrapper2;
        }

        [Route("/")]
        public IActionResult Index()
        {
            var list = new List<string>
            {
                this.wrapper1.GetGuid(),
                this.wrapper2.GetGuid()
            };
            return View(list);
        }
    }
}
