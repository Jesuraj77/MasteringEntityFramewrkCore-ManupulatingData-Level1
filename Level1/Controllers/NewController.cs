using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Level1.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {
            //Create a web API controller with CRUD operations.
           // a.Create a new controller
           //b.Inject DbContext and test the controller by adding read functionality.


            return View();
        }
    }
}