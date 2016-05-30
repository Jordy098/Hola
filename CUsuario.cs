using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaDental
{
    public class CUsuario
    {
        public string Rut { get; set; }
        public string Clave { get; set; }
        public string Tipo { get; set; }

        public CUsuario(string _rut, string _clave , string _tipo)
        {
            this.Rut = _rut;
            this.Clave = _clave;
            this.Tipo = _tipo;
        }
        public static List<Usuario> buscarUsuario(string _rut,string _claves)
        {
            var BD =new clinica_dentalEntities();
            var Usuarios = BD.Usuario.ToList();
            return Usuarios;
        }
        public static void Crear(string _rut, string _clave, string _tipo)
        {
            try
            {
                var BD = new clinica_dentalEntities();
                var Usuarios = BD.Usuario.ToList();
                var nuevo = new Usuario();
                nuevo.Rut = _rut;
                nuevo.Clave = _clave;
                nuevo.Tipo = _tipo;
                BD.Usuario.Add(nuevo);
                BD.SaveChanges();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
