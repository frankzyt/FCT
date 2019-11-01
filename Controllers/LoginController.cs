using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FCTAssignment.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    /*    public class LoginController : Controller
        {
            // 
            // GET: /HelloWorld/

            public string Index()
            {
                return "This is my default action...";
            }

            // 
            // GET: /HelloWorld/Welcome/ 

            public string Welcome()
            {
                return "This is the Welcome action method...";
            }
        }
    */
}