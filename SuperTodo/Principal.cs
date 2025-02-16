using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuperTodo
{
    public partial class Principal : Form
    {
        float Subtotal = 0, IGV = 0, descuento = 0, total = 0, a = 0;

        private void Calcular()
        {
            int i = 0;
            float resultado = 0;

            while (i < lstImporte.Items.Count)
            {
                resultado += (float)(lstImporte.Items[i++]);

                if (rdb0.Checked)
                    a = resultado * 0.00f;
                else if (rdb5.Checked)
                    a = resultado * 0.05f;
                else if (rdb10.Checked)
                    a = resultado * 0.10f;
                else
                    a = 0;

                descuento = a;
                total = resultado - a;
                Subtotal = total / 1.18f;
                IGV = 0.18f * Subtotal;
            }

            lblTotal.Text = total.ToString();
            lblSub.Text = Subtotal.ToString();
            lblDescuento.Text = descuento.ToString();
            lblIGV.Text = IGV.ToString();
        }

        private void lstDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Dindice = lstDescripcion.SelectedIndex;

            lstCantidad.SelectedIndex = Dindice;
            lstUM.SelectedIndex = Dindice;
            lstPU.SelectedIndex = Dindice;
            lstImporte.SelectedIndex = Dindice;
        }

        private void lstCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Cindice = lstCantidad.SelectedIndex;

            lstDescripcion.SelectedIndex = Cindice;
            lstUM.SelectedIndex = Cindice;
            lstPU.SelectedIndex = Cindice;
            lstImporte.SelectedIndex = Cindice;
        }

        private void lstUM_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Uindice = lstUM.SelectedIndex;

            lstDescripcion.SelectedIndex = Uindice;
            lstCantidad.SelectedIndex = Uindice;
            lstPU.SelectedIndex = Uindice;
            lstImporte.SelectedIndex = Uindice;

        }

        private void lstPU_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Pindice = lstPU.SelectedIndex;

            lstDescripcion.SelectedIndex = Pindice;
            lstCantidad.SelectedIndex = Pindice;
            lstUM.SelectedIndex = Pindice;
            lstImporte.SelectedIndex = Pindice;
        }

        private void lstImporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Iindice = lstImporte.SelectedIndex;

            lstDescripcion.SelectedIndex = Iindice;
            lstCantidad.SelectedIndex = Iindice;
            lstUM.SelectedIndex = Iindice;
            lstPU.SelectedIndex = Iindice;
        }

        public Principal()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            rdb0.Checked = false;
            rdb5.Checked = false;
            rdb10.Checked = false;

            txtCliente.Clear();
            txtDireccion.Clear();
            txtRUC.Clear();

            lstDescripcion.Items.Clear();
            lstCantidad.Items.Clear();
            lstUM.Items.Clear();
            lstPU.Items.Clear();
            lstImporte.Items.Clear();


            lblSub.Text = "";
            lblDescuento.Text = "";
            lblIGV.Text = "";
            lblTotal.Text = "";

        }

        private void btnMas_Click(object sender, EventArgs e)
        {

            Productos productos = new Productos();

            DialogResult rpta = productos.ShowDialog(this);

            if (rpta == DialogResult.OK)
            {
                lstDescripcion.Items.Add(productos.Descripcion);
                lstCantidad.Items.Add(productos.Cantidad);
                lstUM.Items.Add(productos.UM);
                lstPU.Items.Add(productos.PU);
                lstImporte.Items.Add(productos.Importe);

            }

            Calcular();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {

            int indice = lstDescripcion.SelectedIndex;


            if (indice > -1)
            {
                lstDescripcion.Items.RemoveAt(indice);
                lstCantidad.Items.RemoveAt(indice);
                lstUM.Items.RemoveAt(indice);
                lstPU.Items.RemoveAt(indice);
                lstImporte.Items.RemoveAt(indice);

            }

            Calcular();

            if (lstImporte.Items.Count == 0)
            {
                lblTotal.Text = "";
                lblSub.Text = "";
                lblDescuento.Text = "";
                lblIGV.Text = "";
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
