namespace SuperTodo
{
    partial class Productos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblUM = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.cboCategorias = new System.Windows.Forms.ComboBox();
            this.cboProductos = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(293, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categorias:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(736, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(294, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "U.M.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(293, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "Productos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(527, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Precio:";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(850, 151);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(103, 27);
            this.nudCantidad.TabIndex = 6;
            this.nudCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudCantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblUM
            // 
            this.lblUM.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUM.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUM.Location = new System.Drawing.Point(371, 158);
            this.lblUM.Name = "lblUM";
            this.lblUM.Size = new System.Drawing.Size(150, 26);
            this.lblUM.TabIndex = 7;
            // 
            // lblPrecio
            // 
            this.lblPrecio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPrecio.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.Location = new System.Drawing.Point(613, 156);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(117, 26);
            this.lblPrecio.TabIndex = 8;
            // 
            // cboCategorias
            // 
            this.cboCategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategorias.FormattingEnabled = true;
            this.cboCategorias.Location = new System.Drawing.Point(419, 40);
            this.cboCategorias.Name = "cboCategorias";
            this.cboCategorias.Size = new System.Drawing.Size(534, 28);
            this.cboCategorias.TabIndex = 9;
            this.cboCategorias.SelectedIndexChanged += new System.EventHandler(this.cboCategorias_SelectedIndexChanged);
            // 
            // cboProductos
            // 
            this.cboProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProductos.FormattingEnabled = true;
            this.cboProductos.Location = new System.Drawing.Point(419, 97);
            this.cboProductos.Name = "cboProductos";
            this.cboProductos.Size = new System.Drawing.Size(534, 28);
            this.cboProductos.TabIndex = 10;
            this.cboProductos.SelectedIndexChanged += new System.EventHandler(this.cboProductos_SelectedIndexChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(613, 217);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(157, 56);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(796, 217);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(157, 56);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(25, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 297);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.cboProductos);
            this.Controls.Add(this.cboCategorias);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblUM);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown nudCantidad;
        private Label lblUM;
        private Label lblPrecio;
        private ComboBox cboCategorias;
        private ComboBox cboProductos;
        private Button btnAceptar;
        private Button btnCancelar;
        private PictureBox pictureBox1;
    }
}