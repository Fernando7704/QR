using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class EmpresaPuesto
    {
        public int IdEmpresaPuesto { get; set; }
        public ML.Empresa empresa { get; set; }
        public ML.Horario horario { get; set; }
        public ML.Puesto puesto { get; set; }
        public int Estatus { get; set; }
    }
}
