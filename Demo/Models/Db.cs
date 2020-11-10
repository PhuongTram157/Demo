using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.SqlClient;

namespace Demo.Models
{
    public class Db: DbContext
    {
        public Db()
        {
            SqlConnectionStringBuilder sql = new SqlConnectionStringBuilder();
            sql.DataSource = "DESKTOP-12J6D6C\\SQLEXPRESS";
            sql.InitialCatalog = "Demo";  
            sql.IntegratedSecurity = true;
            Database.Connection.ConnectionString = sql.ConnectionString;
        }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
    }
}