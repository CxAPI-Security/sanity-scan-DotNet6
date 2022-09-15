using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


/*TODO: this is not supported yey*/
namespace sanity_project_csharp.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ILogger<TeacherController> _logger;

        public TeacherController(ILogger<TeacherController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return Content("This is a test");
        }

        public IActionResult Privacy()
        {
            return Content("This is a privacy view");
        }

        public string Test()
        {
            return "The test of all tests";
        }
    }
}
