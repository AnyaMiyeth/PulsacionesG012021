using BLL;
using Entity;
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
    public partial class FrmRegistroPersona : Form
    {
        private PersonaService personaService;
        public FrmRegistroPersona()
        {
            InitializeComponent();
            personaService = new PersonaService();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            var persona = new Persona()
            {
                Identificacion = TxtIdentificacion.Text,
                Nombre = TxtNombre.Text,
                Edad = int.Parse(TxtEdad.Text),
                Sexo = CmbSexo.Text
            };

            persona.CalcularPulsacion();
            TxtPulsacion.Text = persona.Pulsacion.ToString();

            var mensaje = personaService.Guardar(persona);
            MessageBox.Show(mensaje, "Información al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Guardar();
        }
    }
}
