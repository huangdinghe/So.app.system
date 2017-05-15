using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace so.app.domain
{
    /// <summary>
    /// 视频实体
    /// </summary>
    public class Video
    {
        public int video_id { get; set; }
        public string video_name { get; set; }
        public string video_category { get; set; }
        public string url { get; set; }
        public string author { get; set; }
        public int classification_id { get; set; }
    }
}
