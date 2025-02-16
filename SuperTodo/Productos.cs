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

    public partial class Productos : Form
    {
        string um = "";
        float precio = 0;

        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public float Importe { get; set; }
        public string UM { get; set; }
        public float PU { get; set; }

        public Productos()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void Productos_Load(object sender, EventArgs e)
        {
            cboCategorias.Items.Add("Quesos y Lacteos");
            cboCategorias.Items.Add("Bebidas");
            cboCategorias.Items.Add("Frutas y Verduras");
        }

        private void cboCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProductos.Items.Clear();

            if (cboCategorias.SelectedIndex == 0)
            {
                cboProductos.Items.Add("Queso Edam");
                cboProductos.Items.Add("Leche evaporada Gloria");
                cboProductos.Items.Add("Margarina Dorina");
                cboProductos.Items.Add("Yogurt bebible");
            }

            if (cboCategorias.SelectedIndex == 1)
            {
                cboProductos.Items.Add("Agua San Carlos sin gas");
                cboProductos.Items.Add("Cerveza Cusqueña Dorada");
                cboProductos.Items.Add("Gaseosa Pepsi no retornable");
            }

            if (cboCategorias.SelectedIndex == 2)
            {
                cboProductos.Items.Add("Naranja para jugo");
                cboProductos.Items.Add("Aceite Primor clasico");
                cboProductos.Items.Add("Trozos de Atun Florida");
            }
        }

        private void cboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string ruta = Application.StartupPath + "//Productos//";

            if (cboCategorias.SelectedIndex == 0 && cboProductos.SelectedIndex == 0)
            {
                um = "100g";
                precio = 3.25f;
                pictureBox1.ImageLocation = ruta + "queso.jpg";
            }
            if (cboCategorias.SelectedIndex == 0 && cboProductos.SelectedIndex == 1)
            {
                um = "six pack";
                precio = 16.89f;
                pictureBox1.ImageLocation = ruta + "leche.jpg";
            }
            if (cboCategorias.SelectedIndex == 0 && cboProductos.SelectedIndex == 2)
            {
                um = "450g";
                precio = 7.90f;
                pictureBox1.ImageLocation = ruta + "margarina.jpg";
            }
            if (cboCategorias.SelectedIndex == 0 && cboProductos.SelectedIndex == 3)
            {
                um = "bot.";
                precio = 3.99f;
                pictureBox1.ImageLocation = ruta + "yogurt.jpg";
            }
            if (cboCategorias.SelectedIndex == 1 && cboProductos.SelectedIndex == 0)
            {
                um = "bot.";
                precio = 1.20f;
                pictureBox1.ImageLocation = ruta + "agua.jpg";
            }
            if (cboCategorias.SelectedIndex == 1 && cboProductos.SelectedIndex == 1)
            {
                um = "bot.";
                precio = 15.90f;
                pictureBox1.ImageLocation = ruta + "cerveza.jpg";
            }
            if (cboCategorias.SelectedIndex == 1 && cboProductos.SelectedIndex == 2)
            {
                um = "bot.";
                precio = 5.00f;
                pictureBox1.ImageLocation = ruta + "gaseosa.jpg";
            }
            if (cboCategorias.SelectedIndex == 2 && cboProductos.SelectedIndex == 0)
            {
                um = "kg";
                precio = 1.49f;
                pictureBox1.ImageLocation = ruta + "naranja.jpg";
            }
            if (cboCategorias.SelectedIndex == 2 && cboProductos.SelectedIndex == 1)
            {
                um = "bot. 1 litro";
                precio = 5.99f;
                pictureBox1.ImageLocation = ruta + "aceite.jpg";
            }
            if (cboCategorias.SelectedIndex == 2 && cboProductos.SelectedIndex == 2)
            {
                um = "lata 170kg";
                precio = 4.85f;
                pictureBox1.ImageLocation = ruta + "atun.jpg";
            }

            lblUM.Text = um;
            lblPrecio.Text = precio.ToString();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Descripcion = cboProductos.Text;
            Cantidad = (int)nudCantidad.Value;
            UM = um;
            PU = precio;
            Importe = Cantidad * precio;

            this.DialogResult = DialogResult.OK;
            this.Close();

            
            
        }
    }
}
