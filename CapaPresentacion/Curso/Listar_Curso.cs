using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Curso;
using CapaLogica.Curso;
namespace CapaPresentacion.InterfacesGraficas
{
    public partial class Listar_Curso : Form
    {
        public Listar_Curso()
        {
            InitializeComponent();
            ProfesordataGridView1.DataSource = CL_Curso.Instancia.listar_cursos();
        }

        private void Salirbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            M_Curso principal = new M_Curso();
            principal.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
