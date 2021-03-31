using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFarmacia.BL
{
    public class Categoria
    {
        public int Id { get; set; }
		[Required(ErrorMessage = "Ingrese una categoría")]
		[MinLength(3, ErrorMessage = "Ingrese un mínimo 3 caracteres")]
		[MaxLength(20, ErrorMessage = "Ingrese un maximo 20 caracteres")]
		public string Descripcion { get; set; }
    }
}
