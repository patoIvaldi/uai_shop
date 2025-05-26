using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class PermisoCompuesto : PerfilDeAcceso
    {
        private List<PerfilDeAcceso> _hijos = new List<PerfilDeAcceso>();

        public void Agregar(PerfilDeAcceso permiso)
        {
            _hijos.Add(permiso);
        }

        public void Quitar(PerfilDeAcceso permiso)
        {
            _hijos.Remove(permiso);
        }

        public override List<PerfilDeAcceso> GetPermisos()
        {
            List<PerfilDeAcceso> todos = new List<PerfilDeAcceso>();

            foreach (var hijo in _hijos)
            {
                todos.AddRange(hijo.GetPermisos());
            }

            return todos;
        }
    }
}
