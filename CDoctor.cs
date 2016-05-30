using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaDental
{
    public class CDoctor
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public CDoctor(string _nombre, string _apellido)
        {
            this.Nombre = _nombre;
            this.Apellido = _apellido;
        }
    }
}
