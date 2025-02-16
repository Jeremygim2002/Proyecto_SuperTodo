namespace SuperTodo
{
    partial class Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox2 = new GroupBox();
            rdb10 = new RadioButton();
            rdb5 = new RadioButton();
            rdb0 = new RadioButton();
            groupBox3 = new GroupBox();
            txtRUC = new TextBox();
            txtDireccion = new TextBox();
            txtCliente = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            lstDescripcion = new ListBox();
            lstCantidad = new ListBox();
            lstUM = new ListBox();
            lstPU = new ListBox();
            lstImporte = new ListBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            btnMas = new Button();
            btnMenos = new Button();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            lblSub = new Label();
            lblDescuento = new Label();
            lblIGV = new Label();
            lblTotal = new Label();
            btnNuevo = new Button();
            label22 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 13);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 116);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Consolas", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(283, 18);
            label1.Name = "label1";
            label1.Size = new Size(522, 57);
            label1.TabIndex = 1;
            label1.Text = "COMERCIALIZADORA Y DISTRIBUIDORA DE ABARROTES";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(578, 108);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 2;
            label2.Text = "Fecha: ";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(861, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(312, 120);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(88, 85);
            label3.Name = "label3";
            label3.Size = new Size(144, 19);
            label3.TabIndex = 4;
            label3.Text = "F001 - 00000001";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(120, 57);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 5;
            label4.Text = "FACTURA";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(88, 31);
            label5.Name = "label5";
            label5.Size = new Size(144, 19);
            label5.TabIndex = 6;
            label5.Text = "RUC 10548548759";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rdb10);
            groupBox2.Controls.Add(rdb5);
            groupBox2.Controls.Add(rdb0);
            groupBox2.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.Location = new Point(861, 150);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(312, 97);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Descuento:";
            // 
            // rdb10
            // 
            rdb10.AutoSize = true;
            rdb10.Location = new Point(216, 46);
            rdb10.Margin = new Padding(3, 2, 3, 2);
            rdb10.Name = "rdb10";
            rdb10.Size = new Size(50, 22);
            rdb10.TabIndex = 10;
            rdb10.TabStop = true;
            rdb10.Text = "10%";
            rdb10.UseVisualStyleBackColor = true;
            // 
            // rdb5
            // 
            rdb5.AutoSize = true;
            rdb5.Location = new Point(120, 46);
            rdb5.Margin = new Padding(3, 2, 3, 2);
            rdb5.Name = "rdb5";
            rdb5.Size = new Size(42, 22);
            rdb5.TabIndex = 9;
            rdb5.TabStop = true;
            rdb5.Text = "5%";
            rdb5.UseVisualStyleBackColor = true;
            // 
            // rdb0
            // 
            rdb0.AutoSize = true;
            rdb0.Location = new Point(34, 46);
            rdb0.Margin = new Padding(3, 2, 3, 2);
            rdb0.Name = "rdb0";
            rdb0.Size = new Size(42, 22);
            rdb0.TabIndex = 8;
            rdb0.TabStop = true;
            rdb0.Text = "0%";
            rdb0.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtRUC);
            groupBox3.Controls.Add(txtDireccion);
            groupBox3.Controls.Add(txtCliente);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label8);
            groupBox3.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.Location = new Point(36, 141);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(798, 106);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Datos del Cliente:";
            // 
            // txtRUC
            // 
            txtRUC.Location = new Point(493, 29);
            txtRUC.Margin = new Padding(3, 2, 3, 2);
            txtRUC.Name = "txtRUC";
            txtRUC.Size = new Size(291, 24);
            txtRUC.TabIndex = 17;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(122, 73);
            txtDireccion.Margin = new Padding(3, 2, 3, 2);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(662, 24);
            txtDireccion.TabIndex = 16;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(116, 30);
            txtCliente.Margin = new Padding(3, 2, 3, 2);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(306, 24);
            txtCliente.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(440, 32);
            label6.Name = "label6";
            label6.Size = new Size(40, 18);
            label6.TabIndex = 12;
            label6.Text = "RUC:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(20, 73);
            label7.Name = "label7";
            label7.Size = new Size(88, 18);
            label7.TabIndex = 13;
            label7.Text = "Direccion:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(20, 35);
            label8.Name = "label8";
            label8.Size = new Size(72, 18);
            label8.TabIndex = 14;
            label8.Text = "Cliente:";
            // 
            // lstDescripcion
            // 
            lstDescripcion.FormattingEnabled = true;
            lstDescripcion.ItemHeight = 15;
            lstDescripcion.Location = new Point(36, 284);
            lstDescripcion.Margin = new Padding(3, 2, 3, 2);
            lstDescripcion.Name = "lstDescripcion";
            lstDescripcion.Size = new Size(395, 169);
            lstDescripcion.TabIndex = 12;
            lstDescripcion.SelectedIndexChanged += lstDescripcion_SelectedIndexChanged;
            // 
            // lstCantidad
            // 
            lstCantidad.FormattingEnabled = true;
            lstCantidad.ItemHeight = 15;
            lstCantidad.Location = new Point(451, 284);
            lstCantidad.Margin = new Padding(3, 2, 3, 2);
            lstCantidad.Name = "lstCantidad";
            lstCantidad.RightToLeft = RightToLeft.Yes;
            lstCantidad.Size = new Size(127, 169);
            lstCantidad.TabIndex = 13;
            lstCantidad.SelectedIndexChanged += lstCantidad_SelectedIndexChanged;
            // 
            // lstUM
            // 
            lstUM.FormattingEnabled = true;
            lstUM.ItemHeight = 15;
            lstUM.Location = new Point(594, 284);
            lstUM.Margin = new Padding(3, 2, 3, 2);
            lstUM.Name = "lstUM";
            lstUM.RightToLeft = RightToLeft.Yes;
            lstUM.Size = new Size(127, 169);
            lstUM.TabIndex = 14;
            lstUM.SelectedIndexChanged += lstUM_SelectedIndexChanged;
            // 
            // lstPU
            // 
            lstPU.FormattingEnabled = true;
            lstPU.ItemHeight = 15;
            lstPU.Location = new Point(736, 284);
            lstPU.Margin = new Padding(3, 2, 3, 2);
            lstPU.Name = "lstPU";
            lstPU.RightToLeft = RightToLeft.Yes;
            lstPU.Size = new Size(127, 169);
            lstPU.TabIndex = 15;
            lstPU.SelectedIndexChanged += lstPU_SelectedIndexChanged;
            // 
            // lstImporte
            // 
            lstImporte.FormattingEnabled = true;
            lstImporte.ItemHeight = 15;
            lstImporte.Location = new Point(885, 284);
            lstImporte.Margin = new Padding(3, 2, 3, 2);
            lstImporte.Name = "lstImporte";
            lstImporte.RightToLeft = RightToLeft.Yes;
            lstImporte.Size = new Size(143, 169);
            lstImporte.TabIndex = 16;
            lstImporte.SelectedIndexChanged += lstImporte_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(885, 256);
            label9.Name = "label9";
            label9.Size = new Size(72, 18);
            label9.TabIndex = 17;
            label9.Text = "IMPORTE:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(736, 256);
            label10.Name = "label10";
            label10.Size = new Size(40, 18);
            label10.TabIndex = 18;
            label10.Text = "P.U.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(594, 256);
            label11.Name = "label11";
            label11.Size = new Size(40, 18);
            label11.TabIndex = 19;
            label11.Text = "U.M.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(451, 256);
            label12.Name = "label12";
            label12.Size = new Size(48, 18);
            label12.TabIndex = 20;
            label12.Text = "CANT:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(36, 256);
            label13.Name = "label13";
            label13.Size = new Size(104, 18);
            label13.TabIndex = 21;
            label13.Text = "DESCRIPCION:";
            // 
            // btnMas
            // 
            btnMas.BackgroundImage = (Image)resources.GetObject("btnMas.BackgroundImage");
            btnMas.Location = new Point(1051, 284);
            btnMas.Margin = new Padding(3, 2, 3, 2);
            btnMas.Name = "btnMas";
            btnMas.Size = new Size(96, 87);
            btnMas.TabIndex = 22;
            btnMas.UseVisualStyleBackColor = true;
            btnMas.Click += btnMas_Click;
            // 
            // btnMenos
            // 
            btnMenos.BackgroundImage = (Image)resources.GetObject("btnMenos.BackgroundImage");
            btnMenos.Location = new Point(1051, 375);
            btnMenos.Margin = new Padding(3, 2, 3, 2);
            btnMenos.Name = "btnMenos";
            btnMenos.Size = new Size(96, 78);
            btnMenos.TabIndex = 23;
            btnMenos.UseVisualStyleBackColor = true;
            btnMenos.Click += btnMenos_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(829, 581);
            label14.Name = "label14";
            label14.Size = new Size(56, 18);
            label14.TabIndex = 24;
            label14.Text = "TOTAL:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(846, 550);
            label15.Name = "label15";
            label15.Size = new Size(40, 18);
            label15.TabIndex = 25;
            label15.Text = "IGV:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(794, 520);
            label16.Name = "label16";
            label16.Size = new Size(88, 18);
            label16.TabIndex = 26;
            label16.Text = "DESCUENTO:";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(794, 485);
            label17.Name = "label17";
            label17.Size = new Size(88, 18);
            label17.TabIndex = 27;
            label17.Text = "SUB TOTAL:";
            // 
            // lblSub
            // 
            lblSub.BorderStyle = BorderStyle.FixedSingle;
            lblSub.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblSub.Location = new Point(909, 485);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(118, 17);
            lblSub.TabIndex = 28;
            lblSub.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblDescuento
            // 
            lblDescuento.BorderStyle = BorderStyle.FixedSingle;
            lblDescuento.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescuento.Location = new Point(909, 519);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(118, 17);
            lblDescuento.TabIndex = 29;
            lblDescuento.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblIGV
            // 
            lblIGV.BorderStyle = BorderStyle.FixedSingle;
            lblIGV.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblIGV.Location = new Point(909, 549);
            lblIGV.Name = "lblIGV";
            lblIGV.Size = new Size(118, 17);
            lblIGV.TabIndex = 30;
            lblIGV.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.Location = new Point(909, 581);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(118, 17);
            lblTotal.TabIndex = 31;
            lblTotal.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(38, 551);
            btnNuevo.Margin = new Padding(3, 2, 3, 2);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(232, 47);
            btnNuevo.TabIndex = 32;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label22
            // 
            label22.BorderStyle = BorderStyle.FixedSingle;
            label22.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(38, 485);
            label22.Name = "label22";
            label22.Size = new Size(684, 51);
            label22.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(647, 104);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(187, 23);
            dateTimePicker1.TabIndex = 34;
            // 
            // Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 605);
            Controls.Add(dateTimePicker1);
            Controls.Add(label22);
            Controls.Add(btnNuevo);
            Controls.Add(lblTotal);
            Controls.Add(lblIGV);
            Controls.Add(lblDescuento);
            Controls.Add(lblSub);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(btnMenos);
            Controls.Add(btnMas);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(lstImporte);
            Controls.Add(lstPU);
            Controls.Add(lstUM);
            Controls.Add(lstCantidad);
            Controls.Add(lstDescripcion);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox2;
        private RadioButton rdb10;
        private RadioButton rdb5;
        private RadioButton rdb0;
        private GroupBox groupBox3;
        private TextBox txtRUC;
        private TextBox txtDireccion;
        private TextBox txtCliente;
        private Label label6;
        private Label label7;
        private Label label8;
        private ListBox lstDescripcion;
        private ListBox lstCantidad;
        private ListBox lstUM;
        private ListBox lstPU;
        private ListBox lstImporte;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button btnMas;
        private Button btnMenos;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label lblSub;
        private Label lblDescuento;
        private Label lblIGV;
        private Label lblTotal;
        private Button btnNuevo;
        private Label label22;
        private DateTimePicker dateTimePicker1;
    }
}