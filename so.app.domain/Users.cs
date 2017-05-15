using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace so.app.domain
{
    /// <summary>
    /// 用户实体
    /// </summary>
    public class Users : EntityBase
    {
        public int users_id { get; set; }
        public string users_name { get; set; }
        public string account { get; set; }
        public string password { get; set; }
        public bool sex { get; set; }
        public string email { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
    }
}
