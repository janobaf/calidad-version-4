namespace CapaPresentacion
{
    partial class Becas_Por_Exelencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Becas_Por_Exelencia));
            this.Buscarbutton1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DNItextBox1 = new System.Windows.Forms.TextBox();
            this.dni = new System.Windows.Forms.Label();
            this.Titulolabel6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AtrasButton1 = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoPa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ApellidoMaterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscarbutton1
            // 
            this.Buscarbutton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Buscarbutton1.Location = new System.Drawing.Point(626, 80);
            this.Buscarbutton1.Name = "Buscarbutton1";
            this.Buscarbutton1.Size = new System.Drawing.Size(95, 34);
            this.Buscarbutton1.TabIndex = 43;
            this.Buscarbutton1.Text = "Buscar";
            this.Buscarbutton1.UseVisualStyleBackColor = true;
            this.Buscarbutton1.Click += new System.EventHandler(this.Buscarbutton1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.ApellidoPa,
            this.ApellidoMaterno});
            this.dataGridView1.Location = new System.Drawing.Point(192, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(342, 158);
            this.dataGridView1.TabIndex = 39;
            // 
            // DNItextBox1
            // 
            this.DNItextBox1.Location = new System.Drawing.Point(192, 87);
            this.DNItextBox1.Name = "DNItextBox1";
            this.DNItextBox1.Size = new System.Drawing.Size(397, 20);
            this.DNItextBox1.TabIndex = 38;
            // 
            // dni
            // 
            this.dni.AutoSize = true;
            this.dni.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dni.Location = new System.Drawing.Point(74, 87);
            this.dni.Name = "dni";
            this.dni.Size = new System.Drawing.Size(99, 21);
            this.dni.TabIndex = 37;
            this.dni.Text = "DNI Alumno:";
            // 
            // Titulolabel6
            // 
            this.Titulolabel6.AutoSize = true;
            this.Titulolabel6.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulolabel6.Location = new System.Drawing.Point(267, 28);
            this.Titulolabel6.Name = "Titulolabel6";
            this.Titulolabel6.Size = new System.Drawing.Size(407, 32);
            this.Titulolabel6.TabIndex = 36;
            this.Titulolabel6.Text = "Listar Becas por Exelencia por DNI";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(744, 381);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // AtrasButton1
            // 
            this.AtrasButton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AtrasButton1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AtrasButton1.Location = new System.Drawing.Point(285, 322);
            this.AtrasButton1.Name = "AtrasButton1";
            this.AtrasButton1.Size = new System.Drawing.Size(111, 44);
            this.AtrasButton1.TabIndex = 44;
            this.AtrasButton1.Text = "Atras";
            this.AtrasButton1.UseVisualStyleBackColor = true;
            this.AtrasButton1.Click += new System.EventHandler(this.AtrasButton1_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // ApellidoPa
            // 
            this.ApellidoPa.HeaderText = "ApellidoPaterno";
            this.ApellidoPa.Name = "ApellidoPa";
            this.ApellidoPa.ReadOnly = true;
            // 
            // ApellidoMaterno
            // 
            this.ApellidoMaterno.HeaderText = "ApellidoMaterno";
            this.ApellidoMaterno.Name = "ApellidoMaterno";
            this.ApellidoMaterno.ReadOnly = true;
            // 
            // Becas_Por_Exelencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 375);
            this.Controls.Add(this.AtrasButton1);
            this.Controls.Add(this.Buscarbutton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DNItextBox1);
            this.Controls.Add(this.dni);
            this.Controls.Add(this.Titulolabel6);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Becas_Por_Exelencia";
            this.Text = "Becas_Por_Exelencia";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox DNItextBox1;
        private System.Windows.Forms.Label dni;
        private System.Windows.Forms.Label Titulolabel6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AtrasButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoPa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ApellidoMaterno;
    }
}