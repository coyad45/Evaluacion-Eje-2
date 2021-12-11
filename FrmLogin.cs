using FrmPrincipal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvaluacionEje2
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Oliver" && textBox2.Text == "1234")
            {
                this.Hide();

                
                FrmProgram form2 = new FrmProgram();
                form2.ShowDialog();

                
                this.Close();
            }
            else
            {
                string error= "Error de dato";
                DialogResult result = MessageBox.Show($"{error}","ingresado ", MessageBoxButtons.OK , MessageBoxIcon.Exclamation);


            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
