using System.ComponentModel.DataAnnotations;

namespace ProyectoFarmacia.BL
{
    public class Usuario
    {
                
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasena { get; set; }
    }
}