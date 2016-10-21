using Entidades;
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
    public partial class RegistroUsuario : Form
    {
        public RegistroUsuario()
        {
            InitializeComponent();
        }
        private void LlenarClase(Usuarios u)
        {
            u.Nombre = NombretextBox.Text;
            u.Contrasena = ContrasenatextBox.Text;
            
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Usuarios usuario = new Usuarios();

            LlenarClase(usuario);
            UsuariosBll.Guardar(usuario);

            MessageBox.Show("Exito al Guardar!!!");

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            UsuariosBll.Eliminar(String(IdtextBox.Text));
            MessageBox.Show("Usuario Eliminado!!!");
        }

        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            LlenarUsuario(UsuariosBll.Buscar(String(IdtextBox.Text)));
        }
        private void LlenarUsuario(Usuarios usuario)
        {
            IdtextBox.Text = usuario.UsuarioId.ToString();
            NombretextBox.Text = usuario.Nombre.ToString();
            ContrasenatextBox.Text = usuario.Contrasena.ToString();

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RegistroUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
