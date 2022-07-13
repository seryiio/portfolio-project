using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class DataFactura
    {
        public string RegistrarFactura(Cliente objcliente,  HerramientaCartera objherramientacartera, Factura objfactura)
        {
            using (var contexto = new TFFinanzasEntities())
            {
                contexto.Clientes.Add(objcliente);
                contexto.HerramientaCarteras.Add(objherramientacartera);
                contexto.Facturas.Add(objfactura);
                contexto.SaveChanges();
                return "Se registraron los datos";
            }

        }
        public List<HerramientaCartera> ListarFacturas()
        {
            TFFinanzasEntities contexto = new TFFinanzasEntities();
            return contexto.HerramientaCarteras.ToList<HerramientaCartera>();
        }

        public List<Cliente> ListarClientes()
        {
            TFFinanzasEntities contexto = new TFFinanzasEntities();
            return contexto.Clientes.ToList<Cliente>();
        }
    }
}
