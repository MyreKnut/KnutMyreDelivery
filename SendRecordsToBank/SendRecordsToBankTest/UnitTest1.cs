using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace SendRecordsToBankTest
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
                SendRecordsToBank.BankCenterAdapter bca = new SendRecordsToBank.BankCenterAdapter(conn);

                bca.ExecuteSQLCommand("Delete from dbo.Bank" +
                    ";Delete from dbo.Forsikring" +
                    ";Delete from dbo.MessageQueue;");
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
                SendRecordsToBank.BankCenterAdapter bca = new SendRecordsToBank.BankCenterAdapter(conn);

                DataTable table = new DataTable("MyExcelTable");
                table.Columns.Add(new DataColumn("KUNDENR_ANONYMISERT", typeof(string)));
                table.Columns.Add(new DataColumn("VALID_FROM_DTTM", typeof(DateTime)));
                table.Columns.Add(new DataColumn("KUNDE_POSTNR", typeof(string)));
                table.Columns.Add(new DataColumn("KUNDE_POSTSTED", typeof(string)));
                table.Columns.Add(new DataColumn("KUNDEANSVARLIG_ID", typeof(string)));
                table.Columns.Add(new DataColumn("BANK_ID", typeof(string)));
                table.Columns.Add(new DataColumn("SAMTYKKE_FORSIKRING", typeof(char)));
                table.Columns.Add(new DataColumn("SAMTYKKE_BANK", typeof(char)));

                table.Rows.Add(new object[] { "123", DateTime.Now, "0100", "Oslo", "abc", "1000", "N", "Y" });
                table.Rows.Add(new object[] { "123", DateTime.Now, "0100", "Oslo", "abc", "1000", "N", "Y" });

                bca.BulkInsert("Forsikring", table);

                Assert.Fail("An exception should have been thrown");
            }
            catch (Exception e)
            {
                Assert.AreEqual(@"bulkCopy.WriteToServer(theTable) failed: Violation of PRIMARY KEY constraint 'PK_Forsikring'. Cannot insert duplicate key in object 'dbo.Forsikring'. The duplicate key value is (123).
The statement has been terminated.", e.Message);
            }

        }

        [TestMethod]
        public void TestMethod3()
        {

            try
            {
                var conn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataCenter;Integrated Security=SSPI;";
                SendRecordsToBank.BankCenterAdapter bca = new SendRecordsToBank.BankCenterAdapter(conn);

                DataTable table = new DataTable("MyExcelTable");
                table.Columns.Add(new DataColumn("KUNDENR_ANONYMISERT", typeof(string)));
                table.Columns.Add(new DataColumn("VALID_FROM_DTTM", typeof(DateTime)));
                table.Columns.Add(new DataColumn("KUNDE_POSTNR", typeof(string)));
                table.Columns.Add(new DataColumn("KUNDE_POSTSTED", typeof(string)));
                table.Columns.Add(new DataColumn("KUNDEANSVARLIG_ID", typeof(string)));
                table.Columns.Add(new DataColumn("BANK_ID", typeof(string)));
                table.Columns.Add(new DataColumn("SAMTYKKE_FORSIKRING", typeof(char)));
                table.Columns.Add(new DataColumn("SAMTYKKE_BANK", typeof(char)));

                table.Rows.Add(new object[] { "1234", DateTime.Now, "0100", "Oslo", "abc", "1000", "N", "Y" });
                table.Rows.Add(new object[] { "12345", DateTime.Now, "0100", "Oslo", "abc", "1000", "N", "Y" });

                bca.BulkInsert("Forsikring", table);

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
        public void TestMethod4()
        {
            try
            {
                var conn = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=DataCenter;Integrated Security=SSPI;";
                SendRecordsToBank.BankCenterAdapter bca = new SendRecordsToBank.BankCenterAdapter(conn);

                bca.ExecuteSQLCommand("INSERT INTO dbo.Bank" + 
                              " SELECT * FROM dbo.Forsikring" + 
                              " WHERE YEAR(VALID_FROM_DTTM) >= 2016");
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
