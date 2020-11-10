using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Db db = new Db();
        public ActionResult Index()
        {
            Session["kh"] = null;
            return View();
        }
        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            var khachhang = db.KhachHang.SingleOrDefault(x => x.Username == username);
            Session["kh"] = khachhang;
            if (khachhang.Password == password)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}