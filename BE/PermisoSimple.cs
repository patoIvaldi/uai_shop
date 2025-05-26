using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PermisoSimple : PerfilDeAcceso
    {
        public override List<PerfilDeAcceso> GetPermisos()
        {
            return new List<PerfilDeAcceso> { this };
        }
    }
}
