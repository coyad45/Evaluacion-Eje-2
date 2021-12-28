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
    public partial class FrmProgram : Form
    {
        public static List<Persona> listaPersona = new List<Persona>();

        public static List<Medico> listaMedico = new List<Medico>()

;       public FrmProgram()
        {
            InitializeComponent();
        }

        public void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        public void button2_Click(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {

        }

        public void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        public void button7_Click(object sender, EventArgs e)
        {
            this.Hide();


            FrmIngresoPaciente ingresoPaciente = new FrmIngresoPaciente();
            ingresoPaciente.ShowDialog();
            this.Close();
            

        }

        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void FrmProgram_Load(object sender, EventArgs e)
        {
            foreach(var Persona in listaPersona)
            {
                dtgvPaciente.Rows.Add(Persona.Apellido, Persona.Nombre, Persona.Dni , Persona.Edad, Persona.ObraSocial, Persona.NumeroDePaciente);
            }
            foreach (var Medico in listaMedico)
            {
                dataGridView1.Rows.Add(Medico.Apellido, Medico.Nombre, Medico.Dni, Medico.Edad, Medico.Especialidad, Medico.Disponibilidad);
            }
        }

        public void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void dtgvPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow fila in dtgvPaciente.Rows)
            {

                if (fila.Selected)
                {

                    EliminarSeleccion.Enabled = true;
                }

            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();


            FrmIngresoMedico ingresoMedico = new FrmIngresoMedico();
            ingresoMedico.ShowDialog();

            this.Close();
        }

        private void EliminarSeleccion_Click(object sender, EventArgs e)
        {                             
           foreach (DataGridViewRow fila in dtgvPaciente.Rows)
            {
                
                if (fila.Selected)
                {
                    
                    dtgvPaciente.Rows.Remove(dtgvPaciente.CurrentRow);
                }

           }
           
            


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
             foreach (DataGridViewRow fila in dataGridView1.Rows)
            {

                if (fila.Selected)
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    
                }
            }
        }
    }
}
