using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MN_Groop_A.P.S.Repositories
{
    public class Candy : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
