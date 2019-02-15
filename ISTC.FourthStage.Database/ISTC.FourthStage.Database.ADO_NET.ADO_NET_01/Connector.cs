using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace ISTC.FourthStage.Database.ADO_NET.ADO_NET_01
{
    public class Connector
    {
        public static List<People> GetPeople()
        {
            var peoples = new List<People>();
            string connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=MyFirstDataBase;Integrated Security=True;";
            try
            {
                using (SqlConnection connection = new SqlConnection(connStr))
                {
                    connection.Open();
                    Console.WriteLine(connection.State);

                    string query = "select * from People";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader sqlDataReader = command.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                int id = sqlDataReader.GetInt32(0);
                                string firstName = sqlDataReader.GetString(1);
                                string lastName = sqlDataReader.GetString(2);
                                SqlInt32 age = sqlDataReader.GetSqlInt32(3);

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

        public static List<People> GetPeopleUsingConnectionBuilder()
        {
            var peoples = new List<People>();
            SqlConnectionStringBuilder conSB = new SqlConnectionStringBuilder
            {
                DataSource = @"(localdb)\MSSQLLocalDB",
                InitialCatalog = "MyFirstDataBase",
                IntegratedSecurity = true
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
