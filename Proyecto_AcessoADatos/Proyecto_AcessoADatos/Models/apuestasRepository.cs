﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class apuestasRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Server=127.0.0.1;Port=3306;Database=mydb;Uid=root;password=none;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }
        internal apuestas Retrieve()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from apuestas";

            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            apuestas a = null;
            //Devolver objeto evento. Se devolvera el primer registro
            if (res.Read())
            {
                Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetInt32(1) + " " + res.GetString(2) + " " + res.GetInt32(3) + " " + res.GetString(4) + " " + res.GetInt32(5) + " " + res.GetString(6));
                a = new apuestas(res.GetInt32(0), res.GetInt32(1), res.GetString(2), res.GetInt32(3), res.GetString(4), res.GetInt32(5), res.GetString(6));
            }

            con.Close();
            return a;


        }
    }
}