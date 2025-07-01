namespace E1_UF2180___Practica_evaluable
{
    partial class Form1
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
            this.btnAnadirNuevoCliente = new System.Windows.Forms.Button();
            this.btnConsultarCliente = new System.Windows.Forms.Button();
            this.btnConsultarPorEmpleado = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnadirNuevoCliente
            // 
            this.btnAnadirNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAnadirNuevoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnadirNuevoCliente.Location = new System.Drawing.Point(50, 78);
            this.btnAnadirNuevoCliente.Name = "btnAnadirNuevoCliente";
            this.btnAnadirNuevoCliente.Size = new System.Drawing.Size(211, 159);
            this.btnAnadirNuevoCliente.TabIndex = 0;
            this.btnAnadirNuevoCliente.Text = "Añadir Nuevo Cliente";
            this.btnAnadirNuevoCliente.UseVisualStyleBackColor = false;
            this.btnAnadirNuevoCliente.Click += new System.EventHandler(this.btnAnadirNuevoCliente_Click_1);
            // 
            // btnConsultarCliente
            // 
            this.btnConsultarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnConsultarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarCliente.Location = new System.Drawing.Point(403, 78);
            this.btnConsultarCliente.Name = "btnConsultarCliente";
            this.btnConsultarCliente.Size = new System.Drawing.Size(241, 159);
            this.btnConsultarCliente.TabIndex = 1;
            this.btnConsultarCliente.Text = "Consultar Cliente";
            this.btnConsultarCliente.UseVisualStyleBackColor = false;
            this.btnConsultarCliente.Click += new System.EventHandler(this.btnConsultarCliente_Click);
            // 
            // btnConsultarPorEmpleado
            // 
            this.btnConsultarPorEmpleado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnConsultarPorEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultarPorEmpleado.Location = new System.Drawing.Point(778, 78);
            this.btnConsultarPorEmpleado.Name = "btnConsultarPorEmpleado";
            this.btnConsultarPorEmpleado.Size = new System.Drawing.Size(257, 159);
            this.btnConsultarPorEmpleado.TabIndex = 2;
            this.btnConsultarPorEmpleado.Text = "Consultar Clientes por Empleado";
            this.btnConsultarPorEmpleado.UseVisualStyleBackColor = false;
            this.btnConsultarPorEmpleado.Click += new System.EventHandler(this.btnConsultarPorEmpleado_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(433, 422);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(188, 93);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1087, 614);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnConsultarPorEmpleado);
            this.Controls.Add(this.btnConsultarCliente);
            this.Controls.Add(this.btnAnadirNuevoCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAnadirNuevoCliente;
        private System.Windows.Forms.Button btnConsultarCliente;
        private System.Windows.Forms.Button btnConsultarPorEmpleado;
        private System.Windows.Forms.Button btnSalir;
    }
}

