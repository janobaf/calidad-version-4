using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad.Alumno;
using CapaLogica.Becas;
using CapaLogica;
using CapaLogica.Calificaciones;
using CapaEntidad.Calificaciones;
using CapaPresentacion.becas;
namespace CapaPresentacion.becas
{
    public partial class Crear_beca : Form
    {
        public Crear_beca()
        {
            InitializeComponent();
            panel1.Enabled = false;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            string dni = dni_text.Text;
            if (!L_Alumno.Instancia.verificar_existencia_alumno(dni) && CL_BecaExcelencia.Instancia.verificar_Alumno_Beca(dni) )
            {
                panel1.Enabled = true;
                E_Alumno alumno = L_Alumno.Instancia.listar_alumno_dni(dni);
                Nombre_txt.Enabled = false;
                Nombre_txt.Text = alumno.Alumn_nombre;
                Apellido_materno_txt.Enabled = false;
                Apellido_materno_txt.Text = alumno.Alumn_ApellidoMaterno;
                Apellido_paterno_txt.Enabled = false;
                Apellido_paterno_txt.Text = alumno.Alumn_ApellidoPaterno;
                E_Calificaciones calificacion = CL_calificaciones.Instancia.mostrar_calificaciones_dni(dni);
                Promedio_txt.Enabled = false;
                Promedio_txt.Text = calificacion.Califi_Promedio.ToString();
            }
            else
                MessageBox.Show("El dni ya existe o el usario ya tiene beca");
        }
        private void reiniciar_texto()
        {
            panel1.Enabled = false;
            dni_text.Text = " ";
            Nombre_txt.Text = " ";
            Apellido_materno_txt.Text = " ";
            Apellido_paterno_txt.Text = " ";
            Promedio_txt.Text = " ";


        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            string dni = dni_text.Text;
            E_Alumno ea = new E_Alumno();
            ea.Alumn_dni = dni;
            if (CL_BecaExcelencia.Instancia.Beca_exelencia(ea)) MessageBox.Show("Enlazado con exito");
            else MessageBox.Show("Error menor de 16 ");
            reiniciar_texto();

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Becas_principal main = new Becas_principal();
            main.Show();
        }
    }
}
