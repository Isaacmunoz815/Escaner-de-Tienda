﻿namespace Escaner_de_Tienda
{
    partial class REGISTRAR_COBRADOR
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
            panel1 = new Panel();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(625, 46);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(174, 9);
            label1.Name = "label1";
            label1.Size = new Size(262, 32);
            label1.TabIndex = 0;
            label1.Text = "REGISTRAR COBRADOR";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(173, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(437, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(173, 107);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(437, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(173, 157);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(437, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(173, 209);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(437, 23);
            textBox4.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(265, 258);
            button1.Name = "button1";
            button1.Size = new Size(170, 31);
            button1.TabIndex = 5;
            button1.Text = "REGISTRAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 65);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 6;
            label2.Text = "NOMBRE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 110);
            label3.Name = "label3";
            label3.Size = new Size(133, 15);
            label3.TabIndex = 7;
            label3.Text = "CORREO ELECTRONICO";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 165);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 8;
            label4.Text = "TELEFONO";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 217);
            label5.Name = "label5";
            label5.Size = new Size(135, 15);
            label5.TabIndex = 9;
            label5.Text = "FECHA DE NACIMIENTO";
            // 
            // REGISTRAR_COBRADOR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(625, 311);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "REGISTRAR_COBRADOR";
            Text = "REGISTRAR_COBRADOR";
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
        private Button button1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}