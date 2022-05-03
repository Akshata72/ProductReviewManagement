using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagment
{
    public class DataTableOpration
    {
        DataTable Table = new DataTable("CreateDataTable");
        public DataTableOpration()
        { 
            Table.Columns.Add("ProductID",Type.GetType("System.Int32"));
            Table.Columns.Add("UserID", Type.GetType("System.Int32"));
            Table.Columns.Add("Rating", Type.GetType("System.Int32"));
            Table.Columns.Add("Review",Type.GetType("System.String"));
            Table.Columns.Add("IsLike", Type.GetType("System.String"));
        }   
        public void CreateTabel()
        {
            Table.Rows.Add(1, 1, 5, "Good", "true");
            Table.Rows.Add(2, 1, 4, "Good", "true");
            Table.Rows.Add(3, 1, 7, "Nice", "false");
            Table.Rows.Add(4, 1, 3, "bad", "true");
            Table.Rows.Add(5, 1, 8, "Nice", "true");
            Table.Rows.Add(6, 1, 9, "Nice", "true");
            Table.Rows.Add(7, 1, 1, "bad", "true");
            Table.Rows.Add(8, 1, 7, "nice", "false");
            Table.Rows.Add(9, 1, 5, "Good", "true");
            Table.Rows.Add(10, 1, 6, "Good", "true");
            Table.Rows.Add(11, 1, 4, "Good", "true");
            Table.Rows.Add(12, 1, 2, "bad", "false");
            Table.Rows.Add(13, 1, 7, "Good", "false");
            Table.Rows.Add(14, 1, 6, "Good", "true");
            Table.Rows.Add(15, 1, 8, "Nice", "true");
            Table.Rows.Add(16, 1, 10, "Excelent", "true");
            Table.Rows.Add(17, 1, 3, "bad", "true");
            Table.Rows.Add(18, 1, 1, "bad", "false");
            Table.Rows.Add(19, 1, 7, "Good", "true");
            Table.Rows.Add(20, 1, 2, "bad", "true");
            Table.Rows.Add(21, 1, 6, "Good", "true");
            Table.Rows.Add(22, 1, 4, "Good", "false");
            Table.Rows.Add(23, 1, 9, "Excelent", "true");
            Table.Rows.Add(24, 1, 5, "Good", "true");
            Table.Rows.Add(25, 1, 7, "Nice", "false");
            Console.WriteLine("Data Table Created");

            foreach(var table in Table.AsEnumerable())
            {
                Console.WriteLine("\nProductID: " + table.Field<Int32>("ProductID"));
                Console.WriteLine("UserID: " + table.Field<Int32>("UserId"));
                Console.WriteLine("Rating: " + table.Field<Int32>("Rating"));
                Console.WriteLine("Review: " + table.Field<String>("Review"));
                Console.WriteLine("IsLike: " + table.Field<String>("IsLike"));
            }
        }
    }
}
