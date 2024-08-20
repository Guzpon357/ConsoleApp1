using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Persona

    {
        public String Nombres { get; set; }
        public String Apellidos { get; set; }

        public String NombresCompletos { get; set; }
        public void AsignarNombreCompletos()
        {
            NombresCompletos = Nombres + " " + Apellidos;
        }

    }
}
