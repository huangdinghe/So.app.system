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

        //spring容器帮助实例化 减少层次间的耦合  最重要的是能够将控制提供到配置文件中
        //private  UsersComponent service  { get; set; }
       //public IUsersService service { get; set; }
        // GET: Users
        public ActionResult Index()
        {
            IList<Users> userInfos = service.GetUsersList();
           // ViewBag.Users = userInfos;
            return View(userInfos);
        }
    }
}