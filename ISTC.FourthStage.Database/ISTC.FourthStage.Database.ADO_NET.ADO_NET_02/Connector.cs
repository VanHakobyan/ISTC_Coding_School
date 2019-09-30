using System;
using System.Data;
using System.Data.OleDb;
using System.IO;

namespace ISTC.FourthStage.Database.ADO_NET.ADO_NET_02
{
    public class Connector
    {
        public static void GetStartUps()
        {
            try
            {
                var path = @"..\..\StartUp.xlsx";
                var s = $"Provider=Microsoft.OLEDB.16.0;Data Source={Path.GetFullPath(path)};Extended Properties='Excel 16.0 Xml;HDR=YES;IMEX=1;MAXSCANROWS=0'";
                //E:\Source\repos\VanHakobyan\ISTC_Coding_School\ISTC.FourthStage.Database\ISTC.FourthStage.Database.ADO_NET.ADO_NET_02\StartUp.xlsx
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
                DataTable dataTable = excelDataSet.Tables[0];

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
