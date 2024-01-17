namespace Escaner_de_Tienda
{
    partial class Registrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registrar));
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 98);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(193, 12);
            label1.Name = "label1";
            label1.Size = new Size(506, 65);
            label1.TabIndex = 1;
            label1.Text = "REGISTRAR USUARIOS";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(397, 139);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(477, 39);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(397, 223);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(477, 39);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(397, 318);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(477, 39);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(397, 411);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(477, 39);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(397, 513);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(477, 39);
            textBox5.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 139);
            label2.Name = "label2";
            label2.Size = new Size(125, 32);
            label2.TabIndex = 6;
            label2.Text = "NOMBRES";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 230);
            label3.Name = "label3";
            label3.Size = new Size(130, 32);
            label3.TabIndex = 7;
            label3.Text = "APELLIDOS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 325);
            label4.Name = "label4";
            label4.Size = new Size(262, 32);
            label4.TabIndex = 8;
            label4.Text = "CORREO ELECTRONICO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 416);
            label5.Name = "label5";
            label5.Size = new Size(164, 32);
            label5.TabIndex = 9;
            label5.Text = "CONTRASEÑA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 509);
            label6.Name = "label6";
            label6.Size = new Size(270, 32);
            label6.TabIndex = 10;
            label6.Text = "FECHA DE NACIMIENTO";
            // 
            // button1
            // 
            button1.Location = new Point(363, 606);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 11;
            button1.Text = "REGISTRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Registrar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 695);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Registrar";
            Text = "Registrar";
            Load += Registrar_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button button1;
    }
}