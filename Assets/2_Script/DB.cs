//using System;
//using System.Data;
//using Oracle.DataAccess.Client;
//using UnityEngine;

//public class DB : MonoBehaviour
//{
//    private string connectionString = "User Id=hr;Password=hr;Data Source=localhost:152/xe;";

//    void Start()
//    {
//        ConnectToDatabase();
//    }

//    void ConnectToDatabase()
//    {
//        using (OracleConnection connection = new OracleConnection(connectionString))
//        {
//            try
//            {
//                connection.Open();
//                Debug.Log("Database connection successful!");

//                // 데이터 쿼리 예시
//                string query = "SELECT * FROM yourTable";
//                using (OracleCommand command = new OracleCommand(query, connection))
//                {
//                    using (OracleDataReader reader = command.ExecuteReader())
//                    {
//                        while (reader.Read())
//                        {
//                            Debug.Log(reader["columnName"].ToString());
//                        }
//                    }
//                }
//            }
//            catch (Exception ex)
//            {
//                Debug.LogError("Error connecting to database: " + ex.Message);
//            }
//        }
//    }
//}