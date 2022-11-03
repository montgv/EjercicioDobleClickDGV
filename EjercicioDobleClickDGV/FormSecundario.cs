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
    public partial class FormSecundario : Form
    {
        //Creamos las variales a utilizar
        public String nombre, apellido, telefono, direccion;

        //Creamos la variable datagridview que vamos a usar
        DataGridView dataGridViewCompleto;

        //Creamos la variable datagridviewcellcolllection que vamos a usar
        DataGridViewCellCollection filaExtraida;

        public FormSecundario()
        {
            InitializeComponent();
        }

        /*
         * Añadimos la ref del datagridview del FormPrincipal
         */
        public FormSecundario(ref DataGridView dgv)
        {
            InitializeComponent();

            dataGridViewCompleto = dgv;
        }

        /*
         * Añadimos la ref del datagridview y las filas seleccionadas del FormPrincipal
         */
        public FormSecundario(ref DataGridViewCellCollection fila)
        {
            InitializeComponent();

            this.tBNombre.Text = fila[0].Value.ToString();
            this.tBApellido.Text = fila[1].Value.ToString();
            this.tBTelefono.Text = fila[2].Value.ToString();
            this.tBDireccion.Text = fila[3].Value.ToString();

            filaExtraida = fila;
        }

        private void FormSecundario_Load(object sender, EventArgs e)
        {

        }

        private void btCopiarDatos_Click(object sender, EventArgs e)
        {
            //Si no hay fila extraido, añadimos nuevos datos al datagridview y sino cambiamos los datos de la fila extraida
            if (filaExtraida == null)
            {
                DataGridViewRow fila = new DataGridViewRow();
                fila.CreateCells(dataGridViewCompleto);
                fila.Cells[0].Value = this.tBNombre.Text;
                fila.Cells[1].Value = this.tBApellido.Text;
                fila.Cells[2].Value = this.tBTelefono.Text;
                fila.Cells[3].Value = this.tBDireccion.Text;

                dataGridViewCompleto.Rows.Add(fila);

                this.tBNombre.Text = "";
                this.tBApellido.Text = "";
                this.tBTelefono.Text = "";
                this.tBDireccion.Text = "";
            } else
            {
                filaExtraida[0].Value = this.tBNombre.Text;
                filaExtraida[1].Value = this.tBApellido.Text;
                filaExtraida[2].Value = this.tBTelefono.Text;
                filaExtraida[3].Value = this.tBDireccion.Text;
            }

            Close();
        }

    }
}
