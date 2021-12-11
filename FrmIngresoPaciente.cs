using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaDeClasesHospital;

namespace FrmPrincipal
{
    public partial class FrmIngresoPaciente : Form
    {
        public FrmIngresoPaciente()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();

            FrmProgram form2 = new FrmProgram();
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                Persona per = new Persona();
                if (fila.Selected)
                {
                    per.Nombre = fila.Cells[0].Value.ToString();
                    per.Apellido = fila.Cells[1].Value.ToString();
                    per.Dni = fila.Cells[2].Value.ToString();
                    per.Edad = fila.Cells[3].Value.ToString();
                    per.ObraSocial = fila.Cells[4].Value.ToString();
                    per.NumeroDePaciente = fila.Cells[5].Value.ToString();

                    FrmProgram.listaPersona.Add(per);
                }
            }
            
            form2.ShowDialog();


            this.Close();
            form2.Visible = true;
        }

        public void button1_Click(object sender, EventArgs e)
        {
           
            
                int n = dataGridView1.Rows.Add();

                dataGridView1.Rows[n].Cells[0].Value = NombrePerfil.Text;
                dataGridView1.Rows[n].Cells[1].Value = ApellidoPerfil.Text;
                dataGridView1.Rows[n].Cells[2].Value = DniPerfil.Text;
                dataGridView1.Rows[n].Cells[3].Value = EdadPerfil.Text;
                dataGridView1.Rows[n].Cells[4].Value = ObraSocialPaciente.SelectedItem;
                dataGridView1.Rows[n].Cells[5].Value = NumeroPaciente.Text;

               

            NombrePerfil.Text = "";
                ApellidoPerfil.Text = ""; 
                DniPerfil.Text = ""; 
                EdadPerfil.Text = ""; 
                ObraSocialPaciente.Text = ""; 
                NumeroPaciente.Text = "";



        }

        private void ApellidoPerfil_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }
    }
}
