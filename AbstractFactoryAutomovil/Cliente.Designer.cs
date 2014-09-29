namespace AbstractFactoryAutomovil
{
    partial class Cliente
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Opciones = new System.Windows.Forms.GroupBox();
            this.btn_crear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_tipo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtn_chevrolet = new System.Windows.Forms.RadioButton();
            this.rbtn_mazda = new System.Windows.Forms.RadioButton();
            this.rbtn_renault = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.Opciones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Opciones);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 213);
            this.panel1.TabIndex = 0;
            // 
            // Opciones
            // 
            this.Opciones.Controls.Add(this.btn_crear);
            this.Opciones.Location = new System.Drawing.Point(3, 151);
            this.Opciones.Name = "Opciones";
            this.Opciones.Size = new System.Drawing.Size(254, 59);
            this.Opciones.TabIndex = 2;
            this.Opciones.TabStop = false;
            this.Opciones.Text = "Opciones";
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(112, 19);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(75, 23);
            this.btn_crear.TabIndex = 0;
            this.btn_crear.Text = "Crear";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmb_tipo);
            this.groupBox2.Location = new System.Drawing.Point(3, 92);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo";
            // 
            // cmb_tipo
            // 
            this.cmb_tipo.FormattingEnabled = true;
            this.cmb_tipo.Items.AddRange(new object[] {
            "Auto",
            "Carroceria",
            "Motor"});
            this.cmb_tipo.Location = new System.Drawing.Point(6, 19);
            this.cmb_tipo.Name = "cmb_tipo";
            this.cmb_tipo.Size = new System.Drawing.Size(121, 21);
            this.cmb_tipo.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_chevrolet);
            this.groupBox1.Controls.Add(this.rbtn_mazda);
            this.groupBox1.Controls.Add(this.rbtn_renault);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Marca";
            // 
            // rbtn_chevrolet
            // 
            this.rbtn_chevrolet.AutoSize = true;
            this.rbtn_chevrolet.Location = new System.Drawing.Point(7, 44);
            this.rbtn_chevrolet.Name = "rbtn_chevrolet";
            this.rbtn_chevrolet.Size = new System.Drawing.Size(70, 17);
            this.rbtn_chevrolet.TabIndex = 2;
            this.rbtn_chevrolet.TabStop = true;
            this.rbtn_chevrolet.Text = "Chevrolet";
            this.rbtn_chevrolet.UseVisualStyleBackColor = true;
            // 
            // rbtn_mazda
            // 
            this.rbtn_mazda.AutoSize = true;
            this.rbtn_mazda.Location = new System.Drawing.Point(119, 20);
            this.rbtn_mazda.Name = "rbtn_mazda";
            this.rbtn_mazda.Size = new System.Drawing.Size(57, 17);
            this.rbtn_mazda.TabIndex = 1;
            this.rbtn_mazda.Text = "Mazda";
            this.rbtn_mazda.UseVisualStyleBackColor = true;
            // 
            // rbtn_renault
            // 
            this.rbtn_renault.AutoSize = true;
            this.rbtn_renault.Checked = true;
            this.rbtn_renault.Location = new System.Drawing.Point(7, 20);
            this.rbtn_renault.Name = "rbtn_renault";
            this.rbtn_renault.Size = new System.Drawing.Size(62, 17);
            this.rbtn_renault.TabIndex = 0;
            this.rbtn_renault.TabStop = true;
            this.rbtn_renault.Text = "Renault";
            this.rbtn_renault.UseVisualStyleBackColor = true;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 237);
            this.Controls.Add(this.panel1);
            this.Name = "Cliente";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.Opciones.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtn_mazda;
        private System.Windows.Forms.RadioButton rbtn_renault;
        private System.Windows.Forms.GroupBox Opciones;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_tipo;
        private System.Windows.Forms.RadioButton rbtn_chevrolet;
    }
}

