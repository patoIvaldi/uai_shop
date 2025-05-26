using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class PerfilDeAcceso
    {
        public string Nombre { get; set; }

        public abstract List<PerfilDeAcceso> GetPermisos();
    }
}
