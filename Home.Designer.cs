namespace Escaner_de_Tienda
{
    partial class Home
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
            label1 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            NOMBRE = new DataGridViewTextBoxColumn();
            VENDEDOR = new DataGridViewTextBoxColumn();
            TELEFONO = new DataGridViewTextBoxColumn();
            DOMICILIO = new DataGridViewTextBoxColumn();
            IDRUTA = new DataGridViewTextBoxColumn();
            IDTIENDA = new DataGridViewTextBoxColumn();
            ESTATUS = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            groupBox4 = new GroupBox();
            button10 = new Button();
            button11 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Purple;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(369, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(387, 45);
            label1.TabIndex = 0;
            label1.Text = "ESTATUS DE LAS TIENDAS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Purple;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-2, 0);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1219, 66);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NOMBRE, VENDEDOR, TELEFONO, DOMICILIO, IDRUTA, IDTIENDA, ESTATUS, Column1 });
            dataGridView1.Location = new Point(215, 84);
            dataGridView1.Margin = new Padding(2, 1, 2, 1);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(672, 383);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // NOMBRE
            // 
            NOMBRE.HeaderText = "NOMBRE DE TIENDA";
            NOMBRE.MinimumWidth = 10;
            NOMBRE.Name = "NOMBRE";
            NOMBRE.Width = 200;
            // 
            // VENDEDOR
            // 
            VENDEDOR.HeaderText = "VENDEDOR";
            VENDEDOR.MinimumWidth = 10;
            VENDEDOR.Name = "VENDEDOR";
            VENDEDOR.Width = 200;
            // 
            // TELEFONO
            // 
            TELEFONO.HeaderText = "TELEFONO DE LA TIENDA";
            TELEFONO.MinimumWidth = 10;
            TELEFONO.Name = "TELEFONO";
            TELEFONO.Width = 200;
            // 
            // DOMICILIO
            // 
            DOMICILIO.HeaderText = "DOMICILIO";
            DOMICILIO.MinimumWidth = 10;
            DOMICILIO.Name = "DOMICILIO";
            DOMICILIO.Width = 200;
            // 
            // IDRUTA
            // 
            IDRUTA.HeaderText = "ID DE RUTA";
            IDRUTA.MinimumWidth = 10;
            IDRUTA.Name = "IDRUTA";
            IDRUTA.Width = 200;
            // 
            // IDTIENDA
            // 
            IDTIENDA.HeaderText = "ID DE TIENDA";
            IDTIENDA.MinimumWidth = 10;
            IDTIENDA.Name = "IDTIENDA";
            IDTIENDA.Width = 200;
            // 
            // ESTATUS
            // 
            ESTATUS.HeaderText = "ESTATUS DE COBRO";
            ESTATUS.MinimumWidth = 10;
            ESTATUS.Name = "ESTATUS";
            ESTATUS.Width = 200;
            // 
            // Column1
            // 
            Column1.HeaderText = "MONTO DE COBRO";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            Column1.Width = 200;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(14, 78);
            groupBox1.Margin = new Padding(2, 1, 2, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 1, 2, 1);
            groupBox1.Size = new Size(181, 149);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "RUTA";
            // 
            // button3
            // 
            button3.Location = new Point(21, 104);
            button3.Margin = new Padding(2, 1, 2, 1);
            button3.Name = "button3";
            button3.Size = new Size(149, 22);
            button3.TabIndex = 2;
            button3.Text = "MOSTRAR RUTAS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(18, 59);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(152, 29);
            button2.TabIndex = 1;
            button2.Text = "ADMINISTRAR RUTA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(18, 21);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 0;
            button1.Text = "REGISTRAR RUTA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.Location = new Point(14, 229);
            groupBox2.Margin = new Padding(2, 1, 2, 1);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2, 1, 2, 1);
            groupBox2.Size = new Size(181, 169);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "COBRADOR";
            // 
            // button6
            // 
            button6.Location = new Point(18, 119);
            button6.Margin = new Padding(2, 1, 2, 1);
            button6.Name = "button6";
            button6.Size = new Size(149, 39);
            button6.TabIndex = 3;
            button6.Text = "MOSTRAR COBRADORES";
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(15, 70);
            button5.Margin = new Padding(2, 1, 2, 1);
            button5.Name = "button5";
            button5.Size = new Size(152, 36);
            button5.TabIndex = 3;
            button5.Text = "ADMINISTRAR COBRADOR";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Location = new Point(15, 29);
            button4.Margin = new Padding(2, 1, 2, 1);
            button4.Name = "button4";
            button4.Size = new Size(152, 29);
            button4.TabIndex = 2;
            button4.Text = "REGISTRAR COBRADOR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(button10);
            groupBox4.Controls.Add(button11);
            groupBox4.Location = new Point(14, 408);
            groupBox4.Margin = new Padding(2, 1, 2, 1);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(2, 1, 2, 1);
            groupBox4.Size = new Size(181, 154);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "TIENDA";
            // 
            // button10
            // 
            button10.Location = new Point(18, 73);
            button10.Margin = new Padding(2, 1, 2, 1);
            button10.Name = "button10";
            button10.Size = new Size(152, 29);
            button10.TabIndex = 3;
            button10.Text = "ADMINISTRAR TIENDA";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.Location = new Point(18, 30);
            button11.Margin = new Padding(2, 1, 2, 1);
            button11.Name = "button11";
            button11.Size = new Size(152, 29);
            button11.TabIndex = 2;
            button11.Text = "REGISTRAR TIENDA";
            button11.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 483);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button2;
        private Button button1;
        private Button button5;
        private Button button4;
        private GroupBox groupBox4;
        private Button button10;
        private Button button11;
        private Button button3;
        private Button button6;
        private DataGridViewTextBoxColumn NOMBRE;
        private DataGridViewTextBoxColumn VENDEDOR;
        private DataGridViewTextBoxColumn TELEFONO;
        private DataGridViewTextBoxColumn DOMICILIO;
        private DataGridViewTextBoxColumn IDRUTA;
        private DataGridViewTextBoxColumn IDTIENDA;
        private DataGridViewTextBoxColumn ESTATUS;
        private DataGridViewTextBoxColumn Column1;
    }
}