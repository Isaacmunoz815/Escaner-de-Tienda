namespace Escaner_de_Tienda
{
    partial class Registrar_Tienda
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            button1 = new Button();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.Location = new Point(269, 179);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(786, 39);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(266, 258);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(786, 39);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(271, 338);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(786, 39);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(273, 427);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(786, 39);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(275, 520);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(786, 39);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(274, 609);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(787, 39);
            textBox6.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CadetBlue;
            panel1.Controls.Add(label7);
            panel1.Location = new Point(-6, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1132, 120);
            panel1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(54, 179);
            label1.Name = "label1";
            label1.Size = new Size(37, 32);
            label1.TabIndex = 7;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 255);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 8;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 339);
            label3.Name = "label3";
            label3.Size = new Size(137, 32);
            label3.TabIndex = 9;
            label3.Text = "VENDEDOR";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(54, 435);
            label4.Name = "label4";
            label4.Size = new Size(128, 32);
            label4.TabIndex = 10;
            label4.Text = "TELEFONO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(63, 522);
            label5.Name = "label5";
            label5.Size = new Size(133, 32);
            label5.TabIndex = 11;
            label5.Text = "DOMICILIO";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 612);
            label6.Name = "label6";
            label6.Size = new Size(100, 32);
            label6.TabIndex = 12;
            label6.Text = "ID RUTA";
            // 
            // button1
            // 
            button1.Location = new Point(545, 713);
            button1.Name = "button1";
            button1.Size = new Size(150, 46);
            button1.TabIndex = 13;
            button1.Text = "REGISTRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Transparent;
            label7.Location = new Point(347, 25);
            label7.Name = "label7";
            label7.Size = new Size(442, 65);
            label7.TabIndex = 0;
            label7.Text = "REGISTRAR TEINDA";
            // 
            // Registrar_Tienda
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 829);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Registrar_Tienda";
            Text = "Registrar_Tienda";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button button1;
        private Label label7;
    }
}