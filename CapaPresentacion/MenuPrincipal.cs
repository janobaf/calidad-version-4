using CapaPresentacion.Alumnos;
using CapaPresentacion.Calificaciones;
using CapaPresentacion.Curso;
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
using CapaLogica.Becas;
using CapaEntidad.Alumno;
using CapaPresentacion.becas;
namespace CapaPresentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        // NotSupportedException
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void Becasbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Becas_principal beca_main = new Becas_principal();
            beca_main.Show();
        }

        private void Calificacionesbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            M_Calificaciones m_Calificaciones = new M_Calificaciones();
            m_Calificaciones.Show();
        }

        private void Cursobutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            M_Curso m_Curso = new M_Curso();
            m_Curso.Show();
        }

        private void SalirButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void AlumnosButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            M_alumno m_Alumno = new M_alumno();
            m_Alumno.Show();
        }
    }
}
