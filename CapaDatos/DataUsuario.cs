using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataUsuario
    {
        public string RegistrarUsuario(Usuario objusuario)
        {
            using (var contexto = new TFFinanzasEntities())
            {
                contexto.Usuarios.Add(objusuario);
                contexto.SaveChanges();
                return "Usted se registro exitosamente";
            }


        }
        public List<Usuario> ListarUsuarios()
        {
            TFFinanzasEntities contexto = new TFFinanzasEntities();
            return contexto.Usuarios.ToList<Usuario>();

        }
    }
}
