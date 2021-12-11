
namespace FrmPrincipal
{
    partial class FrmIngresoMedico
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIngresoMedico));
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EdadMedico = new System.Windows.Forms.TextBox();
            this.DniMedico = new System.Windows.Forms.TextBox();
            this.NombreMedico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ApellidoMedico = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ApellidoDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DniDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EdadDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.especialidadDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disponibilidadDoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisponibilidadMedico = new System.Windows.Forms.ComboBox();
            this.EspecialidadMedico = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox7
            // 
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox7.Location = new System.Drawing.Point(186, 85);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(219, 36);
            this.textBox7.TabIndex = 30;
            this.textBox7.Text = "Perfil Doctor";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(141, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(330, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(176, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(75, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 19);
            this.label6.TabIndex = 26;
            this.label6.Text = "Disponibilidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(93, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 25;
            this.label5.Text = "Especialidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(140, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 19);
            this.label4.TabIndex = 23;
            this.label4.Text = "Dni";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(131, 290);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(112, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombre";
            // 
            // EdadMedico
            // 
            this.EdadMedico.Location = new System.Drawing.Point(176, 289);
            this.EdadMedico.MaxLength = 3;
            this.EdadMedico.Name = "EdadMedico";
            this.EdadMedico.Size = new System.Drawing.Size(229, 23);
            this.EdadMedico.TabIndex = 19;
            // 
            // DniMedico
            // 
            this.DniMedico.Location = new System.Drawing.Point(176, 243);
            this.DniMedico.MaxLength = 8;
            this.DniMedico.Name = "DniMedico";
            this.DniMedico.Size = new System.Drawing.Size(229, 23);
            this.DniMedico.TabIndex = 18;
            // 
            // NombreMedico
            // 
            this.NombreMedico.Location = new System.Drawing.Point(176, 198);
            this.NombreMedico.MaxLength = 16;
            this.NombreMedico.Name = "NombreMedico";
            this.NombreMedico.Size = new System.Drawing.Size(229, 23);
            this.NombreMedico.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(112, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 16;
            this.label1.Text = "Apellido";
            // 
            // ApellidoMedico
            // 
            this.ApellidoMedico.Location = new System.Drawing.Point(176, 152);
            this.ApellidoMedico.MaxLength = 16;
            this.ApellidoMedico.Name = "ApellidoMedico";
            this.ApellidoMedico.Size = new System.Drawing.Size(229, 23);
            this.ApellidoMedico.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ApellidoDoctor,
            this.NombreDoctor,
            this.DniDoctor,
            this.EdadDoctor,
            this.especialidadDoctor,
            this.disponibilidadDoctor});
            this.dataGridView1.Location = new System.Drawing.Point(438, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(643, 429);
            this.dataGridView1.TabIndex = 31;
            // 
            // ApellidoDoctor
            // 
            this.ApellidoDoctor.HeaderText = "Apellido";
            this.ApellidoDoctor.Name = "ApellidoDoctor";
            // 
            // NombreDoctor
            // 
            this.NombreDoctor.HeaderText = "Nombre";
            this.NombreDoctor.Name = "NombreDoctor";
            // 
            // DniDoctor
            // 
            this.DniDoctor.HeaderText = "Dni";
            this.DniDoctor.Name = "DniDoctor";
            // 
            // EdadDoctor
            // 
            this.EdadDoctor.HeaderText = "Edad";
            this.EdadDoctor.Name = "EdadDoctor";
            // 
            // especialidadDoctor
            // 
            this.especialidadDoctor.HeaderText = "Especialidad";
            this.especialidadDoctor.Name = "especialidadDoctor";
            // 
            // disponibilidadDoctor
            // 
            this.disponibilidadDoctor.HeaderText = "Disponibilidad";
            this.disponibilidadDoctor.Name = "disponibilidadDoctor";
            // 
            // DisponibilidadMedico
            // 
            this.DisponibilidadMedico.FormattingEnabled = true;
            this.DisponibilidadMedico.Items.AddRange(new object[] {
            "Disponible",
            "Ocupado"});
            this.DisponibilidadMedico.Location = new System.Drawing.Point(177, 372);
            this.DisponibilidadMedico.Name = "DisponibilidadMedico";
            this.DisponibilidadMedico.Size = new System.Drawing.Size(228, 23);
            this.DisponibilidadMedico.TabIndex = 32;
            // 
            // EspecialidadMedico
            // 
            this.EspecialidadMedico.FormattingEnabled = true;
            this.EspecialidadMedico.Items.AddRange(new object[] {
            "Medicina Familiar",
            "Medicina Interna",
            "Pediatra",
            "Cirugia",
            "Psiquiatra",
            "Cardiologia",
            "Dermatologia",
            "Endocrinologia",
            "Infectologia",
            "Nefrologia"});
            this.EspecialidadMedico.Location = new System.Drawing.Point(177, 329);
            this.EspecialidadMedico.Name = "EspecialidadMedico";
            this.EspecialidadMedico.Size = new System.Drawing.Size(228, 23);
            this.EspecialidadMedico.TabIndex = 33;
            // 
            // FrmIngresoMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 474);
            this.Controls.Add(this.EspecialidadMedico);
            this.Controls.Add(this.DisponibilidadMedico);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EdadMedico);
            this.Controls.Add(this.DniMedico);
            this.Controls.Add(this.NombreMedico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ApellidoMedico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmIngresoMedico";
            this.Text = "FrmIngresoMedico";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EdadMedico;
        private System.Windows.Forms.TextBox DniMedico;
        private System.Windows.Forms.TextBox NombreMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ApellidoMedico;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn DniDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn EdadDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn especialidadDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn disponibilidadDoctor;
        private System.Windows.Forms.ComboBox DisponibilidadMedico;
        private System.Windows.Forms.ComboBox EspecialidadMedico;
    }
}