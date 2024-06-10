namespace Escaner_de_Tienda
{
    partial class Administrar_Ruta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Administrar_Ruta));
            label1 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            button4 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gold;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(332, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(466, 65);
            label1.TabIndex = 0;
            label1.Text = "ADMINISTRAR RUTA";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gold;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(6, -4);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1229, 143);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Enabled = false;
            button1.Location = new Point(465, 332);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(227, 73);
            button1.TabIndex = 2;
            button1.Text = "ACTUALIZAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(254, 175);
            textBox1.Margin = new Padding(4, 2, 4, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(528, 39);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Menu;
            textBox2.Location = new Point(210, 251);
            textBox2.Margin = new Padding(4, 2, 4, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(918, 39);
            textBox2.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 173);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(187, 32);
            label2.TabIndex = 7;
            label2.Text = "COLOR DE RUTA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 251);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 32);
            label3.TabIndex = 8;
            label3.Text = "COBRADOR";
            // 
            // button4
            // 
            button4.Location = new Point(819, 173);
            button4.Margin = new Padding(4, 2, 4, 2);
            button4.Name = "button4";
            button4.Size = new Size(206, 43);
            button4.TabIndex = 9;
            button4.Text = "ANALIZAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Administrar_Ruta
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 436);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 2, 4, 2);
            Name = "Administrar_Ruta";
            Text = "Administrar_Ruta";
            Load += Administrar_Ruta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Button button4;
    }
}