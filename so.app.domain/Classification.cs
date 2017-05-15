using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace so.app.domain
{
    /// <summary>
    /// 分类表
    /// </summary>
  public  class Classification
    {
        public int classification_id { get; set; }
        public int parent_id { get; set; }
        public string classification_name { get; set; }

    }
}
