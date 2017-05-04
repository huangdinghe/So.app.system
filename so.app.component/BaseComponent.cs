using IBatisNet.Common.Utilities;
using IBatisNet.DataMapper;
using IBatisNet.DataMapper.Configuration;
using so.app.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace so.app.component
{
    /// <summary>
    /// 是否可以将公共操作方法写到BaseComponent中来
    /// </summary>
    public class BaseComponent 
    {
        /// <summary>
        /// 有待封装改进
        /// </summary>
        public ISqlMapper GetMaper { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Configure(object obj)
        {
            throw new NotImplementedException();
        }

        public ISqlMapper Get()
        {
            throw new NotImplementedException();
        }

        public void InitMapper()
        {
            throw new NotImplementedException();
        }

        public ISqlMapper Instance()
        {
            throw new NotImplementedException();
        }
    }
}
