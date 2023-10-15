using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace diseñogimnasio.Administracion_de_Gimnasio
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            PreciocomboBox2.SelectedIndex = MembresiacomboBox1.SelectedIndex;
        }

        private void MembresiacomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            PreciocomboBox2.SelectedIndex = MembresiacomboBox1.SelectedIndex;

            string membresiaSeleccionada = MembresiacomboBox1.SelectedItem.ToString();
            string precioSeleccionado = PreciocomboBox2.SelectedItem.ToString();


            if (membresiaSeleccionada.StartsWith("Membresía") && precioSeleccionado.StartsWith("Precio"))
            {
                MessageBox.Show("Selección válida.", "Validación exitosa");
            }
            else
            {
                MessageBox.Show("Selección no válida. Asegúrate de que la membresía y el precio coincidan.", "Validación fallida");
            }
        }

        private void Agregarbtn_Click(object sender, EventArgs e)
        {

        }
    }
}

