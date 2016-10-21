using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDiscografico
{
    public partial class PrincipalPage : Form
    {
        public PrincipalPage()
        {
            InitializeComponent();
        }

        private void PrincipalPage_Load(object sender, EventArgs e)
        {

        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroUsuario ru = new RegistroUsuario();
            ru.MdiParent = this;
            ru.Show();

        }
        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //RegistrosClientes rc = new RegistrosClientes();
           // rc.MdiParent = this;
           // rc.Show();
        }
    }
}
