using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Bitacora
    {
        public int IdBitacora { get; set; }
        public int IdEmpresa { get; set; }
        public ML.Rango rango { get; set; }
        public DateTime Fecha { get; set; }
        public string Hora { get; set; }
        public ML.Entrada entrada { get; set; }
        public int ATiempo { get; set; }
        public int Retraso { get; set; }
        public int Estatus { get; set; }
    }
}
