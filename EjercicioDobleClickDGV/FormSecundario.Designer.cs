namespace EjercicioDobleClickDGV
{
    partial class FormSecundario
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.tBApellido = new System.Windows.Forms.TextBox();
            this.tBTelefono = new System.Windows.Forms.TextBox();
            this.tBDireccion = new System.Windows.Forms.TextBox();
            this.btCopiarDatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(58, 61);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(47, 13);
            this.lbNombre.TabIndex = 0;
            this.lbNombre.Text = "Nombre:";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(58, 95);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(47, 13);
            this.lbApellido.TabIndex = 1;
            this.lbApellido.Text = "Apellido:";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(58, 130);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(52, 13);
            this.lbTelefono.TabIndex = 2;
            this.lbTelefono.Text = "Teléfono:";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(58, 164);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(55, 13);
            this.lbDireccion.TabIndex = 3;
            this.lbDireccion.Text = "Dirección:";
            // 
            // tBNombre
            // 
            this.tBNombre.Location = new System.Drawing.Point(111, 58);
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(185, 20);
            this.tBNombre.TabIndex = 4;
            // 
            // tBApellido
            // 
            this.tBApellido.Location = new System.Drawing.Point(111, 92);
            this.tBApellido.Name = "tBApellido";
            this.tBApellido.Size = new System.Drawing.Size(185, 20);
            this.tBApellido.TabIndex = 5;
            // 
            // tBTelefono
            // 
            this.tBTelefono.Location = new System.Drawing.Point(111, 127);
            this.tBTelefono.Name = "tBTelefono";
            this.tBTelefono.Size = new System.Drawing.Size(185, 20);
            this.tBTelefono.TabIndex = 6;
            // 
            // tBDireccion
            // 
            this.tBDireccion.Location = new System.Drawing.Point(111, 161);
            this.tBDireccion.Name = "tBDireccion";
            this.tBDireccion.Size = new System.Drawing.Size(185, 20);
            this.tBDireccion.TabIndex = 7;
            // 
            // btCopiarDatos
            // 
            this.btCopiarDatos.Location = new System.Drawing.Point(61, 206);
            this.btCopiarDatos.Name = "btCopiarDatos";
            this.btCopiarDatos.Size = new System.Drawing.Size(235, 23);
            this.btCopiarDatos.TabIndex = 8;
            this.btCopiarDatos.Text = "Copiar al portapapeles sus datos";
            this.btCopiarDatos.UseVisualStyleBackColor = true;
            this.btCopiarDatos.Click += new System.EventHandler(this.btCopiarDatos_Click);
            // 
            // FormSecundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 257);
            this.Controls.Add(this.btCopiarDatos);
            this.Controls.Add(this.tBDireccion);
            this.Controls.Add(this.tBTelefono);
            this.Controls.Add(this.tBApellido);
            this.Controls.Add(this.tBNombre);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Name = "FormSecundario";
            this.Text = "FormSecundario";
            this.Load += new System.EventHandler(this.FormSecundario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.TextBox tBApellido;
        private System.Windows.Forms.TextBox tBTelefono;
        private System.Windows.Forms.TextBox tBDireccion;
        private System.Windows.Forms.Button btCopiarDatos;
    }
}