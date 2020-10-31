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
    public partial class frmListar : Form
    {
        public frmListar()
        {
            InitializeComponent();
        }

        private void frmListar_Load(object sender, EventArgs e)
        {
            dgvAltas.DataSource = null;
            dgvAltas.DataSource = Data.oListCurso;
        }
    }
}
