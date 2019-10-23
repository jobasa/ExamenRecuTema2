using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class eventoRepository
    {
        private MySqlConnection Connect()
        {
            string connString = "Server=127.0.0.1;Port=3306;Database=mydb;Uid=root;password=none;SslMode=none";
            MySqlConnection con = new MySqlConnection(connString);
            return con;
        }
        internal List<evento> Retrieve()
        {
            //Devuelve todos los registros
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from partido";

            try { 
            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            evento e = null;

             //Cada vez que ecuentra un objeto lo añade al list
             List<evento> eventos = new List<evento>();

            //Devolver objeto evento. Se devolvera un registro y lo añadira a la lista
            while (res.Read()){
                Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1) + " " + res.GetString(2));
                e = new evento(res.GetInt32(0), res.GetString(1), res.GetString(2));
                    //Añade el objeto al list
                    eventos.Add(e);
            }

            con.Close();
            return eventos;

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