using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace dotnetapi.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        // GET: /
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] {
                "Welcome to this web API",
                "Developed with ASP.NET using C#",
                "Deployed on Azure cloud",
            };
        }
    }
}

