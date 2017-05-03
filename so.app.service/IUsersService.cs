using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using so.app.domain;
using so.app.manager;

namespace so.app.service
{
    /// <summary>
    /// 封装Users的操作接口
    /// </summary>
    public interface IUsersService
    {
        
        int UsersInsertOne(Users userInfo);

        Users GetUsers(int id);


        IList<Users> GetUsersList();

        int DelUsersOne(int id);

        int UpdateUsers(Users userInfo);
    }
}