using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Horario
    {
        public int IdHorario { get; set; }
        public string DiaInicioFinal { get; set; }
        public string EntrataHorario { get; set; }
        public string SalidaHorario { get; set; }
        public string SalidaComida { get; set; }
        public string EntradaComida { get; set; }
        public int DiasTrabajados { get; set; }
        public int Estatus { get; set; }
    }
}
