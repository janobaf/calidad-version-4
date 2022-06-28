using CapaPresentacion.Inscripcion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Alumnos
{
    public partial class M_alumno : Form
    {
        public M_alumno()
        {
            InitializeComponent();
        }

        private void CrearButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Alumno registro_Alumno = new Registro_Alumno();
            registro_Alumno.Show();
        }

        private void ListarButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListarAlumnos listarAlumnos = new ListarAlumnos();
            listarAlumnos.Show();
        }

        private void EditarButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modificar_Alumno modificar_Alumno = new Modificar_Alumno();
            modificar_Alumno.Show();
        }

        private void Atrasbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }
    }
}
