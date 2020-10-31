using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Programacion2
{
    class Curso
    {
        public Int32 Cod_Curso { get; set; }
        public String Descripcion { get; set; }
        public Int32 Cant_Horas { get; set; }
        public String Tipo_Curso { get; set; }
        public DateTime Fecha { get; set; }
        public Int32 Estado { get; set; }
        public String Categoria { get; set; }
        public Int32 cantidad { get; set; }

        public Curso ()
        {
            Fecha = DateTime.Now;
        }


    }
}
