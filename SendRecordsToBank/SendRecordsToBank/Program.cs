using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Excel;
using System.Data.SqlClient;

namespace SendRecordsToBank
{
    class Program
    {

        static void Main(string[] args)
        {
            int excelSheetNumber;
            if (!Int32.TryParse(ConfigurationManager.AppSettings["ExcelSheetNumber"], out excelSheetNumber))
            {
                Console.WriteLine("Config value ExcelSheet could not be parsed to int.");
                return;
            }
            int greaterThanYear;
            if (!Int32.TryParse(ConfigurationManager.AppSettings["FilterToBankGreaterThanYear"], out greaterThanYear))
            {
                Console.WriteLine("Config value GreaterThanYear could not be parsed to int.");
                return;
            }
            BankCenterAdapter bankCenterAdapter = new BankCenterAdapter(ConfigurationManager.AppSettings["ConnDataCenter"]);
            var bankTableName = ConfigurationManager.AppSettings["BankTableName"];
            var forsikringTableName = ConfigurationManager.AppSettings["ForsikringTableName"];
            var mqTableName = ConfigurationManager.AppSettings["MQTableName"];
            bankCenterAdapter.ExecuteSQLCommand("Delete from dbo." + bankTableName + 
                ";Delete from dbo." + forsikringTableName +
                ";Delete from dbo." + mqTableName);
            var excelFileHasHeader = ConfigurationManager.AppSettings["ExcelFileHasHeader"];
            var excelFilePath = ConfigurationManager.AppSettings["ExcelFilePath"];
            var filterToBankKundeansvarlig = ConfigurationManager.AppSettings["FilterToBankKundeansvarlig"];

            DataTable table = new DataTable("MyExcelTable");
            table.Columns.Add(new DataColumn("KUNDENR_ANONYMISERT", typeof(string)));
            table.Columns.Add(new DataColumn("VALID_FROM_DTTM", typeof(DateTime)));
            table.Columns.Add(new DataColumn("KUNDE_POSTNR", typeof(string)));
            table.Columns.Add(new DataColumn("KUNDE_POSTSTED", typeof(string)));
            table.Columns.Add(new DataColumn("KUNDEANSVARLIG_ID", typeof(string)));
            table.Columns.Add(new DataColumn("BANK_ID", typeof(string)));
            table.Columns.Add(new DataColumn("SAMTYKKE_FORSIKRING", typeof(char)));
            table.Columns.Add(new DataColumn("SAMTYKKE_BANK", typeof(char)));

            var sheetCount = 1;
            foreach (var worksheet in Workbook.Worksheets(@excelFilePath))
            {
                
                if (sheetCount == excelSheetNumber)
                {
                    var addValues = new object[worksheet.NumberOfColumns];

                    var rowCount = 1;
                    
                    foreach (var row in worksheet.Rows)
                    {
                        //var addToTable = true;
                        if (rowCount != 1 || excelFileHasHeader != "Y")
                        {
                            foreach (var cell in row.Cells)
                            {
                                if (cell != null)
                                {
                                    
                                    switch (cell.ColumnIndex)
                                    {
                                        case 1:
                                            addValues[cell.ColumnIndex] = DateTime.FromOADate(Convert.ToDouble(cell.Value));
                                            //if (DateTime.FromOADate(Convert.ToDouble(cell.Value)).Year <= greaterThanYear)
                                              //  addToTable = false;
                                            break;
                                        case 4:
                       
                                            addValues[cell.ColumnIndex] = cell.Text;
                                                                    
                                            //if (cell.Text.Length == 0 && filterToBankKundeansvarlig == "Y")
                                              //  addToTable = false;

                                            break;
                                        case 6:
                                                                       
                                            if (cell.Text.Length > 0)
                                            {
                                                addValues[cell.ColumnIndex] = Convert.ToChar(cell.Text.ToUpper());
                                            } else
                                            {
                                                addValues[cell.ColumnIndex] = cell.Text.ToUpper();
                                            }
                                                                                       
                                            break;
                                        
                                        case 7:
                                                 
                                            if (cell.Text.Length > 0)
                                            {
                                                addValues[cell.ColumnIndex] = Convert.ToChar(cell.Text.ToUpper());
                                            } else
                                            {
                                                addValues[cell.ColumnIndex] = cell.Text.ToUpper();
                                            }
                                            
                                            break;
                                        default:
                                            if (cell.IsAmount)
                                            {
                                                addValues[cell.ColumnIndex] = cell.Value;
                                            } else
                                            {
                                                addValues[cell.ColumnIndex] = cell.Text;
                                            }
                                            
                                            break;
                                    }

                                }
                                                                            
                            }

                            //skip row if customer number is null
                            //if (addValues[0] != null && addValues[0].ToString() != "" && addToTable)
                            if (addValues[0] != null && addValues[0].ToString() != "")
                            {
                                table.Rows.Add(addValues);
                                addValues[0] = null;
                            }

                        }

                        rowCount++;

                    }

                    bankCenterAdapter.BulkInsert(forsikringTableName, table);

                    var sql = string.Empty;
                    if (filterToBankKundeansvarlig == "Y")
                    {
                        sql = "INSERT INTO dbo." + bankTableName +
                              " SELECT * FROM dbo." + forsikringTableName +
                              " WHERE YEAR(VALID_FROM_DTTM) > " + greaterThanYear +
                              " and KUNDEANSVARLIG_ID is not null" +
                              " and LEN(KUNDEANSVARLIG_ID) > 0";
                    } else
                    {
                        sql = "INSERT INTO dbo." + bankTableName +
                              " SELECT * FROM dbo." + forsikringTableName +
                              " WHERE YEAR(VALID_FROM_DTTM) >= " + greaterThanYear;
                    }
                    
                    bankCenterAdapter.ExecuteSQLCommand(sql);

                    sheetCount++;

                }         

            }

        }
                
    }

}
        

