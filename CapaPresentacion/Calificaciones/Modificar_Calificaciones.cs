using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.Calificaciones;
using CapaEntidad.Calificaciones;
using CapaLogica.Calificaciones;
using CapaLogica.Becas;
using CapaLogica;
namespace CapaPresentacion.Calificaciones
{
    public partial class Modificar_Calificaciones : Form
    {
        public Modificar_Calificaciones()
        {
            InitializeComponent();
            panel1.Enabled = false;
        }

        private void Salirbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            M_Calificaciones calificacion = new M_Calificaciones();
            calificacion.Show();
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            string dni = DNI_TXT.Text;
            if (L_Alumno.Instancia.verificar_existencia_alumno(dni))
            {
                panel1.Enabled = true;
                E_Calificaciones califi = CL_calificaciones.Instancia.mostrar_calificaciones_dni(dni);
                if (califi != null)
                {
                    Parcial1textBox2.Text = califi.Califi_Parcial1.ToString();
                    Parcial2textBox3.Text = califi.Califi_Parcial2.ToString();
                }

            }
            else
                MessageBox.Show("No existe el alumno");
        }
        private void Reset()
        {
            panel1.Enabled = false;
            DNI_TXT.Text = "";
            Parcial1textBox2.Text = "";
            Parcial2textBox3.Text = "";
            TrabajostextBox4.Text = "";
            ExaFinaltextBox5.Text = "";
            PromediotextBox1.Text = "";

        }
        private void Continuarrbutton1_Click(object sender, EventArgs e)
        {
            string dni = DNI_TXT.Text;
            E_Calificaciones califi = new E_Calificaciones();
            califi.Califi_Parcial1 = int.Parse(Parcial1textBox2.Text);
            califi.Califi_Parcial2 = int.Parse(Parcial2textBox3.Text);

            if ((califi.Califi_Parcial1 < 21 && califi.Califi_Parcial1 > -1 && califi.Califi_Parcial2 < 21 && califi.Califi_Parcial2 > -1))
            {
                if (CL_calificaciones.Instancia.modificar_calificacion_parcial1(califi, dni) && CL_calificaciones.Instancia.modificar_calificacion_parcial12(califi, dni))
                {
                    E_Calificaciones auxiliar = CL_calificaciones.Instancia.mostrar_calificaciones_dni(dni);
                    auxiliar.Califi_Parcial1 = int.Parse(Parcial1textBox2.Text);
                    auxiliar.Califi_Parcial2 = int.Parse(Parcial2textBox3.Text);
                    int promedio = (auxiliar.Califi_Parcial1 + auxiliar.Califi_Parcial2 + auxiliar.Califi_Final + auxiliar.Califi_Promedio) / 4;
                    if (auxiliar.Califi_Promedio >= 16 && CL_BecaExcelencia.Instancia.verificar_Alumno_Beca(dni) && promedio < 16 && CL_calificaciones.Instancia.modificar_Beca(dni))
                    {
       
                                    MessageBox.Show("Modificacion Alumno completada con beca borrada ");
              
                    }

                    auxiliar.Califi_Promedio = promedio;

                    if (CL_calificaciones.Instancia.modificar_calificacion_Promedio(auxiliar, dni))
                        MessageBox.Show("Modificacion Alumno completada promedio " + promedio.ToString());

                }
                else
                    MessageBox.Show("Error modificacion Alumno");

            }
            else
                MessageBox.Show("Error modificacion Alumno");

            Reset();


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
