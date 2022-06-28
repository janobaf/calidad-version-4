using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaPresentacion.becas;
using CapaPresentacion;
namespace CapaPresentacion.becas
{
    public partial class Becas_principal : Form
    {
        public Becas_principal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Crear_beca crear = new Crear_beca();
            crear.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Becas_Por_Exelencia listar = new Becas_Por_Exelencia();
            listar.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipal principal = new MenuPrincipal();
            principal.Show();
        }
    }
}
