using ProyectoFarmacia.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProyectoFarmacia.WebAdmin.Controllers
{
    public class ProductosController : Controller
    {
        ProductosBL _productosBL;
        CategoriasBL _categoriasBL;
        public ProductosController()
        {
            _productosBL = new ProductosBL();
            _categoriasBL = new CategoriasBL();
        }

        // GET: Productos
        public ActionResult Index()
        {
            var listadeProductos = _productosBL.ObtenerProductos(); 
            return View(listadeProductos);
        }

      
        public ActionResult Crear()
        {
            var nuevoProducto = new Producto();
            var categorias = _categoriasBL.ObtenerCategorias();

            ViewBag.CategoriaId  = new SelectList(categorias, "Id", "Descripcion");

            return View(nuevoProducto);
            
         }

        [HttpPost]
        public ActionResult Crear(Producto producto, HttpPostedFileBase Imagen)
        {
			var categorias = _categoriasBL.ObtenerCategorias();
			if (ModelState.IsValid)
			{
				
				if (producto.CategoriaId == 0)
				{
					ModelState.AddModelError("Categoria", "Selccione una categoría");
				}
				if (Imagen != null)
				{
					producto.UrlImagen = GuardarImagen(Imagen);
				}
				if (producto.Descripcion != producto.Descripcion.Trim())
				{
					ModelState.AddModelError("Descripción", "La descripción no debe contener espacios");

					ViewBag.CategoriaId = new SelectList(categorias, "Id", "Descripcion");
					return View(producto);
				}
				if (producto.Precio == 0)
				{
					ModelState.AddModelError("Precio", "Ingrese el precio");

					ViewBag.CategoriaId = new SelectList(categorias, "Id", "Descripcion");
					return View(producto);
				}
				if (producto.Precio < 0)
				{
					ModelState.AddModelError("Precio", "Ingrese un precio mayor a 0");

					ViewBag.CategoriaId = new SelectList(categorias, "Id", "Descripcion");
					return View(producto);
				}
				if(producto.existencias < 0 && producto.existencias > 1000)
				{
					ModelState.AddModelError("Existencias", "Ingrese existencias mayor a 0 y menores a 1,000");

					ViewBag.CategoriaId = new SelectList(categorias, "Id", "Descripcion");
					return View(producto);
				}
				_productosBL.GuardarProducto(producto);
				return RedirectToAction("Index");
			}

			ViewBag.CategoriaId = new SelectList(categorias, "Id", "Descripcion");

			return View(producto);
        }
        public ActionResult Editar(int id)
        {
            var producto = _productosBL.ObtenerProducto(id);

            var categorias = _categoriasBL.ObtenerCategorias();

            ViewBag.CategoriaId = new SelectList(categorias, "Id", "Descripcion", producto.CategoriaId);

            return View(producto);

        }

        [HttpPost]
        public ActionResult Editar(Producto producto, HttpPostedFileBase Imagen)
        {
			var categorias = _categoriasBL.ObtenerCategorias();
			if (ModelState.IsValid)
			{
				if (producto.CategoriaId == 0)
				{
					ModelState.AddModelError("Categoria", "Selccione una categoría");
				}
				if (Imagen != null)
				{
					producto.UrlImagen = GuardarImagen(Imagen);
				}
				if (producto.Descripcion != producto.Descripcion.Trim())
				{
					ModelState.AddModelError("Descripción", "La descripción no debe contener espacios");

					ViewBag.CategoriaId = new SelectList(categorias, "Id", "Descripcion");
					return View(producto);
				}
				if (producto.Precio == 0)
				{
					ModelState.AddModelError("Precio", "Ingrese el precio");

					ViewBag.CategoriaId = new SelectList(categorias, "Id", "Descripcion");
					return View(producto);
				}
				if (producto.Precio < 0)
				{
					ModelState.AddModelError("Precio", "Ingrese un precio mayor a 0");

					ViewBag.CategoriaId = new SelectList(categorias, "Id", "Descripcion");
					return View(producto);
				}
				_productosBL.GuardarProducto(producto);
				return RedirectToAction("Index");
			}

			ViewBag.CategoriaId = new SelectList(categorias, "Id", "Descripcion");

			return View(producto);
		}

        public ActionResult Detalle(int id)
        {
            var producto = _productosBL.ObtenerProducto(id);
            return View(producto);

        }
        public ActionResult Eliminar(int id)
        {
            var producto = _productosBL.ObtenerProducto(id);
            return View(producto);

        }

        [HttpPost]
        public ActionResult Eliminar(Producto producto)
        {
            _productosBL.EliminarProducto(producto.ID);
            return RedirectToAction("Index");
        }

		private string GuardarImagen(HttpPostedFileBase imagen)
		{
			string path = Server.MapPath("~/Imagenes/" + imagen.FileName);
			imagen.SaveAs(path);
			return "/Imagenes/" + imagen.FileName;
		}
    }
}