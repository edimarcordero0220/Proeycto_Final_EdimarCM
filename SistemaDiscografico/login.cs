using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace SistemaDiscografico
{
    public partial class login : Form
    {
        PrincipalPage p = new PrincipalPage();
        private object then;
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
        

        private void VerContrasenacheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MostrarcheckBox.Checked == true)
            {
                if (ContrasenatextBox.PasswordChar == '*')
                {
                    ContrasenatextBox.PasswordChar = '\0';
                }
            }
            else
            {
                ContrasenatextBox.PasswordChar = '*';
            }
        }

        private void Iniciarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarSesion() == DialogResult.OK)
            {
                this.Visible = false;
                p.Show();
            }
        }

        private void Registrartebutton_Click(object sender, EventArgs e)
        {
            
            RegistroUsuario ru = new RegistroUsuario();
            ru.Show();
        }

        public bool ValidarUsuario()
        {
            if (UsuariosBll.GetListarNombre(UsuariotextBox.Text).Count() == 0)
            {
                MessageBox.Show("Usuario incorrecto o no registrado");
                return false;
            }
            return true;
        }

        public bool ValidarContrasena()
        {
            if (UsuariosBll.GetContrasena(ContrasenatextBox.Text).Count() == 0)
            {
                MessageBox.Show("Contraseña incorrecta");
                return false;
            }
            return true;
        }

        public bool ValidTextB()
        {
            if (string.IsNullOrEmpty(UsuariotextBox.Text) && string.IsNullOrEmpty(ContrasenatextBox.Text))
            {
                UsuarioerrorProvider.SetError(UsuariotextBox, "Ingrese el usuario");
                contrasenaerrorProvider.SetError(ContrasenatextBox, "Ingrese contraseña");
                MessageBox.Show("Llenar todos los campos");
            }
            if (string.IsNullOrEmpty(UsuariotextBox.Text))
            {
                UsuarioerrorProvider.SetError(UsuariotextBox, "Ingrese el usuario por favor");
                return false;
            }
            if (string.IsNullOrEmpty(ContrasenatextBox.Text))
            {
                UsuarioerrorProvider.Clear();
                contrasenaerrorProvider.SetError(ContrasenatextBox, "Ingrese contraseña por favor");
                return false;
            }
            return true;
        }

        public DialogResult ValidarSesion()
        {
            if (ValidTextB() == true && ValidarUsuario() == true && ValidarContrasena() == true)
            {
                return DialogResult.OK;
            }
            return DialogResult.Cancel;
        }
        

        private void MostrarContrasenacheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (MostrarContrasenacheckBox.Checked == true)
            {
                if (ContrasenatextBox.PasswordChar == '*')
                {
                    ContrasenatextBox.PasswordChar = '\0';
                }
            }
            else
            {
                ContrasenatextBox.PasswordChar = '*';
            }
        }

        

    }

    class ContrasenaerrorProvider
    {
    }
}
