using CapaPresentacion.InterfacesGraficas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Curso
{
    public partial class M_Curso : Form
    {
        public M_Curso()
        {
            InitializeComponent();
        }

        private void Regresarbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }

        private void Listarbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listar_Curso listar_Curso = new Listar_Curso();
            listar_Curso.Show();
        }

        private void Registrobutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Curso registro_Curso = new Registro_Curso();
            registro_Curso.Show();
        }
    }
}
