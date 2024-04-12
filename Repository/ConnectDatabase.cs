using Christoc.Modules.TuanMVC.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Christoc.Modules.TuanMVC.Repository
{
    public class ConnectDatabase : IConnectDatabase
    {

        public SqlConnection IConnectData()
        {
            try
            {
                string strcon = ConfigurationManager.ConnectionStrings["SiteSqlServer"].ConnectionString;
                SqlConnection conn = new SqlConnection(strcon);
                return conn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}