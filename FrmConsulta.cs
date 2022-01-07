using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClasesClinica;
using static BibliotecaDeClasesClinica.Clinica;


namespace FrmPrincipal
{
    public partial class FrmConsulta : Form
    {
        public static List<Persona> listaPersona = new List<Persona>();

        public FrmConsulta()
        {
            InitializeComponent();
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void FrmConsulta_Load(object sender, EventArgs e)
        {
            
            
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var Persona in listaPersona)
            {
                
                apellidoConsulta.Text = Persona.Nombre;
                
                



            }
            
        }

        private void apellidoConsulta_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
