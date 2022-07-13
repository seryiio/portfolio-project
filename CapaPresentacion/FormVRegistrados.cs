using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;
namespace CapaPresentacion
{
    public partial class FormVRegistrados : Form
    {
        Factura objFactura;
        HerramientaCartera objHerramienta;
        Cliente objCliente;
        NegFactura objNegFactura;
        public FormVRegistrados()
        {
            InitializeComponent();
            objFactura = new Factura();
            objHerramienta = new HerramientaCartera();
            objNegFactura = new NegFactura();
        }
        void ActualizarDatagridReporte()
        {
            if ((int)objFactura.IdHerramientaCartera == (int)objHerramienta.IdHerramientaCartera) {
            dgvclientes.DataSource = objNegFactura.ListarClientes();
            dgvclientes.Columns["IdCliente"].Visible = false;
            dgvclientes.Columns["apellidos"].Visible = false;
            dgvclientes.Columns["direccion"].Visible = false;
            dgvclientes.Columns["email"].Visible = false;
            dgvclientes.Columns["celular"].Visible = false;
            dgvclientes.Columns["DNI"].Visible = false;
            dgvclientes.Columns["ciudad"].Visible = false;
            dgvclientes.Columns["Factura"].Visible = false;
            dgvclientes.Columns["Letra"].Visible = false;
            dgvclientes.Columns["RecibosxHonorario"].Visible = false;
            dgvRegistrados.Columns.Add("tipo", "Tipo");
            dgvRegistrados.DataSource = objNegFactura.ListarFacturas();
            dgvRegistrados.Columns["IdHerramientaCartera"].Visible = false;
            dgvRegistrados.Columns["FechaDescuento"].Visible = false;
            dgvRegistrados.Columns["MonedaSoles"].Visible = false;
            dgvRegistrados.Columns["MonedaDolares"].Visible = false;
            dgvRegistrados.Columns["Factura"].Visible = false;
            dgvRegistrados.Columns["Letra"].Visible = false;
            dgvRegistrados.Columns["RecibosxHonorario"].Visible = false;
            }
        }
        private void FormVRegistrados_Load(object sender, EventArgs e)
        {
            Factura objreporte = new Factura();
            ActualizarDatagridReporte();
        }
    }
}
