using PARCIAL1.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL1.Negocio
{
    class ClsVenta
    {
        public Venta cobro(Venta venta)
        {

            Console.WriteLine("el precio a pagar es de " + (venta.Precio * venta.Cantidad).ToString("00.00"));
            if (venta.Precio * venta.Cantidad > 50)
            {
                Console.WriteLine("ya con descuento el total a pagar es de " + (venta.Precio * venta.Cantidad* 0.15 - venta.Precio).ToString("00.00"));
            }


            return null;
        }
    }
}
