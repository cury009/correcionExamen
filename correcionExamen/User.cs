using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace correcionExamen
{
    public class User
    {
        public String nombre { set; get; }
        public String apellidos { set; get; }
        public String telefono { set; get; }
        public String correo { set; get; }

        public User(string nombre, string apellidos, string telefono, string correo)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.telefono = telefono;
            this.correo = correo;
        }

        public User()
        {
        }

        public override string ToString()
        {
            return "Nombre:" + nombre + ", Apellidos: " + apellidos;
        }
    }
}
