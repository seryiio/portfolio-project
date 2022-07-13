using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class NegFactura
    {
        private DataFactura objDatafactura = new DataFactura();
        public string RegistrarFactura(Cliente objcliente, HerramientaCartera objherramientacartera, Factura objfactura)
        {
            return objDatafactura.RegistrarFactura(objcliente, objherramientacartera, objfactura);
        }
        public List<HerramientaCartera> ListarFacturas()
        {
            return objDatafactura.ListarFacturas();
        }

        public List<Cliente> ListarClientes()
        {
            return objDatafactura.ListarClientes();
        }
    } 
}