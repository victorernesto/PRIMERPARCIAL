using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL1.Entidades
{
    class Usuario
    {
        private String nombre;
        private int contraseña;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Contraseña { get => contraseña; set => contraseña = value; }
    }
}
