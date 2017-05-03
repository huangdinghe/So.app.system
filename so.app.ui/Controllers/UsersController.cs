using so.app.component;
using so.app.domain;
using so.app.service;
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
        public ActionResult Index()
        {
            IList<Users> userInfos = service.GetUsersList();
            return View(userInfos);
        }
    }
}