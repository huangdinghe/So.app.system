using IBatisNet.DataMapper;
using IBatisNet.DataMapper.MappedStatements;
using IBatisNet.DataMapper.Scope;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace so.app.manager
{
        /// <summary>
        /// BaseManager 基础数据访问类
        /// </summary>
        public abstract partial class BaseManager
        {
            private ISqlMapper _sqlMapper;

            /// <summary>
            /// SqlMapper 属性
            /// </summary>
            public ISqlMapper SqlMapper
            {
                get { return this._sqlMapper; }
                set { this._sqlMapper = value; }
            }

            protected IDbCommand GetDbCommand(string tag, object paramObject)
            {
                IMappedStatement statement = SqlMapper.GetMappedStatement(tag);
                if (!SqlMapper.IsSessionStarted)
                {
                    SqlMapper.OpenConnection();
                }
                RequestScope request = statement.Statement.Sql.GetRequestScope(statement, paramObject, SqlMapper.LocalSession);
                statement.PreparedCommand.Create(request, SqlMapper.LocalSession, statement.Statement, paramObject);

                IDbCommand command = SqlMapper.LocalSession.CreateCommand(CommandType.Text);
                command.CommandText = request.IDbCommand.CommandText;
                foreach (IDataParameter pa in request.IDbCommand.Parameters)
                {
                    IDbDataParameter para = SqlMapper.LocalSession.CreateDataParameter();
                    para.ParameterName = pa.ParameterName;
                    para.Value = pa.Value;
                    command.Parameters.Add(para);
                }
                return command;
            }

            public DataSet QueryForDataSet(string tag, object paramObject)
            {
                DataSet ds = new DataSet();
                IDbCommand command = GetDbCommand(tag, paramObject);
                SqlMapper.LocalSession.CreateDataAdapter(command).Fill(ds);
                return ds;
            }


        }

        /// <summary>
        /// Add 
        /// </summary>
        public abstract partial class BaseManagerEx : BaseManager
        {
            protected virtual int GetCount(string statementId, Hashtable @params)
            {
                return this.SqlMapper.QueryForObject<int>(statementId, @params);
            }
        }
    
}
