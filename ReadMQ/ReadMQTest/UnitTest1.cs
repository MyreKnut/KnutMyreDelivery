using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace ReadMQTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                var conn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataCenter;Integrated Security=SSPI;";
                ReadMQ.BankCenterAdapter bca = new ReadMQ.BankCenterAdapter(conn);

                DataTable mess = bca.ReadMQDataTable("Select * from dbo.MessageQueue");
            }
            catch (Exception e)
            {
                Assert.Fail(
                     string.Format("Unexpected exception of type {0} caught: {1}",
                                    e.GetType(), e.Message)
                );
            }
        }

        [TestMethod]
        public void TestMethod2()
        {

            try
            {
                var conn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataCenter;Integrated Security=SSPI;";
                ReadMQ.BankCenterAdapter bca = new ReadMQ.BankCenterAdapter(conn);

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

                table.Rows.Add(new object[] { "321", DateTime.Now, "0100", "Oslo", "abc", "1000", "N", "Y", 1 });
                table.Rows.Add(new object[] { "4321", DateTime.Now, "0100", "Oslo", "abc", "1000", "N", "Y", 2 });

                bca.UpdateSQLServerTable(table, "Forsikring");

               
            }
            catch (Exception e)
            {
                Assert.Fail(
                     string.Format("Unexpected exception of type {0} caught: {1}",
                                    e.GetType(), e.Message)
                );
            }

        }

        [TestMethod]
        public void TestMethod3()
        {

            try
            {
                var conn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataCenter;Integrated Security=SSPI;";
                ReadMQ.BankCenterAdapter bca = new ReadMQ.BankCenterAdapter(conn);

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

                table.Rows.Add(new object[] { "321", DateTime.Now, "0100", "Oslo", "abc", "1000", "N", "Y", 1 });
                table.Rows.Add(new object[] { "4321", DateTime.Now, "0100", "Oslo", "abc", "1000", "N", "Y", 2 });

                bca.UpdateSQLServerTable(table, "MessageQueue");


            }
            catch (Exception e)
            {
                Assert.Fail(
                     string.Format("Unexpected exception of type {0} caught: {1}",
                                    e.GetType(), e.Message)
                );
            }

        }
    }
}

