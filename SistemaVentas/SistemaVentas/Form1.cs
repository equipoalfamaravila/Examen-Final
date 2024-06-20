using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Llamar al mapeado objeto relacional a través de un objeto
        VentasDataContext ventas = new VentasDataContext();

        private void Listar()
        {
            var consulta = from V in ventas.Vendedor
                           select V;
            dgvVendedor.DataSource = consulta;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void BtnaAgregar_Click(object sender, EventArgs e)
        {
            Vendedor vendedor = new Vendedor();
            vendedor.CodVendedor = txtCodVendedor.Text;
            vendedor.Apellidos = txtaApellidos.Text;
            vendedor.Nombres = txtNombres.Text;
            ventas.Vendedor.InsertOnSubmit(vendedor);
            try
            {
                ventas.SubmitChanges();//Confirmar la transaccion
                txtCodVendedor.Clear(); txtNombres.Clear(); txtaApellidos.Clear();
                txtCodVendedor.Focus();
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var CodVendedorEliminar = (from V in ventas.Vendedor
                                       where V.CodVendedor.Contains(txtCodVendedor.Text)
                                       select V).First();

            ventas.Vendedor.DeleteOnSubmit(CodVendedorEliminar);
            try
            {
                ventas.SubmitChanges(); //CONFIRMAR LA TRANSACCION
                txtCodVendedor.Clear(); txtNombres.Clear(); txtaApellidos.Clear();
                txtCodVendedor.Focus();
                Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            var CodVendedorActualizar = (from V in ventas.Vendedor
                                         where V.CodVendedor.Contains(txtCodVendedor.Text)
                                         select V).FirstOrDefault();
            if (CodVendedorActualizar != null)
            {
                CodVendedorActualizar.Nombres = txtNombres.Text;
                CodVendedorActualizar.Apellidos = txtaApellidos.Text;
            }

            try
            {
                ventas.SubmitChanges(); //CONFIRMAR LA TRANSACCION
                txtCodVendedor.Clear(); txtNombres.Clear(); txtaApellidos.Clear();
                txtCodVendedor.Focus();
                Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
