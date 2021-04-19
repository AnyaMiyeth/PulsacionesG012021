using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulsacionGUI
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

        }

        private void FrmPrincipal_DoubleClick(object sender, EventArgs e)
        {

        }


        private void FrmPrincipal_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmRegistroPersona().Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmConsultaPersonas().Show();
        }
    }
}
