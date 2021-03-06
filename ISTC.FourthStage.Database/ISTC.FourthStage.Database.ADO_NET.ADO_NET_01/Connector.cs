﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ISTC.FourthStage.Database.ADO_NET.ADO_NET_01
{
    public class Connector
    {
        public static List<Employee> GetEmployees()
        {
            var peoples = new List<Employee>();
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyDb;Integrated Security=True;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    Console.WriteLine(connection.State);

                    string query = "select * from data";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader sqlDataReader = command.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                var order = sqlDataReader.GetOrdinal("id");
                                peoples.Add(
                                   new Employee
                                   {
                                       Id = sqlDataReader.GetSqlInt32(order).IsNull ? -1 : sqlDataReader.GetSqlInt32(order).Value,
                                       NameOfTheTraiteur = (string)GetValue(sqlDataReader, "NameOfTheTraiteur"),
                                       Adress = (string)GetValue(sqlDataReader, "Adress"),
                                       ContactCommercial = (string)GetValue(sqlDataReader, "ContactCommercial"),
                                       Dirigeant = (string)GetValue(sqlDataReader, "Dirigeant"),
                                       EmailAddress = (string)GetValue(sqlDataReader, "EmailAddress"),
                                       Fax = (string)GetValue(sqlDataReader, "Fax"),
                                       TelephoneNumber = (string)GetValue(sqlDataReader, "TelephoneNumber")
                                   }
                              );
                            }
                        }

                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return peoples;
        }

        public static object GetValue(SqlDataReader sqlDataReader, string index)
        {
            if (sqlDataReader[index] is DBNull) return null;
            return sqlDataReader[index];
        }

        public static List<People> GetPeopleUsingConnectionBuilder()
        {
            var peoples = new List<People>();
            SqlConnectionStringBuilder conSB = new SqlConnectionStringBuilder
            {
                DataSource = @"(localdb)\MSSQLLocalDB",
                InitialCatalog = "MyFirstDataBase",
                IntegratedSecurity = false,
                UserID = "",
                Password = "",
                ConnectTimeout = 90,
                AttachDBFilename = @"",
                
            };
            try
            {
                using (SqlConnection connection = new SqlConnection(conSB.ConnectionString))
                {
                    connection.Open();
                    Console.WriteLine(connection.State);

                    var query = "select * from People";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader sqlDataReader = command.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                var id = sqlDataReader.GetInt32(0);
                                var firstName = sqlDataReader.GetString(1);
                                var lastName = sqlDataReader.GetString(2);
                                var age = sqlDataReader.GetSqlInt32(3);

                                peoples.Add(
                                    new People
                                    {
                                        Id = id,
                                        FirstName = firstName,
                                        LastName = lastName,
                                        Age = age.IsNull ? default(int?) : age.Value
                                    }
                                );
                            }
                        }

                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return peoples;
        }
    }
}
