using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProjectforProgramming
{
    internal class Records3
    {

       /* static void Main()
        {
            // Connection strings for source and target databases
            string sourceDb1ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\John Rhey Tamares\\source\\repos\\SampleProjectforProgramming\\SampleProjectforProgramming\\Student1.mdf\";Integrated Security=True";
            string sourceDb2ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\John Rhey Tamares\\source\\repos\\SampleProjectforProgramming\\SampleProjectforProgramming\\Time.mdf\";Integrated Security=True";
            string targetDbConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\John Rhey Tamares\\source\\repos\\SampleProjectforProgramming\\SampleProjectforProgramming\\Records.mdf\";Integrated Security=True";

            // Retrieve data from source databases
            DataTable dataTable1 = GetDataFromSourceDatabase(sourceDb1ConnectionString, "SELECT * FROM tblStudent");
            DataTable dataTable2 = GetDataFromSourceDatabase(sourceDb2ConnectionString, "SELECT * FROM tblTime");

            // Combine data
            DataTable combinedData = CombineDataTables(dataTable1, dataTable2);

            // Insert combined data into target database
            InsertDataIntoTargetDatabase(targetDbConnectionString, combinedData);
        }

        static DataTable GetDataFromSourceDatabase(string connectionString, string query)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }

        static DataTable CombineDataTables(DataTable dataTable1, DataTable dataTable2)
        {
            // Assuming both data tables have the same schema, otherwise you need to merge them accordingly
            DataTable combinedDataTable = dataTable1.Clone(); // Clone the schema of the first table

            // Optionally, add a column to distinguish source tables
            combinedDataTable.Columns.Add("SourceTable", typeof(string));

            foreach (DataRow row in dataTable1.Rows)
            {
                DataRow newRow = combinedDataTable.NewRow();
                newRow.ItemArray = row.ItemArray;
                newRow["SourceTable"] = "Table1";
                combinedDataTable.Rows.Add(newRow);
            }

            foreach (DataRow row in dataTable2.Rows)
            {
                DataRow newRow = combinedDataTable.NewRow();
                newRow.ItemArray = row.ItemArray;
                newRow["SourceTable"] = "Table2";
                combinedDataTable.Rows.Add(newRow);
            }

            return combinedDataTable;
        }

        static void InsertDataIntoTargetDatabase(string connectionString, DataTable combinedData)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlBulkCopy bulkCopy = new SqlBulkCopy(conn))
                {
                    bulkCopy.DestinationTableName = "TargetTable";

                    try
                    {
                        // Map columns
                        foreach (DataColumn column in combinedData.Columns)
                        {
                            bulkCopy.ColumnMappings.Add(column.ColumnName, column.ColumnName);
                        }

                        // Write from the source to the destination
                        bulkCopy.WriteToServer(combinedData);
                        Console.WriteLine("Data has been successfully inserted into the target table.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                }
            }
        }*/
    }

}

