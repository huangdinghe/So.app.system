using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace so.app.domain
{
    /// <summary>
    /// 收藏表
    /// </summary>
    public class Collection
    {
        public int users_id { get; set; }
        public int video_id { get; set; }
        public DateTime collection_date { get; set; }
    }
}
