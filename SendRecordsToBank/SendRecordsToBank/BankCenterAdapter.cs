using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendRecordsToBank
{
    public class BankCenterAdapter
    {
        private SqlConnection conn = new SqlConnection();
        private SqlCommand comm = new SqlCommand();
        private string bankCenterConn;
        
        public BankCenterAdapter(string conn)
        {
            bankCenterConn = conn;
            SetConnection(conn);
            
        }
        

        public void SetConnection(string connectionString)
        {
            conn = new SqlConnection(connectionString);
            comm.Connection = conn;
            comm.Parameters.Clear();
        }

        public void BulkInsert(string tablename, DataTable theTable)
        {

            comm.Connection.Open();

            using (SqlBulkCopy bulkCopy =
                        new SqlBulkCopy(comm.Connection))
            {
                bulkCopy.DestinationTableName = "dbo." + tablename;
                bulkCopy.BatchSize = 50;

                try
                {
                    bulkCopy.WriteToServer(theTable);
                }
                catch (Exception ex)
                {
                    throw new Exception("bulkCopy.WriteToServer(theTable) failed: " + ex.Message);
                }
                finally
                {
                    comm.Connection.Close();
                }
            }
         
        }

        public void ExecuteSQLCommand(string sql)
        {
          
            try
            {

                comm.CommandText = sql;

                comm.Connection.Open();

                comm.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception("SQL command failed. " + e.Message);
            }
            finally
            {
                comm.Connection.Close();
            }
        }     

    }

    public class ExcelRow
    {
        public string KUNDENR_ANONYMISERT { get; set; }
        public DateTime VALID_FROM_DTTM { get; set; }
        public string KUNDE_POSTNR { get; set; }
        public string KUNDE_POSTSTED { get; set; }
        public string KUNDEANSVARLIG_ID { get; set; }
        public string BANK_ID { get; set; }
        public char SAMTYKKE_FORSIKRING { get; set; }
        public char SAMTYKKE_BANK { get; set; }

    }

}
