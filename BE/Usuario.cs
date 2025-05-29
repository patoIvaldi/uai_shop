using System;

namespace BE
{
    public class Usuario
    {
        public Usuario() { }

        private String username;

        public string NombreUsuario
        {
            get { return username; }
            set { username = value; }
        }

        private string clave;

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        private int tipoUser;

        public int TipoUser
        {
            get { return tipoUser; }
            set { tipoUser = value; }
        }

        public Perfil Permiso { get; set; }

    }
}
