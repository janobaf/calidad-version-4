namespace CapaPresentacion.becas
{
    partial class Crear_beca
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
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dni_text = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Promedio_txt = new System.Windows.Forms.TextBox();
            this.Apellido_paterno_txt = new System.Windows.Forms.TextBox();
            this.Apellido_materno_txt = new System.Windows.Forms.TextBox();
            this.Nombre_txt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.iconButton1.Location = new System.Drawing.Point(368, 16);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconButton1.Size = new System.Drawing.Size(122, 44);
            this.iconButton1.TabIndex = 0;
            this.iconButton1.Text = "Buscar";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DNI";
            // 
            // dni_text
            // 
            this.dni_text.Location = new System.Drawing.Point(130, 29);
            this.dni_text.Name = "dni_text";
            this.dni_text.Size = new System.Drawing.Size(202, 20);
            this.dni_text.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Promedio_txt);
            this.panel1.Controls.Add(this.iconButton2);
            this.panel1.Controls.Add(this.Apellido_paterno_txt);
            this.panel1.Controls.Add(this.Apellido_materno_txt);
            this.panel1.Controls.Add(this.Nombre_txt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(32, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(442, 210);
            this.panel1.TabIndex = 3;
            // 
            // Promedio_txt
            // 
            this.Promedio_txt.Location = new System.Drawing.Point(170, 119);
            this.Promedio_txt.Name = "Promedio_txt";
            this.Promedio_txt.Size = new System.Drawing.Size(249, 20);
            this.Promedio_txt.TabIndex = 7;
            // 
            // Apellido_paterno_txt
            // 
            this.Apellido_paterno_txt.Location = new System.Drawing.Point(170, 84);
            this.Apellido_paterno_txt.Name = "Apellido_paterno_txt";
            this.Apellido_paterno_txt.Size = new System.Drawing.Size(249, 20);
            this.Apellido_paterno_txt.TabIndex = 6;
            // 
            // Apellido_materno_txt
            // 
            this.Apellido_materno_txt.Location = new System.Drawing.Point(170, 52);
            this.Apellido_materno_txt.Name = "Apellido_materno_txt";
            this.Apellido_materno_txt.Size = new System.Drawing.Size(249, 20);
            this.Apellido_materno_txt.TabIndex = 5;
            // 
            // Nombre_txt
            // 
            this.Nombre_txt.Location = new System.Drawing.Point(170, 21);
            this.Nombre_txt.Name = "Nombre_txt";
            this.Nombre_txt.Size = new System.Drawing.Size(249, 20);
            this.Nombre_txt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Promedio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Location = new System.Drawing.Point(23, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Apellido paterno";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre ";
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(141, 155);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(143, 35);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.Text = "Aceptar";
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(158, 282);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(114, 44);
            this.iconButton3.TabIndex = 5;
            this.iconButton3.Text = "Salir";
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // Crear_beca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 334);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dni_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton1);
            this.Name = "Crear_beca";
            this.Text = "Crear_beca";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dni_text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Promedio_txt;
        private System.Windows.Forms.TextBox Apellido_paterno_txt;
        private System.Windows.Forms.TextBox Apellido_materno_txt;
        private System.Windows.Forms.TextBox Nombre_txt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}