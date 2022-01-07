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
        //listas creadas para el almacenamiento de los datos del ingreso de medicos y pacientes
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
            //Cierra el programa y lo finaliza
            this.Hide();
            this.Close();
        }

        public void button7_Click(object sender, EventArgs e)
        {

            //Muestra el formulario de registro de pacientes
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
            //Agrega los valores a las datagriend correspondientes sea paciente o medico      
            foreach (var Persona in listaPersona)
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
            //Muestra el formulario de registro de Medicos
            this.Hide();


            FrmIngresoMedico ingresoMedico = new FrmIngresoMedico();
            ingresoMedico.ShowDialog();

            this.Close();
        }

        private void EliminarSeleccion_Click(object sender, EventArgs e)
        {                        
           
           //Remueve la seleccion de la lista seleccionada en este caso paciente        
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
            //Remueve la seleccion de la lista seleccionada en este caso medico
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {

                if (fila.Selected)
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                    
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Muestra el formulario de consulta medica y pasa los datos del paciente seleccionado
            
            this.Hide();

           
            FrmConsulta consulta = new FrmConsulta();
  
                    foreach (var Persona in listaPersona)
                    {

                        consulta.comboBox1.Items.Add(Persona.Apellido);
                        consulta.apellidoConsulta.Text = Persona.Nombre;
                        

                    }
                    

           



            consulta.ShowDialog();
            this.Close();
        }
    }
}
