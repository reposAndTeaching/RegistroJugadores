using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroJugadores
{
    class Jugador
    {
        private int id;
        private string nombre;
        private int numero;

        public Jugador(int id, string nombre, int numero)
        {
            this.id = id;
            this.nombre = nombre;
            this.numero = numero;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Numero { get => numero; set => numero = value; }
    }
}
