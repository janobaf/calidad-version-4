namespace CapaPresentacion.Alumnos
{
    partial class M_alumno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M_alumno));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CrearButton1 = new FontAwesome.Sharp.IconButton();
            this.ListarButton3 = new FontAwesome.Sharp.IconButton();
            this.EditarButton2 = new FontAwesome.Sharp.IconButton();
            this.Atrasbutton1 = new System.Windows.Forms.Button();
            this.Titulolabel6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(562, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // CrearButton1
            // 
            this.CrearButton1.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CrearButton1.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.CrearButton1.IconColor = System.Drawing.Color.Black;
            this.CrearButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CrearButton1.Location = new System.Drawing.Point(28, 56);
            this.CrearButton1.Name = "CrearButton1";
            this.CrearButton1.Size = new System.Drawing.Size(166, 48);
            this.CrearButton1.TabIndex = 6;
            this.CrearButton1.Text = "CREAR INSCRIPCION";
            this.CrearButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.CrearButton1.UseVisualStyleBackColor = true;
            this.CrearButton1.Click += new System.EventHandler(this.CrearButton1_Click);
            // 
            // ListarButton3
            // 
            this.ListarButton3.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListarButton3.IconChar = FontAwesome.Sharp.IconChar.List;
            this.ListarButton3.IconColor = System.Drawing.Color.Black;
            this.ListarButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ListarButton3.Location = new System.Drawing.Point(295, 56);
            this.ListarButton3.Name = "ListarButton3";
            this.ListarButton3.Size = new System.Drawing.Size(221, 48);
            this.ListarButton3.TabIndex = 7;
            this.ListarButton3.Text = "LISTAR INSCRIPCION POR DNI ";
            this.ListarButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ListarButton3.UseVisualStyleBackColor = true;
            this.ListarButton3.Click += new System.EventHandler(this.ListarButton3_Click);
            // 
            // EditarButton2
            // 
            this.EditarButton2.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditarButton2.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.EditarButton2.IconColor = System.Drawing.Color.Black;
            this.EditarButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.EditarButton2.Location = new System.Drawing.Point(28, 156);
            this.EditarButton2.Name = "EditarButton2";
            this.EditarButton2.Size = new System.Drawing.Size(166, 48);
            this.EditarButton2.TabIndex = 8;
            this.EditarButton2.Text = "EDITAR INSCRIPCION";
            this.EditarButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.EditarButton2.UseVisualStyleBackColor = true;
            this.EditarButton2.Click += new System.EventHandler(this.EditarButton2_Click);
            // 
            // Atrasbutton1
            // 
            this.Atrasbutton1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Atrasbutton1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Atrasbutton1.Location = new System.Drawing.Point(347, 155);
            this.Atrasbutton1.Name = "Atrasbutton1";
            this.Atrasbutton1.Size = new System.Drawing.Size(131, 48);
            this.Atrasbutton1.TabIndex = 9;
            this.Atrasbutton1.Text = "Regresar";
            this.Atrasbutton1.UseVisualStyleBackColor = true;
            this.Atrasbutton1.Click += new System.EventHandler(this.Atrasbutton1_Click);
            // 
            // Titulolabel6
            // 
            this.Titulolabel6.AutoSize = true;
            this.Titulolabel6.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulolabel6.Location = new System.Drawing.Point(189, 9);
            this.Titulolabel6.Name = "Titulolabel6";
            this.Titulolabel6.Size = new System.Drawing.Size(179, 32);
            this.Titulolabel6.TabIndex = 60;
            this.Titulolabel6.Text = "Menu Alumno";
            // 
            // M_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 258);
            this.Controls.Add(this.Titulolabel6);
            this.Controls.Add(this.Atrasbutton1);
            this.Controls.Add(this.EditarButton2);
            this.Controls.Add(this.ListarButton3);
            this.Controls.Add(this.CrearButton1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "M_alumno";
            this.Text = "M_alumno";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton CrearButton1;
        private FontAwesome.Sharp.IconButton ListarButton3;
        private FontAwesome.Sharp.IconButton EditarButton2;
        private System.Windows.Forms.Button Atrasbutton1;
        private System.Windows.Forms.Label Titulolabel6;
    }
}