using BLL;
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
    public partial class FrmConsultaPersonas : Form
    {
        private PersonaService personaService;
        public FrmConsultaPersonas()
        {
            InitializeComponent();
            personaService = new PersonaService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals("Todos"))
            {
                var response = personaService.Consultar();
                if (!response.Error)
                {
                    DtgPersonas.DataSource = response.Personas;
                }
                else
                {
                    MessageBox.Show(response.Mensaje, "Información al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (comboBox1.Text.Equals("Mujeres"))
            {
                var response = personaService.Consultar("F");
                if (!response.Error)
                {
                    DtgPersonas.DataSource = response.Personas;
                }
                else
                {
                    MessageBox.Show(response.Mensaje, "Información al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (comboBox1.Text.Equals("Hombres")) {

                var response = personaService.Consultar("M");
                if (!response.Error)
                {
                    DtgPersonas.DataSource = response.Personas;
                }
                else
                {
                    MessageBox.Show(response.Mensaje, "Información al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un filtro", "Información al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    


        }
    }
}
