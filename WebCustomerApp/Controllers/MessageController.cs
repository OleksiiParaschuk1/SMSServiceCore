using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WebCustomerApp.Data;
using WebCustomerApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    public class MessageController : Controller
    {
        private readonly IdentityDbContext<ApplicationUser> _identityDbContext;

        public MessageController(IdentityDbContext<ApplicationUser> identityDbContext)
        {
            _identityDbContext = identityDbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        //public IActionResult Messages()
        //{
        //    _identityDbContext.
        //}


    }
}
