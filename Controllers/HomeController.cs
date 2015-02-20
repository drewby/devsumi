﻿using Microsoft.AspNet.Mvc;
using MvcSample.Web.Models;

namespace MvcSample.Web
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            return View(CreateUser());
        }

        public User CreateUser()
        {
            User user = new User()
            {
                Name = "Code Monkey",
                Address = "My address"
            };

            return user;
        }
    }
}