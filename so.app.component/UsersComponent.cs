using so.app.domain;
using so.app.manager;
using so.app.service;
using System;
using System.Collections.Generic;

namespace so.app.component
{
    /// <summary>
    /// Users的具体实现IUsersService的方法
    /// </summary>
    public class UsersComponent : IUsersService
    {
        //数据的操作应该要在dal层 固没在此处写具体实现的方法 而是多了一层调用
        UsersManager usersmanager = new UsersManager();
        public int UsersInsertOne(Users userInfo)
        {
            return usersmanager.UsersInsertOne(userInfo);
        }

        public Users GetUsers(int id)
        {
            return usersmanager.GetUsers(id);          
        }

        public IList<Users> GetUsersList()
        {
            return usersmanager.GetUsersList();
        }

        public int DelUsersOne(int id)
        {
            return usersmanager.DelUsersOne(id);
        }
        public int UpdateUsers(Users userInfo)
        {
            return usersmanager.UpdateUsers(userInfo);
        }
    }
}