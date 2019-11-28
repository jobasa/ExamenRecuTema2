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
            MySql.Data.MySqlClient.MySqlConnection con = new MySqlConnection(connString);
            return con;
        }
        internal evento Retrieve()
        {
            //Devuelve todos los registros
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "Select(m.tipo_mercado,m.Cuota_over,m.Cuota_under) from mercado m";

            con.Open();
            MySqlDataReader res = command.ExecuteReader();

            evento e = null;


            //Devolver objeto evento. Se devolvera un registro y lo añadira a la lista
            if (res.Read()){
                e = new evento(res.GetInt32(0), res.GetString(1), res.GetString(2));
            }

            con.Close();
            return e;
        }

        internal eventoDTO RetrieveDTO()
        {
            //Devuelve todos los registros
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "Select * from partido";

                con.Open();
                MySqlDataReader res = command.ExecuteReader();

                eventoDTO e = null;


                //Devolver objeto evento. Se devolvera un registro
                if (res.Read())
                {
                    e = new eventoDTO(res.GetString(0), res.GetString(1));
                }

                con.Close();
                return e;


        }
    }
}