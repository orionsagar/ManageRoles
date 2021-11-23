using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ManageRoles.Algorithm;

namespace ManageRoles.Controllers
{
    public class PasswordController : Controller
    {
        // GET: Password
        public ActionResult Index()
        {
            AesAlgorithm aesAlgorithm = new AesAlgorithm();
            var storedpassword = aesAlgorithm.DecryptString("07ikhQIubF3dXMDo3glk5A==");
            Console.WriteLine("Password: " + storedpassword);
            return View();
        }
    }
}