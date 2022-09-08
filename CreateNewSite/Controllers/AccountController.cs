using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EmployeeManagement.Controllers
{
    public class AccountController : Controller
    {
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();


        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        void connectionString()
        {
            connection.ConnectionString = "";
        }

        public IActionResult Verify(Account account)
        {
            return View();
        }
    }
}
