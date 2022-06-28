using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica.Curso;
namespace CapaPresentacion.Curso
{
    public partial class Listar_Curso_Estado : Form
    {
        public Listar_Curso_Estado()
        {
            InitializeComponent();
            dataGridView1.DataSource = CL_Curso.Instancia.listar_curso_estado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
