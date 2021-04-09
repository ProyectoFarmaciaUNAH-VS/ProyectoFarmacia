using System.Data.Entity;

namespace ProyectoFarmacia.BL
{

    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = "admin";
            nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("123");

            contexto.Usuarios.Add(nuevoUsuario);

            base.Seed(contexto);
        }
    }
}
