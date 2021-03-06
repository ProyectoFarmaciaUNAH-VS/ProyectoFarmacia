using System;
using System.Collections.Generic;
using System.Linq;

namespace ProyectoFarmacia.BL
{
    public class ProductosBL
    {
        Contexto _contexto;

        public List <Producto> ListadeProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();
            ListadeProductos = new List<Producto>();
        }

         public List<Producto> ObtenerProductos()
        {
			//Incluyo tabla Categoria en la vista Productos paa mostrar informacion vinculada entre tablas.
            ListadeProductos = _contexto.Productos
            .Include("Categoria")
            .ToList();
            return ListadeProductos;
        }

		//Metodo gradar y editar
        public void GuardarProducto(Producto producto)
     
        {
            if(producto.ID == 0)

            {
				//Inserta producto
				_contexto.Productos.Add(producto);
              
            }
            else
            {
				//Edita producto
                var productoExistente = _contexto.Productos.Find(producto.ID);
                productoExistente.Descripcion = producto.Descripcion;
                productoExistente.Precio = producto.Precio;
				productoExistente.existencias = producto.existencias;
				//productoExistente.fechaVencimiento = producto.fechaVencimiento;
				productoExistente.urlImagen = producto.urlImagen;
			}
            _contexto.SaveChanges();
        }
            public Producto ObtenerProducto(int id)
        {
            var producto = _contexto.Productos.Find(id);
            return producto;
        }
          public void EliminarProducto(int id)
        {
            var producto = _contexto.Productos.Find(id);
            _contexto.Productos.Remove(producto);
            _contexto.SaveChanges();

        }
    }
 }
 