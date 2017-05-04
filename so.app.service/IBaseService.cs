using IBatisNet.DataMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace so.app.service
{
    /// <summary>
    /// 是否可以将公共操作方法写到IBaseService中来
    /// </summary>
    public interface IBaseService
    {
        void Configure(object obj);

         void InitMapper();

        //mapper 单例模式
        ISqlMapper Instance();

        ISqlMapper Get();

        /// <summary>
        /// RealMarket Mapper
        /// </summary>
        ISqlMapper GetMaper { get; set; }
       
    }
}
