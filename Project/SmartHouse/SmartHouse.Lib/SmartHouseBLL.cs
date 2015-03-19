using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace SmartHouse
{

    public class SmartHouseBLL
    {
        string SQLConnection = @"Data Source=smarthouse.ctxqmmzfu2jc.us-west-2.rds.amazonaws.com,1433;
                                Initial Catalog=SmartHouse;User ID=SmartHouse;Password=SmartHouse";
        protected DbContext context { get; set; }
        public SmartHouseBLL()
        {
            context = new DbContext(SQLConnection);
        }
    }
}
