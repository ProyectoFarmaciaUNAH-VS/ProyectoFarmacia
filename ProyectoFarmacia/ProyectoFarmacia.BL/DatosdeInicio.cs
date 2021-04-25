using ProyectoFarmacia.BL;
using System.Collections.Generic;
using System.Data.Entity;

namespace ProyectoFarmacia.BL
{
        public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
        {
            protected override void Seed(Contexto contexto)
            {

                //Usuario Administrador
                var nuevoUsuario = new Usuario();
                nuevoUsuario.Nombre = "admin";
                nuevoUsuario.Contrasena = Encriptar.CodificarContrasena("123");
                
                //Usuario Edwin Amaya
                var nuevoUsuario2 = new Usuario();
                nuevoUsuario2.Nombre = "witoea";
                nuevoUsuario2.Contrasena = Encriptar.CodificarContrasena("123");
                
                //Usuario Kary Hernandez
                var nuevoUsuario3 = new Usuario();
                nuevoUsuario3.Nombre = "khavila";
                nuevoUsuario3.Contrasena = Encriptar.CodificarContrasena("123");
                
                //Usuario Isaac Garcia 
                var nuevoUsuario4 = new Usuario();
                nuevoUsuario4.Nombre = "igarcia";
                nuevoUsuario4.Contrasena = Encriptar.CodificarContrasena("123");
                
                //Usuario Arnol Lopez
                var nuevoUsuario5 = new Usuario();
                nuevoUsuario5.Nombre = "arnol.l";
                nuevoUsuario5.Contrasena = Encriptar.CodificarContrasena("123");
                
                //se añade usuario a la Base de datos 
                contexto.Usuarios.Add(nuevoUsuario);
                contexto.Usuarios.Add(nuevoUsuario2);
                contexto.Usuarios.Add(nuevoUsuario3);
                contexto.Usuarios.Add(nuevoUsuario4);
                contexto.Usuarios.Add(nuevoUsuario5);

            base.Seed(contexto);
            }
        }
    }