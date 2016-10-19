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
    public partial class Form1 : Form
    {
        public Form1()
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

            MessageBox.Show("Exito al Guardar!!!")

        }
    }
}
