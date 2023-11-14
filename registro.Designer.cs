namespace login
{
    partial class registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registro));
            this.panel1 = new System.Windows.Forms.Panel();
            this.salir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.n_name = new System.Windows.Forms.TextBox();
            this.n_pass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subir = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.salir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 26);
            this.panel1.TabIndex = 0;
            // 
            // salir
            // 
            this.salir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.salir.FlatAppearance.BorderSize = 0;
            this.salir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.salir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Image = ((System.Drawing.Image)(resources.GetObject("salir.Image")));
            this.salir.Location = new System.Drawing.Point(368, 3);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(41, 23);
            this.salir.TabIndex = 1;
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuario";
            // 
            // n_name
            // 
            this.n_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.n_name.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_name.Location = new System.Drawing.Point(150, 52);
            this.n_name.Name = "n_name";
            this.n_name.Size = new System.Drawing.Size(204, 15);
            this.n_name.TabIndex = 2;
            // 
            // n_pass
            // 
            this.n_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.n_pass.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_pass.Location = new System.Drawing.Point(148, 119);
            this.n_pass.Name = "n_pass";
            this.n_pass.PasswordChar = '*';
            this.n_pass.Size = new System.Drawing.Size(204, 15);
            this.n_pass.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // subir
            // 
            this.subir.BackColor = System.Drawing.Color.Red;
            this.subir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.subir.FlatAppearance.BorderSize = 0;
            this.subir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.subir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.subir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.subir.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subir.ForeColor = System.Drawing.Color.White;
            this.subir.Location = new System.Drawing.Point(150, 185);
            this.subir.Name = "subir";
            this.subir.Size = new System.Drawing.Size(116, 35);
            this.subir.TabIndex = 5;
            this.subir.Text = "Registrarme";
            this.subir.UseVisualStyleBackColor = false;
            this.subir.Click += new System.EventHandler(this.subir_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(409, 248);
            this.shapeContainer1.TabIndex = 6;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 148;
            this.lineShape2.X2 = 353;
            this.lineShape2.Y1 = 138;
            this.lineShape2.Y2 = 138;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 151;
            this.lineShape1.X2 = 348;
            this.lineShape1.Y1 = 73;
            this.lineShape1.Y2 = 73;
            // 
            // registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(409, 248);
            this.Controls.Add(this.subir);
            this.Controls.Add(this.n_pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.n_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "registro";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox n_name;
        private System.Windows.Forms.TextBox n_pass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button subir;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Button salir;
    }
}