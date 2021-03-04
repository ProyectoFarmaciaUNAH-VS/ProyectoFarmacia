namespace ProyectoFarmacia.BL
{
    public class Producto
    {
       public Producto ()
        {
        Activo = true;
        }
        
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public bool Activo { get; set; }

    }
}
