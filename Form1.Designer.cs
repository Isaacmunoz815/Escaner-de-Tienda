﻿namespace Escaner_de_Tienda
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            linkLabel2 = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DodgerBlue;
            label1.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(292, 28);
            label1.Name = "label1";
            label1.Size = new Size(326, 59);
            label1.TabIndex = 0;
            label1.Text = "INICIAR SESION";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 146);
            label2.Name = "label2";
            label2.Size = new Size(262, 32);
            label2.TabIndex = 1;
            label2.Text = "CORREO ELECTRONICO";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 215);
            label3.Name = "label3";
            label3.Size = new Size(164, 32);
            label3.TabIndex = 2;
            label3.Text = "CONTRASEÑA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(356, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(498, 39);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(356, 215);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(498, 39);
            textBox2.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(329, 301);
            button1.Name = "button1";
            button1.Size = new Size(266, 46);
            button1.TabIndex = 5;
            button1.Text = "INICIAR SESION";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(912, 118);
            panel1.TabIndex = 6;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(311, 384);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(320, 32);
            linkLabel2.TabIndex = 8;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "REGISTRAR USUARIO NUEVO";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 450);
            Controls.Add(linkLabel2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Iniciar Sesion";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Panel panel1;
        private LinkLabel linkLabel2;
    }
}