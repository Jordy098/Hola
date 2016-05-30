using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaDental
{
    public class CPaciente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Rut { get; set; }
        public string Sexo { get; set; }
        public string Mail { get; set; }
        public string Telefono { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public CDoctor NombreD { get; set; }
        public string Observacion { get; set; }
        public CPaciente(string _nombre, string _apellido, string _rut, string _sexo, string _mail, string _telefono, string _ciudad, string _direccion, DateTime _fecha_ingreso, CDoctor _nombred, string _observacion)
        {
            this.Nombre = _nombre;
            this.Apellido = _apellido;
            this.Rut = _rut;
            this.Sexo = _sexo;
            this.Mail = _mail;
            this.Telefono=_telefono;
            this.Ciudad = _ciudad;
            this.Direccion = _direccion;
            this.Fecha_Ingreso = _fecha_ingreso;
            this.NombreD = _nombred;
            this.Observacion = _observacion;
        }
    }
}
