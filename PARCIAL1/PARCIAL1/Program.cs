using PARCIAL1.Entidades;
using PARCIAL1.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL1
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();
            ClsUsuario clsusuario = new ClsUsuario();
            Venta venta = new Venta();
            ClsVenta clsventa = new ClsVenta();
            Console.WriteLine("COLOQUE SU NOMBRE ");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("COLOQUE SU CONTRASEÑA");
            usuario.Contraseña = int.Parse(Console.ReadLine());
            Console.WriteLine(clsusuario.ACCESO(usuario));
            Console.WriteLine("ID PRODUCTO");
            venta.Id_producto = int.Parse(Console.ReadLine());
            Console.WriteLine("NOMBRE DEL PRODUCTO");
            venta.Nombre_producto = Console.ReadLine();
            Console.WriteLine("DESCRIPSION DEL PRODUCTO");
            venta.Descripsion = Console.ReadLine();
            Console.WriteLine("PRECIO DEL PRODUCTO ");
            venta.Precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("CANTIDA");
            venta.Cantidad = int.Parse(Console.ReadLine());
            Console.WriteLine(clsventa.cobro(venta));
            
            Console.ReadLine();
        }
    }
}
