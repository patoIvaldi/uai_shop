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

            return _repo.Buscar(user);
        }
    }
}
