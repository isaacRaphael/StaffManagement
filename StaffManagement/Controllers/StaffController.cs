using Microsoft.AspNetCore.Mvc;
using StaffManagement.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffManagement.Controllers
{
    public class StaffController : Controller
    {
        private readonly IStaffRepository _staffRepository;
        public StaffController(IStaffRepository staffRepository)
        {
            _staffRepository = staffRepository;
        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
