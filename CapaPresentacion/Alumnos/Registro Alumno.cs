using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad.Alumno;
using CapaPresentacion.Alumnos;
using CapaPresentacion.Inscripcion;
using CapaPresentacion.Curso;
using CapaLogica.Curso;
namespace CapaPresentacion
{
    public partial class Registro_Alumno : Form
    {
        public Registro_Alumno()
        {
            InitializeComponent();
            panel1.Enabled = false;
        }
       
       
        private void Salitbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            M_alumno alumno = new M_alumno();
            alumno.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dn1i = DNItextBox1.Text;
            if (L_Alumno.Instancia.verificar_existencia_alumno(dn1i) )
            {
                this.Hide();
                Modificar_Alumno ma = new Modificar_Alumno();

                ma.Show();
            }
            else 
                if (dn1i.Length == 8)
                    panel1.Enabled = true;

        }
        private void reset()
        {
            panel1.Enabled = false;
            NombretextBox1.Text="";
            ApePaternotextBox1.Text="";
            ApeMaternotextBox1.Text="";
            DirecciontextBox1.Text ="";
            fechaNacidateTimePicker1.Text="";
            NivelEducativo_txt.Text="";
            DNItextBox1.Text = "";
            CorreotextBox1.Text = "";
            TelefonotextBox1.Text = "";
            Pension_txt.Text = "";
            nomApoderadotextBox1.Text = "";
            apPaternoApoderadotextBox1.Text = "";
            ApeMaternoApoderadotextBox1.Text = "";
            EstadotextBox1.Text = "";
            Curso_ID_TEXT.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = NombretextBox1.Text;
            string apellido_paterno = ApePaternotextBox1.Text;
            string apellido_materno = ApeMaternotextBox1.Text;
            string dirreccion = DirecciontextBox1.Text;
            DateTime fecha_nacimiento = DateTime.Parse(fechaNacidateTimePicker1.Text);
            string nivel_educativo = NivelEducativo_txt.Text;
            string dniAlumno = DNItextBox1.Text;
            string correo = CorreotextBox1.Text;
            string telefono = TelefonotextBox1.Text;
            float pension = float.Parse(Pension_txt.Text);
            string nombre_apoderado = nomApoderadotextBox1.Text;
            string apellido_paterno_apoderado = apPaternoApoderadotextBox1.Text;
            string apellido_materno_apoderado = ApeMaternoApoderadotextBox1.Text;
            string estado = EstadotextBox1.Text;
            int Curso_id = int.Parse(Curso_ID_TEXT.Text);
            var esnumero = int.TryParse(dniAlumno, out int n);

            if (nombre != " " && apellido_paterno != " " && apellido_materno != "" && dniAlumno != " " && Curso_ID_TEXT.Text !=" "&& esnumero && dniAlumno.Length == 8)
            {
              
                        E_Alumno alumno = new E_Alumno();
                        alumno.Alumn_nombre = nombre;
                        alumno.Alumn_ApellidoMaterno = apellido_materno;
                        alumno.Alumn_ApellidoPaterno = apellido_paterno;
                        alumno.Alumn_Direccion = dirreccion;
                        alumno.Alumn_Fechnaci = fecha_nacimiento;
                        alumno.Alumn_dni = dniAlumno;
                        alumno.Alum_NivelEducativo = nivel_educativo;
                        alumno.Alum_Correo = correo;
                        alumno.Alumn_Pension = pension;
                        alumno.Alum_Telefono = telefono;
                        alumno.Alumn_ApoderadoNombre = nombre_apoderado;
                        alumno.Alumn_ApoderadoApellido = apellido_paterno_apoderado;
                        alumno.Alumn_ApoderadoMaterno = apellido_materno_apoderado;
                        alumno.Alumn_Estado = estado;
                        alumno.Alumn_fechInscripcion = DateTime.Parse(Fecha_inscripcion.Text);
                        if(CL_Curso.Instancia.Verificar_curso_ID(Curso_id))
                            if (L_Alumno.Instancia.crear_alumno(alumno))
                                if(CL_Curso.Instancia.Enalazar_Curso_Alumno(dniAlumno, Curso_id))
                                    MessageBox.Show("Creado con exito ");
                                else
                                    MessageBox.Show("ERROR EN LA CREACION", "ERROR");
                            else
                                MessageBox.Show("ERROR EN LA CREACION", "ERROR");
                        else
                            MessageBox.Show("ERROR EN LA CREACION", "ERROR");
                    
            
            }
            else
                MessageBox.Show("FALTAN DATOS", "ERROR");
            reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Listar_Curso_Estado listar = new Listar_Curso_Estado();
            listar.Show();
        }
    }
}
