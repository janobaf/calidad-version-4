using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.InterfacesGraficas;
namespace CapaPresentacion.Calificaciones
{
    public partial class M_Calificaciones : Form
    {
        public M_Calificaciones()
        {
            InitializeComponent();
        }

        private void Atrasbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();
        }

        private void Registrarbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_Calificaciones registro = new Registro_Calificaciones();
            registro.Show();
        }

        private void Modificarbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Modificar_Calificaciones mc = new Modificar_Calificaciones();
            mc.Show();
        }

        private void Listarbutton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Listar_Calificaciones lc = new Listar_Calificaciones();
            lc.Show();
        }
    }
}
