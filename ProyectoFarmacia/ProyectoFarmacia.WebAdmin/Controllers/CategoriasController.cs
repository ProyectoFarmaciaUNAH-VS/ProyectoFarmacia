﻿using ProyectoFarmacia.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFarmacia.WebAdmin.Controllers
{
    public class CategoriasController : Controller
    {
        CategoriasBL _categoriasBL;
        public CategoriasController()
        {
            _categoriasBL = new CategoriasBL();
        }

        // GET: Productos
        public ActionResult Index()
        {
            var listadeCategorias = _categoriasBL.ObtenerCategorias();
            return View(listadeCategorias);
        }


        public ActionResult Crear()
        {
            var nuevoCategoria = new Categoria();
            return View(nuevoCategoria);

        }

        [HttpPost]
        public ActionResult Crear(Categoria categoria)
        {
			if (ModelState.IsValid)
			{
				if (categoria.Descripcion != categoria.Descripcion.Trim())
				{
					ModelState.AddModelError("Descripción", "La descripción no debe contener espacios");
				}
				_categoriasBL.GuardarCategoria(categoria);
				return RedirectToAction("Index");
			}
			return View(categoria);
        }
        public ActionResult Editar(int id)
        {
           var producto = _categoriasBL.ObtenerCategoria(id);
            return View(producto);

        }

        [HttpPost]
        public ActionResult Editar(Categoria producto)
        {
            _categoriasBL.GuardarCategoria(producto);
            return RedirectToAction("Index");
        }

        public ActionResult Detalle(int id)
        {
            var producto = _categoriasBL.ObtenerCategoria(id);
            return View(producto);

        }
        public ActionResult Eliminar(int id)
        {
            var producto = _categoriasBL.ObtenerCategoria(id);
            return View(producto);

        }

        [HttpPost]
        public ActionResult Eliminar(Categoria producto)
        {
            _categoriasBL.EliminarProducto(producto.Id);
            return RedirectToAction("Index");
        }
    }
}