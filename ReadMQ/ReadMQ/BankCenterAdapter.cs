using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMQ
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

        public DataTable ReadTableList(string sql)
        {

            DataTable table = new DataTable("MyTable");
            table.Columns.Add(new DataColumn("KUNDENR_ANONYMISERT", typeof(string)));
            table.Columns.Add(new DataColumn("VALID_FROM_DTTM", typeof(DateTime)));
            table.Columns.Add(new DataColumn("KUNDE_POSTNR", typeof(string)));
            table.Columns.Add(new DataColumn("KUNDE_POSTSTED", typeof(string)));
            table.Columns.Add(new DataColumn("KUNDEANSVARLIG_ID", typeof(string)));
            table.Columns.Add(new DataColumn("BANK_ID", typeof(string)));
            table.Columns.Add(new DataColumn("SAMTYKKE_FORSIKRING", typeof(char)));
            table.Columns.Add(new DataColumn("SAMTYKKE_BANK", typeof(char)));
            
            try
            {

                comm.CommandText = sql;

                comm.Connection.Open();

                SqlDataReader cursor = comm.ExecuteReader();
                var addValues = new object[cursor.FieldCount];
                while (cursor.Read())
                {
               
                    addValues[0] = cursor["KUNDENR_ANONYMISERT"].ToString();
                    addValues[1] = cursor["VALID_FROM_DTTM"];
                    addValues[2] = cursor["KUNDE_POSTNR"].ToString();
                    addValues[3] = cursor["KUNDE_POSTSTED"].ToString();
                    addValues[4] = cursor["KUNDEANSVARLIG_ID"].ToString();
                    addValues[5] = cursor["BANK_ID"].ToString();
                    addValues[6] = cursor["SAMTYKKE_FORSIKRING"];
                    addValues[7] = cursor["SAMTYKKE_BANK"];

                    table.Rows.Add(addValues);
                }
                
                return table;

            }
            catch (Exception e)
            {
                throw new Exception("Read from table failed. " + e.Message);
            }
            finally
            {
                comm.Connection.Close();
            }
        }

        public void IntegrationTest(DataTable forsikringTable, string sql)
        {

            DataTable table = new DataTable("MyTable");
            table.Columns.Add(new DataColumn("KUNDENR_ANONYMISERT", typeof(string)));
            table.Columns.Add(new DataColumn("VALID_FROM_DTTM", typeof(DateTime)));
            table.Columns.Add(new DataColumn("KUNDE_POSTNR", typeof(string)));
            table.Columns.Add(new DataColumn("KUNDE_POSTSTED", typeof(string)));
            table.Columns.Add(new DataColumn("KUNDEANSVARLIG_ID", typeof(string)));
            table.Columns.Add(new DataColumn("BANK_ID", typeof(string)));
            table.Columns.Add(new DataColumn("SAMTYKKE_FORSIKRING", typeof(char)));
            table.Columns.Add(new DataColumn("SAMTYKKE_BANK", typeof(char)));

            try
            {

                comm.CommandText = sql;

                comm.Connection.Open();

                SqlDataReader cursor = comm.ExecuteReader();
                var addValues = new object[cursor.FieldCount];
                while (cursor.Read())
                {
                    addValues[0] = cursor["KUNDENR_ANONYMISERT"].ToString();
                    addValues[1] = cursor["VALID_FROM_DTTM"];
                    addValues[2] = cursor["KUNDE_POSTNR"].ToString();
                    addValues[3] = cursor["KUNDE_POSTSTED"].ToString();
                    addValues[4] = cursor["KUNDEANSVARLIG_ID"].ToString();
                    addValues[5] = cursor["BANK_ID"].ToString();
                    addValues[6] = cursor["SAMTYKKE_FORSIKRING"];
                    addValues[7] = cursor["SAMTYKKE_BANK"];

                    table.Rows.Add(addValues);
                    
                }

                foreach(DataRow brow in table.Rows)
                {                   
                    foreach (DataColumn bcol in table.Columns)
                    {
                        foreach (DataRow frow in forsikringTable.Rows)
                        {
                            if (brow[0].ToString() == frow[0].ToString())
                            {
                                if (brow[6].ToString() != frow[6].ToString() ||
                                    brow[7].ToString() != frow[7].ToString())
                                {
                                    throw new Exception("Integrationtest failed with customer number " + brow[0].ToString());
                                }
                            }
                        }

                    }
                }
                
            }
            catch (Exception e)
            {
                throw new Exception("Integrationtest failed. " + e.Message);
            }
            finally
            {
                comm.Connection.Close();
            }
        }

        public DataTable ReadMQDataTable(string sql)
        {

            DataTable table = new DataTable("MyMQTable");
            table.Columns.Add(new DataColumn("KUNDENR_ANONYMISERT", typeof(string)));
            table.Columns.Add(new DataColumn("VALID_FROM_DTTM", typeof(DateTime)));
            table.Columns.Add(new DataColumn("KUNDE_POSTNR", typeof(string)));
            table.Columns.Add(new DataColumn("KUNDE_POSTSTED", typeof(string)));
            table.Columns.Add(new DataColumn("KUNDEANSVARLIG_ID", typeof(string)));
            table.Columns.Add(new DataColumn("BANK_ID", typeof(string)));
            table.Columns.Add(new DataColumn("SAMTYKKE_FORSIKRING", typeof(char)));
            table.Columns.Add(new DataColumn("SAMTYKKE_BANK", typeof(char)));
            table.Columns.Add(new DataColumn("ID", typeof(int)));

            try
            {

                comm.CommandText = sql;

                comm.Connection.Open();

                SqlDataReader cursor = comm.ExecuteReader();
                var addValues = new object[cursor.FieldCount];

                while (cursor.Read())
                {
                    addValues[0] = cursor["KUNDENR_ANONYMISERT"].ToString();
                    addValues[1] = cursor["VALID_FROM_DTTM"];
                    addValues[2] = cursor["KUNDE_POSTNR"].ToString();
                    addValues[3] = cursor["KUNDE_POSTSTED"].ToString();
                    addValues[4] = cursor["KUNDEANSVARLIG_ID"].ToString();
                    addValues[5] = cursor["BANK_ID"].ToString();
                    addValues[6] = cursor["SAMTYKKE_FORSIKRING"];
                    addValues[7] = cursor["SAMTYKKE_BANK"];
                    addValues[8] = cursor["ID"];

                    table.Rows.Add(addValues);
                }
                

                return table;

            }
            catch (Exception e)
            {
                throw new Exception("Read from MessageQueue table failed. " + e.Message);
            }
            finally
            {
                comm.Connection.Close();
            }
        }

        public void UpdateSQLServerTable(DataTable dt, string TableName)
        {
            try
            {
                comm.Connection.Open();

                //Creating temp table on database
                comm.CommandText = "CREATE TABLE TempTable( [KUNDENR_ANONYMISERT] NVARCHAR (50)  NULL, " +
                                    "[VALID_FROM_DTTM]     DATETIME NULL, " +
                                    "[KUNDE_POSTNR]        NVARCHAR(50)  NULL, " +
                                    "[KUNDE_POSTSTED]      NVARCHAR(100) NULL, " +
                                    "[KUNDEANSVARLIG_ID]   NVARCHAR(50)  NULL, " +
                                    "[BANK_ID]             NVARCHAR(50)  NULL, " +
                                    "[SAMTYKKE_FORSIKRING] CHAR(1)       NULL, " +
                                    "[SAMTYKKE_BANK]       CHAR(1)       NULL, " +
                                    "[ID]                  INT           NOT NULL)";
                comm.ExecuteNonQuery();

                //Bulk insert into temp table
                using (SqlBulkCopy bulkcopy = new SqlBulkCopy(comm.Connection))
                {
                    bulkcopy.BulkCopyTimeout = 660;
                    bulkcopy.DestinationTableName = "dbo.TempTable";
                    bulkcopy.WriteToServer(dt);
                    bulkcopy.Close();
                }

                // Updating destination table, and dropping temp table
                comm.CommandTimeout = 300;
                comm.CommandText = "UPDATE T SET T.SAMTYKKE_FORSIKRING " +
                    "= Temp.SAMTYKKE_FORSIKRING, T.SAMTYKKE_BANK = Temp.SAMTYKKE_BANK FROM dbo." + TableName + " T INNER JOIN TempTable Temp ON " +
                    " T.KUNDENR_ANONYMISERT = Temp.KUNDENR_ANONYMISERT; DROP TABLE TempTable;";
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Update " + TableName + " failed. " + e.Message);

            }
            finally
            {
                comm.Connection.Close();
            }
          
        }

        public void DeleteSQLServerTable(DataTable dt, string TableName)
        {

            try
            {
                comm.Connection.Open();

                //Creating temp table on database
                comm.CommandText = "CREATE TABLE TempTable( [KUNDENR_ANONYMISERT] NVARCHAR (50)  NULL, " +
                                    "[VALID_FROM_DTTM]     DATETIME NULL, " +
                                    "[KUNDE_POSTNR]        NVARCHAR(50)  NULL, " +
                                    "[KUNDE_POSTSTED]      NVARCHAR(100) NULL, " +
                                    "[KUNDEANSVARLIG_ID]   NVARCHAR(50)  NULL, " +
                                    "[BANK_ID]             NVARCHAR(50)  NULL, " +
                                    "[SAMTYKKE_FORSIKRING] CHAR(1)       NULL, " +
                                    "[SAMTYKKE_BANK]       CHAR(1)       NULL, " +
                                    "[ID]                  INT           NOT NULL)";
                comm.ExecuteNonQuery();

                //Bulk insert into temp table
                using (SqlBulkCopy bulkcopy = new SqlBulkCopy(comm.Connection))
                {
                    bulkcopy.BulkCopyTimeout = 660;
                    bulkcopy.DestinationTableName = "dbo.TempTable";
                    bulkcopy.WriteToServer(dt);
                    bulkcopy.Close();
                }

                // Updating destination table, and dropping temp table
                comm.CommandTimeout = 300;
                comm.CommandText = "DELETE T FROM dbo." + TableName + " T INNER JOIN TempTable Temp ON " +
                    "T.ID = Temp.ID; DROP TABLE TempTable;";
                comm.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Delete from " + TableName + " failed. " + e.Message);

            }
            finally
            {
                comm.Connection.Close();
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

    public class MQRow
    {
        public string KUNDENR_ANONYMISERT { get; set; }
        public DateTime VALID_FROM_DTTM { get; set; }
        public string KUNDE_POSTNR { get; set; }
        public string KUNDE_POSTSTED { get; set; }
        public string KUNDEANSVARLIG_ID { get; set; }
        public string BANK_ID { get; set; }
        public char SAMTYKKE_FORSIKRING { get; set; }
        public char SAMTYKKE_BANK { get; set; }
        public int ID { get; set; }

    }
    public class TableRow
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
