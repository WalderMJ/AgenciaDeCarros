namespace CAPA_DISEÑO
{
    partial class frmVehiculos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttonLimpiar = new System.Windows.Forms.Button();
            this.bttonCerrar = new System.Windows.Forms.Button();
            this.bttonEliminar = new System.Windows.Forms.Button();
            this.bttonActualizar = new System.Windows.Forms.Button();
            this.bttonGuardar = new System.Windows.Forms.Button();
            this.dgvVehiculos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxEstado = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtIDVehiculo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttonLimpiar
            // 
            this.bttonLimpiar.Location = new System.Drawing.Point(1088, 19);
            this.bttonLimpiar.Name = "bttonLimpiar";
            this.bttonLimpiar.Size = new System.Drawing.Size(88, 26);
            this.bttonLimpiar.TabIndex = 13;
            this.bttonLimpiar.Text = "Limpiar";
            this.bttonLimpiar.UseVisualStyleBackColor = true;
            this.bttonLimpiar.Click += new System.EventHandler(this.bttonLimpiar_Click);
            // 
            // bttonCerrar
            // 
            this.bttonCerrar.Location = new System.Drawing.Point(1249, 7);
            this.bttonCerrar.Name = "bttonCerrar";
            this.bttonCerrar.Size = new System.Drawing.Size(88, 26);
            this.bttonCerrar.TabIndex = 12;
            this.bttonCerrar.Text = "Cerrar";
            this.bttonCerrar.UseVisualStyleBackColor = true;
            this.bttonCerrar.Click += new System.EventHandler(this.bttonCerrar_Click);
            // 
            // bttonEliminar
            // 
            this.bttonEliminar.Location = new System.Drawing.Point(994, 19);
            this.bttonEliminar.Name = "bttonEliminar";
            this.bttonEliminar.Size = new System.Drawing.Size(88, 26);
            this.bttonEliminar.TabIndex = 11;
            this.bttonEliminar.Text = "Eliminar";
            this.bttonEliminar.UseVisualStyleBackColor = true;
            this.bttonEliminar.Click += new System.EventHandler(this.bttonEliminar_Click);
            // 
            // bttonActualizar
            // 
            this.bttonActualizar.Location = new System.Drawing.Point(900, 19);
            this.bttonActualizar.Name = "bttonActualizar";
            this.bttonActualizar.Size = new System.Drawing.Size(88, 26);
            this.bttonActualizar.TabIndex = 10;
            this.bttonActualizar.Text = "Actualizar";
            this.bttonActualizar.UseVisualStyleBackColor = true;
            this.bttonActualizar.Click += new System.EventHandler(this.bttonActualizar_Click);
            // 
            // bttonGuardar
            // 
            this.bttonGuardar.Location = new System.Drawing.Point(806, 19);
            this.bttonGuardar.Name = "bttonGuardar";
            this.bttonGuardar.Size = new System.Drawing.Size(88, 26);
            this.bttonGuardar.TabIndex = 9;
            this.bttonGuardar.Text = "Aguardar";
            this.bttonGuardar.UseVisualStyleBackColor = true;
            this.bttonGuardar.Click += new System.EventHandler(this.bttonGuardar_Click);
            // 
            // dgvVehiculos
            // 
            this.dgvVehiculos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvVehiculos.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculos.Location = new System.Drawing.Point(63, 278);
            this.dgvVehiculos.Name = "dgvVehiculos";
            this.dgvVehiculos.ReadOnly = true;
            this.dgvVehiculos.RowHeadersWidth = 51;
            this.dgvVehiculos.RowTemplate.Height = 24;
            this.dgvVehiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVehiculos.Size = new System.Drawing.Size(1242, 420);
            this.dgvVehiculos.TabIndex = 8;
            this.dgvVehiculos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculos_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxEstado);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtAño);
            this.groupBox1.Controls.Add(this.txtModelo);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.txtIDVehiculo);
            this.groupBox1.Location = new System.Drawing.Point(63, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1241, 200);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS VEHICULO";
            // 
            // cboxEstado
            // 
            this.cboxEstado.FormattingEnabled = true;
            this.cboxEstado.Items.AddRange(new object[] {
            "Disponible",
            "No Disponible"});
            this.cboxEstado.Location = new System.Drawing.Point(696, 108);
            this.cboxEstado.Name = "cboxEstado";
            this.cboxEstado.Size = new System.Drawing.Size(186, 24);
            this.cboxEstado.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(588, 108);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 16);
            this.label9.TabIndex = 14;
            this.label9.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Precio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(988, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Año";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(693, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Modelo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vehiculo ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Marca";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(296, 102);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(156, 22);
            this.txtPrecio.TabIndex = 4;
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(1053, 37);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(156, 22);
            this.txtAño.TabIndex = 3;
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(769, 34);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(156, 22);
            this.txtModelo.TabIndex = 2;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(482, 31);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(156, 22);
            this.txtMarca.TabIndex = 1;
            // 
            // txtIDVehiculo
            // 
            this.txtIDVehiculo.Location = new System.Drawing.Point(165, 31);
            this.txtIDVehiculo.Name = "txtIDVehiculo";
            this.txtIDVehiculo.Size = new System.Drawing.Size(156, 22);
            this.txtIDVehiculo.TabIndex = 0;
            // 
            // frmVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 768);
            this.ControlBox = false;
            this.Controls.Add(this.bttonLimpiar);
            this.Controls.Add(this.bttonCerrar);
            this.Controls.Add(this.bttonEliminar);
            this.Controls.Add(this.bttonActualizar);
            this.Controls.Add(this.bttonGuardar);
            this.Controls.Add(this.dgvVehiculos);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmVehiculos";
            this.Load += new System.EventHandler(this.frmVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttonLimpiar;
        private System.Windows.Forms.Button bttonCerrar;
        private System.Windows.Forms.Button bttonEliminar;
        private System.Windows.Forms.Button bttonActualizar;
        private System.Windows.Forms.Button bttonGuardar;
        private System.Windows.Forms.DataGridView dgvVehiculos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboxEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtIDVehiculo;
    }
}

