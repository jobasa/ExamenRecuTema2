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
        internal List<mercado> Retrieve()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from mercado";

            try { 
            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            mercado m = null;

                //Cada vez que ecuentra un objeto lo añade al list
                List<mercado> mercados = new List<mercado>();

                ////Devolver objeto mercado. Se devolvera un registro y lo añadira a la lista
                while (res.Read())
            {
                Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetString(2) + " " + res.GetString(3) + " " + res.GetString(4) + " " + res.GetInt32(5));
                m = new mercado(res.GetInt32(0), res.GetString(1), res.GetString(2), res.GetString(3), res.GetString(4), res.GetInt32(5));
                    mercados.Add(m);
            }

            con.Close();
            return mercados;

            }
            //Error que salta cuando esta puesto mal el server
            catch (MySqlException e)
            {
                Debug.WriteLine("Se ha porducido un error de conexión");
                return null;
            }

        }
    }
}