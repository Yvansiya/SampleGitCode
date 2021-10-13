using System;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data;
using System.Linq;
namespace Yatik_Task4.CommonUtility
{
    public static class Common
    {
         public static DataTable GetDataTableResult(string ProcedureName,string conn)
        {
             DataTable dt = new DataTable();
               using (SqlConnection Con =new SqlConnection(conn))
               {
                Con.Open();
                SqlCommand cmd=new SqlCommand(ProcedureName,Con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sd = new SqlDataAdapter(cmd);
                
                sd.Fill(dt);
                Con.Close();
               }
               return dt;
        }

        public static List<T> ConvertDataTableToGenericList<T>(DataTable dt)
        {
            var columnNames = dt.Columns.Cast<DataColumn>()
                   .Select(c => c.ColumnName)
                   .ToList();

            var properties = typeof(T).GetProperties();
            DataRow[] rows = dt.Select();
            return rows.Select(row =>
            {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name))
                        pro.SetValue(objT, row[pro.Name]);
                }

                return objT;
            }).ToList();
        }
    }
}


