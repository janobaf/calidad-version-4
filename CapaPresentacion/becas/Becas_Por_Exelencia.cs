using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica.Becas;
using CapaEntidad.Becas;
using CapaEntidad.Alumno;
using CapaPresentacion.becas;
namespace CapaPresentacion
{
    public partial class Becas_Por_Exelencia : Form
    {
        public Becas_Por_Exelencia()
        {
            InitializeComponent();
        }

        private void Buscarbutton1_Click(object sender, EventArgs e)
        {
            E_Alumno aux = CL_BecaExcelencia.Instancia.Mostrar_Alumno_Exelencia(DNItextBox1.Text);
            if (aux != null)
                dataGridView1.Rows.Add(aux.Alumn_nombre, aux.Alumn_ApellidoPaterno, aux.Alumn_ApellidoMaterno);
            else MessageBox.Show("no se encontro");
        }

        private void AtrasButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Becas_principal main = new Becas_principal();
            main.Show();
        }

    }
}
