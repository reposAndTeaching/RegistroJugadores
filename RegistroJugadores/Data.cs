using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroJugadores
{
    class Data
    {
        private Conexion c;
        private SqlConnection sql;
        private SqlCommand command;
        private SqlDataReader response;

        public Data(string server, string bd)
        {
            c = new Conexion(server, bd);
        }

        public List<Jugador> GetJugadores()
        {
            List<Jugador> list = new List<Jugador>();
            Jugador j = null;
            string query = "SELECT * FROM jugador;";
            using (sql = new SqlConnection(c.StringBuilder.ConnectionString))
            {
                sql.Open();
                using (command = new SqlCommand(query, sql))
                {
                    response = command.ExecuteReader();
                    while (response.Read())
                    {
                        int idActual = response.GetInt32(0);
                        string nombreActual = response.GetString(1);
                        int numeroActual = response.GetInt32(2);
                        j = new Jugador(idActual, nombreActual, numeroActual);
                        list.Add(j);
                    }
                }

            }
            return list;
        }

        public Jugador GetJugador(int id)
        {
            Jugador j = null;
            string query = "select * from jugador where id = " + id + ";";
            using (sql = new SqlConnection(c.StringBuilder.ConnectionString))
            {
                sql.Open();
                using (command = new SqlCommand(query, sql))
                {
                    response = command.ExecuteReader();
                    if (response.Read())
                    {
                        int idActual = response.GetInt32(0);
                        string nombreActual = response.GetString(1);
                        int numeroActual = response.GetInt32(2);
                        j = new Jugador(idActual, nombreActual, numeroActual);
                    }
                }
            }

            return j;
        }

        public void InsertarJugador(Jugador jugador)
        {
            string query = "insert into jugador values('" + jugador.Nombre + "', " + jugador.Numero + ");";
            using (sql = new SqlConnection(c.StringBuilder.ConnectionString))
            {
                sql.Open();
                using (command = new SqlCommand(query, sql))
                {
                    int response = command.ExecuteNonQuery();
                    if (response == 1)
                    {
                        Console.WriteLine("El Jugador {0} fue insertado exitosamente!", jugador.Nombre);
                    }
                    else if (response == 0)
                    {
                        Console.WriteLine("Existió un error al tratar de ejecutar la consulta.");
                    }
                }
            }
        }
    }
}
