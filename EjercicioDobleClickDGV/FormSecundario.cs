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
         * Añadimos la ref del datagridview y las filas seleccionadas del FormPrincipal,
         * nos muestra los datos de la fila seleccionada
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

        /*
         * Este metodo guarda los datos que se han pasado de la fila seleccionada de FormPrincipal
         * y se si cambian los guarda y se actualizada en el FormPrincipal
         */
        private void btCopiarDatos_Click(object sender, EventArgs e)
        {

            filaExtraida[0].Value = this.tBNombre.Text;
            filaExtraida[1].Value = this.tBApellido.Text;
            filaExtraida[2].Value = this.tBTelefono.Text;
            filaExtraida[3].Value = this.tBDireccion.Text;

            Close();
        }

    }
}
