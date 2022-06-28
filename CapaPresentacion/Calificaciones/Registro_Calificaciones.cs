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
using CapaLogica.Calificaciones;
using CapaEntidad.Calificaciones;
using CapaLogica;

namespace CapaPresentacion.InterfacesGraficas
{
    public partial class Registro_Calificaciones : Form
    {
        public Registro_Calificaciones()
        {
            InitializeComponent();
            panel1.Enabled = false;
        }

        private void AtrasButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            M_Calificaciones menuPrincipal = new M_Calificaciones();
            menuPrincipal.Show();
        }

        private void reiniciar()
        {
            DNI_TXT.Text = "";
            TrabajostextBox4.Text = "";
            Parcial1textBox2.Text = "";
            Parcial2textBox3.Text = "";
            ExaFinaltextBox5.Text = "";
            PromediotextBox1.Text = "";
            panel1.Enabled = false;
        }
        private void Salirbutton1_Click(object sender, EventArgs e)
        {
            string dni = DNI_TXT.Text;
            PromediotextBox1.Enabled = false;

            int trabajos_aux = int.Parse(TrabajostextBox4.Text);
            int parcial1_aux = int.Parse(Parcial1textBox2.Text);
            int parcial2_aux = int.Parse(Parcial2textBox3.Text);
            int final_aix = int.Parse(ExaFinaltextBox5.Text);
            if(final_aix < 21 && final_aix > -1 && trabajos_aux >-1 && trabajos_aux<21 && parcial1_aux<21 && parcial1_aux>-1 && parcial2_aux < 21 && parcial2_aux > -1)

            {
                float suma = (trabajos_aux + parcial1_aux + parcial2_aux + final_aix) / 4;
                int promedio = (int)(suma);
                PromediotextBox1.Text = promedio.ToString();

                E_Calificaciones aux = new E_Calificaciones();
                aux.Califi_Trabajos = int.Parse(TrabajostextBox4.Text);
                aux.Califi_Parcial1 = int.Parse(Parcial1textBox2.Text);
                aux.Califi_Parcial2 = int.Parse(Parcial2textBox3.Text);
                aux.Califi_Final = int.Parse(ExaFinaltextBox5.Text);
                aux.Califi_Promedio = int.Parse(PromediotextBox1.Text);
                if (CL_calificaciones.Instancia.crear_calificaciones(aux, dni))
                    MessageBox.Show("Creado correctamente");
                else
                    MessageBox.Show("No fue creado ");
            }
            else 
                    MessageBox.Show("Notas deven de ser menor de 21 y mayor o igual a 0");
            reiniciar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = DNI_TXT.Text;
            if (L_Alumno.Instancia.verificar_existencia_alumno(dni))
            {
                panel1.Enabled = true;

            }
            else
                MessageBox.Show("No existe el alumno");
        }
    }
}
