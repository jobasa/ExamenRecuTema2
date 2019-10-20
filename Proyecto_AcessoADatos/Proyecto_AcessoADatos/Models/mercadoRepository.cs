using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class mercadoRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Server=127.0.0.1;Port=3306;Database=mydb;Uid=root;password=none;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }
        internal mercado Retrieve()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from mercado";

            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            mercado m = null;
            //Devolver objeto evento. Se devolvera el primer registro
            if (res.Read())
            {
                Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetString(3) + " " + res.GetString(4) + " " + res.GetInt32(5));
                m = new mercado(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetString(3), res.GetString(4), res.GetInt32(5));
            }

            con.Close();
            return m;


        }
    }
}