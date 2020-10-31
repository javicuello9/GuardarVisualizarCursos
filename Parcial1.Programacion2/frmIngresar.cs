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
    public partial class frmIngresar : Form
    {
        public frmIngresar()
        {
            InitializeComponent();
        }

        List<Curso> oListCurso = new List<Curso>();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(cboCantidadHoras.Text) > 24) {  
            Curso oCurso = new Curso();
            oCurso.Cod_Curso = Int32.Parse(txtCodigoCurso.Text);
            oCurso.Descripcion = txtDescripcion.Text;
            oCurso.Cant_Horas =Int32.Parse( cboCantidadHoras.SelectedItem.ToString());
            oCurso.Tipo_Curso = cboTipoCurso.SelectedItem.ToString();
            oCurso.Categoria = cboCategoria.SelectedItem.ToString();
            oCurso.Fecha = dtpFecha.Value;
            oCurso.Estado = Int32.Parse(cboEstado.SelectedItem.ToString());
            oCurso.cantidad = +1;

            Data.oListCurso.Add(oCurso);

            LimpiarControles();
            }
            else
            {
                MessageBox.Show("Ingrese Cantidad de Horas mayor a 24");
             }

        }
        private void LimpiarControles()
        {
            txtCodigoCurso.Clear();
            txtDescripcion.Clear();
            cboCantidadHoras.SelectedIndex = 0;
            cboCategoria.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
            cboTipoCurso.SelectedIndex = 0;
            dtpFecha.Value = DateTime.Now;
         
                }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmIngresar_Load(object sender, EventArgs e)
        {
            LimpiarControles();
         

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void txtCodigoCurso_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboCantidadHoras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
