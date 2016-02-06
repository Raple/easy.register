﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Castle.Core.Internal;
using Easy.Public.MvcSecurity;

namespace Easy.Register.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginPost(string userName, string password)
        {
            if (userName.IsNullOrEmpty() || password.IsNullOrEmpty())
            {
                return Redirect("/login/index");
            }

            var tuple = Application.ApplicationRegistry.User.Login(userName, password);
            if(tuple == null)
            {
                return Redirect("/login/index");
            }
            AuthenticateHelper.SetTicket(tuple.Item1.ToString(), null, 0, tuple.Item2);

            return Redirect("/home/index");
        }
        public ActionResult Logout()
        {
            AuthenticateHelper.DestroyTicket();
            return Redirect("/login/index");
        }
    }
}