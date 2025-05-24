using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Usuario
    {
        public Usuario() { }

        private String username;

        public string USERNAME
        {
            get { return username; }
            set { username = value; }
        }

        private string contrasenia;

        public string CONTRASENIA
        {
            get { return contrasenia; }
            set { contrasenia = value; }
        }
    }
}
