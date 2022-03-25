using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string App { get; set; }
        public string Apm { get; set; }
        public string Correo { get; set; }
        public string Pass { get; set; }
        public string Imagen { get; set; }
        public ML.Empresa empresa { get; set; }
        public ML.Puesto puesto { get; set; }
        public int Retardos { get; set; }
        public int Faltas { get; set; }
        public int Justificadas { get; set; }
        public string Qr { get; set; }
        public int Estatus { get; set; }
    }
}
