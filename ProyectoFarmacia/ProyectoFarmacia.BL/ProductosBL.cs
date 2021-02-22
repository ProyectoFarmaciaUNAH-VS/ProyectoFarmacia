﻿using System;
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

            ListadeProductos = _contexto.Productos.ToList();
            return ListadeProductos;
        }

        public void GuardarProducto(Producto producto)
     
        {
            if(producto.ID == 0)

            {
                _contexto.Productos.Add(producto);
              
            }
            else
            {
                var productoExistente = _contexto.Productos.Find(producto.ID);
                productoExistente.Descripcion = producto.Descripcion;
                productoExistente.Precio = producto.Precio;

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
 