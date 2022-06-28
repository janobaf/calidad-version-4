using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad.Curso;
using CapaLogica.Curso;
namespace CapaPresentacion.InterfacesGraficas
{
    public partial class Registro_Curso : Form
    {
        public Registro_Curso()
        {
            InitializeComponent();
        }

        private void AlumnoIDtextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AtrasButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.Show();
        }
        private void reset()
        {
            NombreCursotextBox1.Text="";
            EstadotextBox2.Text="";
            dateTimePicker1.ResetText();
            DescripciontextBox3.Text="";
        }
        private void Continuarrbutton1_Click(object sender, EventArgs e)
        {
            string nombre_curso = NombreCursotextBox1.Text;
            string estado_curso = EstadotextBox2.Text;
            DateTime fecha_inscripcion = dateTimePicker1.Value;
            string descripcion_curso = DescripciontextBox3.Text;
            E_Curso curso = new E_Curso();
            curso.Curso_Nombre=nombre_curso;
            curso.Curso_Estado = estado_curso;
            curso.Curso_FecInscripcion = fecha_inscripcion;
            curso.Curso_Descripcion = descripcion_curso;
            if (CL_Curso.Instancia.crear_Curso(curso)) MessageBox.Show("Curso creado con exito");
            else MessageBox.Show("Error Creacion de Curso");
            reset();
        }
    }
}
