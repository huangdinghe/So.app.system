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
        public int UsersInsertOne(Users userInfo)
        {
            Object obj = Mapper.GetMaper.Insert("Users.insert_UsersOne", userInfo);
            return (int)obj;
        }

        public Users GetUsers(int id)
        {
            return (Users)Mapper.GetMaper.QueryForObject("Users.select_UsersOne", id);
        }

        public IList<Users> GetUsersList()
        {
            //xml里面配置的格式
            return Mapper.GetMaper.QueryForList<Users>("Users.select_UsersAll", null);
        }

        public int DelUsersOne(int id)
        {
            Object obj = Mapper.GetMaper.Delete("Users.del_UsersOne", id);
            return (int)obj;
        }
        public int UpdateUsers(Users userInfo)
        {
            Object obj = Mapper.GetMaper.Update("Users.update_UsersOne", userInfo);
            return (int)obj;
        }
    }
}