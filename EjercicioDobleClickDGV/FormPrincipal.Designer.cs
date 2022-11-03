namespace EjercicioDobleClickDGV
{
    partial class FormPrincipal
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
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.tBApellido = new System.Windows.Forms.TextBox();
            this.tBTelefono = new System.Windows.Forms.TextBox();
            this.tBDireccion = new System.Windows.Forms.TextBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.lbInformExtra = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tBNombre
            // 
            this.tBNombre.Location = new System.Drawing.Point(89, 76);
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(100, 20);
            this.tBNombre.TabIndex = 0;
            // 
            // tBApellido
            // 
            this.tBApellido.Location = new System.Drawing.Point(204, 76);
            this.tBApellido.Name = "tBApellido";
            this.tBApellido.Size = new System.Drawing.Size(100, 20);
            this.tBApellido.TabIndex = 1;
            // 
            // tBTelefono
            // 
            this.tBTelefono.Location = new System.Drawing.Point(320, 76);
            this.tBTelefono.Name = "tBTelefono";
            this.tBTelefono.Size = new System.Drawing.Size(100, 20);
            this.tBTelefono.TabIndex = 2;
            this.tBTelefono.TextChanged += new System.EventHandler(this.tBTelefono_TextChanged);
            // 
            // tBDireccion
            // 
            this.tBDireccion.Location = new System.Drawing.Point(433, 76);
            this.tBDireccion.Name = "tBDireccion";
            this.tBDireccion.Size = new System.Drawing.Size(100, 20);
            this.tBDireccion.TabIndex = 3;
            // 
            // btAgregar
            // 
            this.btAgregar.Location = new System.Drawing.Point(583, 76);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(75, 23);
            this.btAgregar.TabIndex = 4;
            this.btAgregar.Text = "Agregar";
            this.btAgregar.UseVisualStyleBackColor = true;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Location = new System.Drawing.Point(583, 146);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 5;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // lbInformExtra
            // 
            this.lbInformExtra.AutoSize = true;
            this.lbInformExtra.Location = new System.Drawing.Point(342, 109);
            this.lbInformExtra.Name = "lbInformExtra";
            this.lbInformExtra.Size = new System.Drawing.Size(78, 13);
            this.lbInformExtra.TabIndex = 6;
            this.lbInformExtra.Text = "!= 9 caracteres";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNombre,
            this.ColumnApellido,
            this.ColumnTelefono,
            this.ColumnDireccion});
            this.dgv.Location = new System.Drawing.Point(89, 146);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(444, 168);
            this.dgv.TabIndex = 7;
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.Name = "ColumnNombre";
            // 
            // ColumnApellido
            // 
            this.ColumnApellido.HeaderText = "Apellido";
            this.ColumnApellido.Name = "ColumnApellido";
            // 
            // ColumnTelefono
            // 
            this.ColumnTelefono.HeaderText = "Teléfono";
            this.ColumnTelefono.Name = "ColumnTelefono";
            // 
            // ColumnDireccion
            // 
            this.ColumnDireccion.HeaderText = "Dirección";
            this.ColumnDireccion.Name = "ColumnDireccion";
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.BackColor = System.Drawing.Color.Red;
            this.lbColor.Location = new System.Drawing.Point(317, 109);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(25, 13);
            this.lbColor.TabIndex = 8;
            this.lbColor.Text = "      ";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 361);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lbInformExtra);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.tBDireccion);
            this.Controls.Add(this.tBTelefono);
            this.Controls.Add(this.tBApellido);
            this.Controls.Add(this.tBNombre);
            this.Name = "FormPrincipal";
            this.Text = "FormPrincipal";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.TextBox tBApellido;
        private System.Windows.Forms.TextBox tBTelefono;
        private System.Windows.Forms.TextBox tBDireccion;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Label lbInformExtra;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDireccion;
        private System.Windows.Forms.Label lbColor;
    }
}