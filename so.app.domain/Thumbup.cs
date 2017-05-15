using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace so.app.domain
{
    /// <summary>
    /// 点赞表
    /// </summary>
    public class Thumbup
    {
        public int users_id { get; set; }
        public int video_id { get; set; }
        public DateTime thumbup_date { get; set; }
    }
}
