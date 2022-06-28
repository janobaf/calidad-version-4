namespace CapaPresentacion.Curso
{
    partial class M_Curso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_Curso));
            this.Titulolabel6 = new System.Windows.Forms.Label();
            this.Listarbutton1 = new System.Windows.Forms.Button();
            this.Registrobutton1 = new System.Windows.Forms.Button();
            this.Regresarbutton1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Titulolabel6
            // 
            this.Titulolabel6.AutoSize = true;
            this.Titulolabel6.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulolabel6.Location = new System.Drawing.Point(317, 20);
            this.Titulolabel6.Name = "Titulolabel6";
            this.Titulolabel6.Size = new System.Drawing.Size(153, 32);
            this.Titulolabel6.TabIndex = 61;
            this.Titulolabel6.Text = "Menu Curso";
            // 
            // Listarbutton1
            // 
            this.Listarbutton1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Listarbutton1.Location = new System.Drawing.Point(242, 105);
            this.Listarbutton1.Name = "Listarbutton1";
            this.Listarbutton1.Size = new System.Drawing.Size(129, 47);
            this.Listarbutton1.TabIndex = 62;
            this.Listarbutton1.Text = "Listar Curso";
            this.Listarbutton1.UseVisualStyleBackColor = true;
            this.Listarbutton1.Click += new System.EventHandler(this.Listarbutton1_Click);
            // 
            // Registrobutton1
            // 
            this.Registrobutton1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrobutton1.Location = new System.Drawing.Point(417, 105);
            this.Registrobutton1.Name = "Registrobutton1";
            this.Registrobutton1.Size = new System.Drawing.Size(129, 47);
            this.Registrobutton1.TabIndex = 63;
            this.Registrobutton1.Text = "Registrar Curso";
            this.Registrobutton1.UseVisualStyleBackColor = true;
            this.Registrobutton1.Click += new System.EventHandler(this.Registrobutton1_Click);
            // 
            // Regresarbutton1
            // 
            this.Regresarbutton1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresarbutton1.Location = new System.Drawing.Point(323, 190);
            this.Regresarbutton1.Name = "Regresarbutton1";
            this.Regresarbutton1.Size = new System.Drawing.Size(129, 47);
            this.Regresarbutton1.TabIndex = 64;
            this.Regresarbutton1.Text = "Regresar";
            this.Regresarbutton1.UseVisualStyleBackColor = true;
            this.Regresarbutton1.Click += new System.EventHandler(this.Regresarbutton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // M_Curso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 264);
            this.Controls.Add(this.Regresarbutton1);
            this.Controls.Add(this.Registrobutton1);
            this.Controls.Add(this.Listarbutton1);
            this.Controls.Add(this.Titulolabel6);
            this.Controls.Add(this.pictureBox1);
            this.Name = "M_Curso";
            this.Text = "M_Calificaciones";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titulolabel6;
        private System.Windows.Forms.Button Listarbutton1;
        private System.Windows.Forms.Button Registrobutton1;
        private System.Windows.Forms.Button Regresarbutton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}