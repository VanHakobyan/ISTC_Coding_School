using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISTC.FourthStage.Database.ADO_NET_02
{
    public class Connector
    {
        public static void GetStartups()
        {
            try
            {
                var path = @"..\..\StartUp.xlsx";
                var s = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Path.GetFullPath(path)};Extended Properties='Excel 12.0 Xml;HDR=YES;IMEX=1;MAXSCANROWS=0'";
                OleDbConnection connect = new OleDbConnection(s);

                try
                {
                    connect.Open();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                OleDbDataAdapter objDA = new OleDbDataAdapter("select * from [Peoples$]", connect);
                DataSet excelDataSet = new DataSet();
                objDA.Fill(excelDataSet);
                var dataTable = excelDataSet.Tables[0];

                foreach (DataRow dataTableRow in dataTable.Rows)
                {
                    var company = dataTableRow["Company"].ToString();
                    var link = dataTableRow["Link"].ToString();
                    Console.WriteLine($"Company: {company} | Link: {link}");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
