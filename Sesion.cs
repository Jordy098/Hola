using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaDental
{
    public partial class Sesion : Form
    {
        public CUsuario Usuario;
        public Sesion()
        {
            /*string rut = "19609284-6";
            string clave = "11102013";
            string tipo="SuperAdministrador";
            CUsuario.Crear(rut,clave,tipo);*/
            //BD.SaveChanges();
            InitializeComponent();
        }
        public void Limpiar()
        {
            txtUsuario.Text="";
            txtClave.Text = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
                var BD = new clinica_dentalEntities();
                var usuarios = BD.Usuario.ToList();
                bool a = false;
                bool admiS = false;
                bool Admi = false;
                bool invitado = false;
                // Falta ingresar datos a la Base de Datos
                for (int i = 0; i < usuarios.Count; i++)
                {
                    
                    if (usuarios[i].Rut.Equals(txtUsuario.Text) && usuarios[i].Clave.Equals(txtClave.Text))
                    {
                        a = true;
                        if(usuarios[i].Tipo.Equals("SuperAdministrador"))
                        {
                            admiS = true;
                        }
                        else if (usuarios[i].Tipo.Equals("Administrador"))
                        {
                            //otro bool que permita ir a otra interfaz
                            Admi = true;
                        }
                        else if (usuarios[i].Tipo.Equals("invitado"))
                        {
                            //otro bool que permita ir a otra interfaz
                            invitado = true;
                        }
                    }
                    
                }
                if (a == true)
                {
                    if (admiS == true)
                    {
                        SuperAdministrador form = new SuperAdministrador();
                        this.Hide();
                        form.ShowDialog();
                        this.Show();
                        Limpiar();
                    }
                    else if(Admi==true)
                    {
                        MessageBox.Show("Administrador");
                    }
                    else if(invitado==true)
                    {
                        MessageBox.Show("Invitado");
                    }
                    else 
                    {
                        MessageBox.Show("El Tipo de Usuario No es Valido");
                    }
                }
                else if(txtUsuario.Text.Equals("") || txtClave.Text.Equals(""))
                {
                    MessageBox.Show("Porfavor No Deje Campos Vacios");
                }
                else
                {
                    MessageBox.Show("El Rut y/o la Contraseña no es Valida");
                }
        }
    }
}
