using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFarmacia.BL
{
    public class ProductosBL
    {
        public List<Producto> ObtenerProductos()
        {

            var producto1 = new Producto();
            producto1.ID = 1;
            producto1.Descripcion = "Prd: A";
            producto1.Precio = 250;

            var producto2 = new Producto();
            producto2.ID = 2;
            producto2.Descripcion = "Prd: B";
            producto2.Precio = 150;

            var producto3 = new Producto();
            producto3.ID = 3;
            producto3.Descripcion = "Prd: C";
            producto3.Precio = 200;

            var producto4 = new Producto();
            producto4.ID = 4;
            producto4.Descripcion = "Prd: D";
            producto4.Precio = 350;

            var listadeProductos = new List<Producto>();

            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(producto4);



            return listadeProductos;
        }
    }
 }
