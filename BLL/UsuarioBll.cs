using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UsuarioBll
    {
        private UsuarioDal _repo;

        public UsuarioBll()
        {
            _repo = new UsuarioDal();
           

        }

        public Usuario Buscar(Usuario user)
        {
            // Llama al método DAL que ya tenés
            Usuario usuarioDesdeDAL = _repo.Buscar(user);

            if (usuarioDesdeDAL != null)
            {
                switch (usuarioDesdeDAL.TipoUser)
                {
                    case 1: // Webmaster
                        var webmaster = new PermisoCompuesto { Nombre = "Webmaster" };
                        webmaster.Agregar(new PermisoSimple { Nombre = "Bitácora" });
                        webmaster.Agregar(new PermisoSimple { Nombre = "Agregar productos" });
                        webmaster.Agregar(new PermisoSimple { Nombre = "Ver catálogo" });
                        webmaster.Agregar(new PermisoSimple { Nombre = "Agregar al carrito" });
                        usuarioDesdeDAL.Permiso = webmaster;
                        break;

                    case 2: // Admin
                        var admin = new PermisoCompuesto { Nombre = "Admin" };
                        admin.Agregar(new PermisoSimple { Nombre = "Agregar productos" });
                        admin.Agregar(new PermisoSimple { Nombre = "Ver catálogo" });
                        usuarioDesdeDAL.Permiso = admin;
                        break;

                    case 3: // Usuario común
                        usuarioDesdeDAL.Permiso = new PermisoSimple { Nombre = "Ver catálogo" };
                        break;
                }
            }

            return usuarioDesdeDAL;
        }
    }
}
