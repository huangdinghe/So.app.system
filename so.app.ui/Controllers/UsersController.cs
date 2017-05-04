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
        #region 显示用户所有信息
        public ActionResult Index()
        {
            IList<Users> userInfos = service.GetUsersList();
            return View(userInfos);
        }
        #endregion

        #region 添加用户

        [HttpGet]
        public ActionResult UserInsert()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UserInsert(Users users)
        {
            users.UserName = Request["UserName"];
            users.Account = Request["Account"];
            users.Password = Request["Password"];
            if (service.UsersInsertOne(users) > 0)
            {
                return Redirect("Index");
            }
            else
            {
                return Content("添加失败");
            }
        }
        #endregion


    }
}