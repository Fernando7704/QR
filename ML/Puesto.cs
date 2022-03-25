using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Puesto
    {
        public int IdPuesto { get; set; }
        public string Descripcion { get; set; }
        public int RetrasosPermitidos { get; set; }
        public int FaltasPermitidas { get; set; }
        public int Estatus { get; set; }
    }
}
