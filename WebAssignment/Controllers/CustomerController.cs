﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAssignment.Models;

namespace WebAssignment.Controllers
{
    public class CustomerController : Controller
    {
        DAO dao = new DAO();
        // GET: Customer
        public ActionResult Register()
        {
            return View("");
        }

        [HttpPost]
        public ActionResult Register(CustomerLogin customer)
        {
            int count = 0;
            if(ModelState.IsValid)
            {
                count = dao.InsertCustomer(customer);
                if (count == 1)
                    ViewData["message"] = "User record is created successfully";
                else ViewData["message"] = "Error! " + dao.message;
                return View("");
            }
            return View(customer);
        }
      
        public ActionResult Login()
        {
            return View();
        }

        /*[HttpPost]
        public ActionResult Login(CustomerLogin customer)
        {
            ModelState.Remove("FirstName");
            ModelState.Remove("LastName");
            ModelState.Remove("Email");
            ModelState.Remove("ConfirmPassword");
            if(ModelState.IsValid)
            {

            }
        }*/
    }
}