namespace CapaPresentacion.InterfacesGraficas
{
    partial class Listar_Curso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listar_Curso));
            this.ProfesordataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Salirbutton1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProfesordataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfesordataGridView1
            // 
            this.ProfesordataGridView1.AllowUserToAddRows = false;
            this.ProfesordataGridView1.AllowUserToDeleteRows = false;
            this.ProfesordataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProfesordataGridView1.Location = new System.Drawing.Point(76, 71);
            this.ProfesordataGridView1.Name = "ProfesordataGridView1";
            this.ProfesordataGridView1.ReadOnly = true;
            this.ProfesordataGridView1.Size = new System.Drawing.Size(495, 165);
            this.ProfesordataGridView1.TabIndex = 99;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 310);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 100;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(259, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 32);
            this.label5.TabIndex = 101;
            this.label5.Text = "Listar Cursos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // Salirbutton1
            // 
            this.Salirbutton1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salirbutton1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Salirbutton1.Location = new System.Drawing.Point(323, 260);
            this.Salirbutton1.Name = "Salirbutton1";
            this.Salirbutton1.Size = new System.Drawing.Size(95, 34);
            this.Salirbutton1.TabIndex = 119;
            this.Salirbutton1.Text = "Salir";
            this.Salirbutton1.UseVisualStyleBackColor = true;
            this.Salirbutton1.Click += new System.EventHandler(this.Salirbutton1_Click);
            // 
            // Listar_Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 311);
            this.Controls.Add(this.Salirbutton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProfesordataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Listar_Curso";
            this.Text = "Listar_Curso";
            ((System.ComponentModel.ISupportInitialize)(this.ProfesordataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProfesordataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Salirbutton1;
    }
}