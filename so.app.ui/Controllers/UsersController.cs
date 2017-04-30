using IBatisDemo.Service;
using so.app.domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace so.app.ui.Controllers
{
    public class UsersController : Controller
    {
       IUsersService service = new UsersComponent();
        // GET: Users
        public ActionResult Index()
        {
            IList<Users> userInfos = service.GetUsersList();
           // ViewBag.Users = userInfos;
            return View(userInfos);
        }
    }
}