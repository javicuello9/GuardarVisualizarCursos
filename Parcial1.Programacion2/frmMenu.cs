using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial1.Programacion2
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos... !!");
            Curso oCurso = new Curso();


        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIngresar ofrmIngresar = new frmIngresar();
            ofrmIngresar.MdiParent = this;
            ofrmIngresar.Show();

        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmListar ofrmListar = new frmListar();
            ofrmListar.MdiParent = this;
            ofrmListar.Show();
        }

        private void estadisticaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEstadistica ofrmEstadistica = new frmEstadistica();
            ofrmEstadistica.MdiParent = this;
            ofrmEstadistica.Show();

        }
    }
}
