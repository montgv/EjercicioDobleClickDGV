using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioDobleClickDGV
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            //Llamamos a la función para que nos genere los datos del datagridview
            definirDatosIniciales(5);
        }
        /*
        * Función que nos genera los datos del datagridview de manera secuencial
        */
        private void definirDatosIniciales (int numeroDatos)
        {
            for (int i = 0; i < numeroDatos; i++)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dgv);
                fila.Cells[0].Value = "Montse";
                fila.Cells[1].Value = "Garrido";
                fila.Cells[2].Value = "654456654";
                fila.Cells[3].Value = "C/Mariana Pineda nº3";

                dgv.Rows.Add(fila);
            }

            //Le asignamos a los datos que sean de un valor específico
            this.dgv.Columns[0].ValueType = Type.GetType("System.String");
            this.dgv.Columns[1].ValueType = Type.GetType("System.String");
            this.dgv.Columns[2].ValueType = Type.GetType("System.String");
            this.dgv.Columns[3].ValueType = Type.GetType("System.String");
        }

        /*
         * Guardamos los datos en el datagridview de los datos introducidos
         */
        private void btAgregar_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dgv);
            fila.Cells[0].Value = this.tBNombre.Text;
            fila.Cells[1].Value = this.tBApellido.Text;
            fila.Cells[2].Value = this.tBTelefono.Text;
            fila.Cells[3].Value = this.tBDireccion.Text;

            dgv.Rows.Add(fila);

            this.tBNombre.Text = "";
            this.tBApellido.Text = "";
            this.tBTelefono.Text = "";
            this.tBDireccion.Text = "";
        }

        /*
         * Este metodo cuando hacemos doble click en una fila lo que hace es que coge los datos de la 
         * fila y nos lo pasa a FormSecundario
         */
        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewCellCollection datosFila = dgv.CurrentRow.Cells;

            //Paso por referencia tanto el dvg como datosFilas
            FormSecundario formSecundario = new FormSecundario(ref datosFila);
            formSecundario.Show();
        }

        /*
        * Borramos la fila seleccionada del dgv
        */
        private void btEliminar_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null)
            {
                return;
            }

            dgv.Rows.Remove(dgv.CurrentRow);
        }

        /*
         * Comprobamos los datos introducidos en el tBTelefono, si la longitud del texto de telefono es distinto de 9
         * se cambian el fondo del textbox a rojo y sino el fondo es blanco
         */
        private void tBTelefono_TextChanged(object sender, EventArgs e)
        {
            string telef = tBTelefono.Text;

            if (telef.Length != 9)
            {
                tBTelefono.BackColor = Color.Red;
            } else
            {
                tBTelefono.BackColor = Color.White;
            }
        }

    }
}
