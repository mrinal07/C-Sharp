using Microsoft.AspNetCore.Mvc;
using ProjectWithoutEntityFramework.Models;
using System.Data;
using System.Diagnostics;
using System.Collections.Generic;
using System;
using System.Configuration;
using System.Data.SqlClient;


namespace ProjectWithoutEntityFramework.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}