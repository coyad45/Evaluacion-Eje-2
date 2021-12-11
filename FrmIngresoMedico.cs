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
    public partial class FrmIngresoMedico : Form
    {
        public FrmIngresoMedico()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();


            FrmProgram form2 = new FrmProgram();
            
            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                Medico med = new Medico();
                if (fila.Selected)
                {
                    med.Nombre = fila.Cells[0].Value.ToString();
                    med.Apellido = fila.Cells[1].Value.ToString();
                    med.Dni = fila.Cells[2].Value.ToString();
                    med.Edad = fila.Cells[3].Value.ToString();
                    med.Especialidad = fila.Cells[4].Value.ToString();
                    med.Disponibilidad= fila.Cells[5].Value.ToString();

                    FrmProgram.listaMedico.Add(med);
                }
            }

            
            form2.ShowDialog();


            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = dataGridView1.Rows.Add();

            dataGridView1.Rows[n].Cells[0].Value = NombreMedico.Text;
            dataGridView1.Rows[n].Cells[1].Value = ApellidoMedico.Text;
            dataGridView1.Rows[n].Cells[2].Value = DniMedico.Text;
            dataGridView1.Rows[n].Cells[3].Value = EdadMedico.Text;
            dataGridView1.Rows[n].Cells[4].Value = EspecialidadMedico.SelectedItem;
            dataGridView1.Rows[n].Cells[5].Value = DisponibilidadMedico.SelectedItem;



            NombreMedico.Text = "";
            ApellidoMedico.Text = "";
            DniMedico.Text = "";
            EdadMedico.Text = "";
            EspecialidadMedico.Text = "";
            DisponibilidadMedico.Text = "";

        }
    }
}
