using PARCIAL1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL1.Negocio
{
    class ClsUsuario
    {
        public Usuario ACCESO(Usuario usuario)
        {
            usuario.Nombre = "victor";
            usuario.Contraseña = 123;
            if (usuario.Nombre == "victor" && usuario.Contraseña==123)
            {
                Console.WriteLine("usuario correcto");

            }
            else
            {
                Console.WriteLine("usuario incorrecto ");
                return usuario;
            }









            return null;
        }


       

    }
}
