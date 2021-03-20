using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFarmacia.BL
{
    public class Producto
    {
       public Producto ()
        {
        Activo = true;
        }
        [Display(Name ="Código")]
        public int ID { get; set; }

		[Display(Name = "Descripción")]
		[Required(ErrorMessage ="Ingrese el producto")]
		[MinLength(3, ErrorMessage = "Ingrese un mínimo 3 caracteres")]
		[MaxLength(30, ErrorMessage = "Ingrese un maximo 20 caracteres")]
		public string Descripcion { get; set; }

		[Display(Name = "Precio")]
		[Required(ErrorMessage = "Ingrese el precio")]
		[Range(0, 100000, ErrorMessage = "Ingrese un precio de 0 a 100,000")]
		public double Precio { get; set; }

		[Display(Name = "Fecha de vencimiento")]
		public DateTime fechaVencimiento{ get; set; }

		[Display(Name = "Categoría")]
		[Required(ErrorMessage = "Seleccione una categoría")]
		public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }

		//Existencias
		[Display(Name = "Existencias")]
		[Required(ErrorMessage = "Ingrese la existencia")]
		[Range(0, 10000, ErrorMessage = "Ingrese un precio mayor a 0")]
		public int existencias { get; set; }

		////Llave forane con tabla Presentación
		//public int presentacionId { get; set; }
		//public Presentacion Presentacion { get; set; }

		////Llave forane con tabla Proveedor
		//public int proveedorId { get; set; }
		//public Proveedor Proveedor { get; set; }

		[Display(Name ="Imagen")]
		public string UrlImagen { get; set; }

		public bool Activo { get; set; }

    }
}
