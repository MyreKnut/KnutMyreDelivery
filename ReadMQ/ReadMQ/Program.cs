using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMQ
{
    class Program
    {
        static void Main(string[] args)
        {
            BankCenterAdapter bankCenterAdapter = new BankCenterAdapter(ConfigurationManager.AppSettings["ConnDataCenter"]);
            var mqTableName = ConfigurationManager.AppSettings["MQTableName"];
            var forsikringTableName = ConfigurationManager.AppSettings["ForsikringTableName"];
            var bankTableName = ConfigurationManager.AppSettings["bankTableName"];
            DataTable messages = bankCenterAdapter.ReadMQDataTable("Select * from dbo." + mqTableName);
            bankCenterAdapter.UpdateSQLServerTable(messages, forsikringTableName);
            bankCenterAdapter.DeleteSQLServerTable(messages, mqTableName);
            
            if (ConfigurationManager.AppSettings["Integrasjonstest"].ToUpper() == "Y")
            {
                bankCenterAdapter.IntegrationTest(bankCenterAdapter.ReadTableList("Select * from dbo." + forsikringTableName), "Select * from dbo." + bankTableName);

            }
        }
    }
}
