﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sitecore;
using DevOpsDemo.Models;

namespace DevOpsDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //view test
            return View();
        }

        public ActionResult ShowPageDetails()
        {
            //Changes By RRB
            EmployeeBasicModel contextEmployee = new EmployeeBasicModel();
            contextEmployee.EmployeeName = Context.Item["Name"];
            contextEmployee.EmployeeSalary = Context.Item["Salary"];

            return View("~/Views/Home/ShowPageDetails.cshtml", contextEmployee);
        }
    }
}