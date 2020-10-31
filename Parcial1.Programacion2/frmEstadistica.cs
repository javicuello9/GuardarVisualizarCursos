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
    public partial class frmEstadistica : Form
    {
        public frmEstadistica()
        {
            InitializeComponent();
        }

        private void frmEstadistica_Load(object sender, EventArgs e)
        {
            Int32 ContadorTotalCursos = 0;
            Int32 ContActivos = 0;
            Int32 ContInactivos = 0;
            Int32 ContInicial = 0;
            Int32 ContMedio = 0;
            Int32 ContAvanzado = 0;
            Int32 ContPresencial = 0;
            Int32 ContDistancia = 0;
            DateTime CursoAntiguo = Convert.ToDateTime("01/12/2999");
            String NombreCursoAntiguo = null;
            Int32 CursoMayorDuracion = 0;
            string NombreMayorDuracion = null;


            foreach (Curso obj in Data.oListCurso) 

            {
                ContadorTotalCursos = ContadorTotalCursos + obj.cantidad;

                if (obj.Estado == 0)

                    ContInactivos = ContInactivos + obj.cantidad;
                    
                
                else if (obj.Estado == 1)
                   
                {
                    if (obj.Categoria == "Inicial")
                    {
                        ContInicial = ContInicial + 1;
                        if (obj.Tipo_Curso == "Presencial")

                            ContPresencial = ContPresencial + 1;
                        else
                            ContDistancia = ContDistancia + 1;
                    }
                    else if (obj.Categoria == "Medio")
                    {
                        ContMedio = ContMedio + 1;
                        if (obj.Tipo_Curso == "Presencial")
                            ContPresencial = ContPresencial + 1;
                        else
                            ContDistancia = ContDistancia + 1;
                    }
                    else if (obj.Categoria == "Avanzado")
                    {
                        ContAvanzado = ContAvanzado + 1;
                        if (obj.Tipo_Curso == "Presencial")
                            ContPresencial = ContPresencial + 1;
                        else
                            ContDistancia = ContDistancia + 1;
                    }
                    ContActivos = ContActivos + obj.cantidad;
                }
               if(CursoMayorDuracion<obj.Cant_Horas)
                {
                    CursoMayorDuracion = obj.Cant_Horas;
                    NombreMayorDuracion = obj.Descripcion;

                }


                if (CursoAntiguo>obj.Fecha)
                {
                    CursoAntiguo = obj.Fecha;
                    NombreCursoAntiguo = obj.Descripcion;
               
                }

            }

            lblCantidadCurso.Text = ContadorTotalCursos.ToString();
            lblCursoActivo.Text = ContActivos.ToString();
            lblCursoNoActivo.Text = ContInactivos.ToString();
            lblCursoInicial.Text = ContInicial.ToString();
            lblCursoMedio.Text = ContMedio.ToString();
            lblCursoAvanzado.Text = ContAvanzado.ToString();
            lblCursoDistancia.Text = ContDistancia.ToString();
            lblCursoPresencial.Text = ContPresencial.ToString();
            lblCursoAntiguo.Text = NombreCursoAntiguo;
            lblCursoDuracion.Text = NombreCursoAntiguo;


        }

        private void lblCuesoActivo_Click(object sender, EventArgs e)
        {

        }

        private void lblCursoAntiguo_Click(object sender, EventArgs e)
        {

        }
    }
}
