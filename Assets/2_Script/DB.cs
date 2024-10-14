using System;
using System.Data;
using System.Net;
using Oracle.ManagedDataAccess.Client;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DB : MonoBehaviour
{
    private string connectionString = "Data Source = (DESCRIPTION = (ADDRESS_LIST = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA = (SERVICE_NAME = XE))));User Id = hr;Password = hr;";

    void Start()
    {
        Debug.Log("DB.Start()");
        ConnectToDatabase();
    }

    void ConnectToDatabase()
    {
        Debug.Log("DB.ConnectToDatabase()");
        using (OracleConnection connection = new OracleConnection(connectionString))
        {
            try
            {
                connection.Open();
                Debug.Log("Database connection successful!");

                // 데이터 쿼리 예시
                string query = "SELECT * FROM yourTable";
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Debug.Log(reader["columnName"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.LogError("Error connecting to database: " + ex.Message);
            }
        }
    }
}