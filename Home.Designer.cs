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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            label1 = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
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
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            saveFileDialog1 = new SaveFileDialog();
            VENDEDOR = new DataGridViewTextBoxColumn();
            TELEFONO = new DataGridViewTextBoxColumn();
            DOMICILIO = new DataGridViewTextBoxColumn();
            ESTATUS = new DataGridViewTextBoxColumn();
            IDTIENDA = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            COLORRUTA = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Purple;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(411, 33);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(768, 86);
            label1.TabIndex = 0;
            label1.Text = "ESTATUS DE LAS TIENDAS";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.Purple;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 2, 4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(2254, 1118);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { VENDEDOR, TELEFONO, DOMICILIO, ESTATUS, IDTIENDA, Column1, Column2, Column3, COLORRUTA });
            dataGridView1.Location = new Point(422, 292);
            dataGridView1.Margin = new Padding(4, 2, 4, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1792, 800);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Purple;
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(26, 166);
            groupBox1.Margin = new Padding(4, 2, 4, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 2, 4, 2);
            groupBox1.Size = new Size(336, 318);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "RUTA";
            // 
            // button3
            // 
            button3.ForeColor = Color.Black;
            button3.Location = new Point(39, 222);
            button3.Margin = new Padding(4, 2, 4, 2);
            button3.Name = "button3";
            button3.Size = new Size(277, 47);
            button3.TabIndex = 2;
            button3.Text = "MOSTRAR RUTAS";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click_1;
            // 
            // button2
            // 
            button2.ForeColor = Color.Black;
            button2.Location = new Point(33, 126);
            button2.Margin = new Padding(4, 2, 4, 2);
            button2.Name = "button2";
            button2.Size = new Size(282, 62);
            button2.TabIndex = 1;
            button2.Text = "ADMINISTRAR RUTA";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.ForeColor = Color.Black;
            button1.Location = new Point(33, 45);
            button1.Margin = new Padding(4, 2, 4, 2);
            button1.Name = "button1";
            button1.Size = new Size(282, 62);
            button1.TabIndex = 0;
            button1.Text = "REGISTRAR RUTA";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Purple;
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button4);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(26, 489);
            groupBox2.Margin = new Padding(4, 2, 4, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 2, 4, 2);
            groupBox2.Size = new Size(336, 361);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "COBRADOR";
            // 
            // button6
            // 
            button6.ForeColor = Color.Black;
            button6.Location = new Point(33, 254);
            button6.Margin = new Padding(4, 2, 4, 2);
            button6.Name = "button6";
            button6.Size = new Size(277, 83);
            button6.TabIndex = 3;
            button6.Text = "MOSTRAR COBRADORES";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.ForeColor = Color.Black;
            button5.Location = new Point(28, 149);
            button5.Margin = new Padding(4, 2, 4, 2);
            button5.Name = "button5";
            button5.Size = new Size(282, 77);
            button5.TabIndex = 3;
            button5.Text = "ADMINISTRAR COBRADOR";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.ForeColor = Color.Black;
            button4.Location = new Point(28, 62);
            button4.Margin = new Padding(4, 2, 4, 2);
            button4.Name = "button4";
            button4.Size = new Size(282, 62);
            button4.TabIndex = 2;
            button4.Text = "REGISTRAR COBRADOR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Purple;
            groupBox4.Controls.Add(button10);
            groupBox4.Controls.Add(button11);
            groupBox4.ForeColor = Color.White;
            groupBox4.Location = new Point(26, 870);
            groupBox4.Margin = new Padding(4, 2, 4, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 2, 4, 2);
            groupBox4.Size = new Size(336, 239);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "TIENDA";
            // 
            // button10
            // 
            button10.ForeColor = Color.Black;
            button10.Location = new Point(33, 156);
            button10.Margin = new Padding(4, 2, 4, 2);
            button10.Name = "button10";
            button10.Size = new Size(282, 62);
            button10.TabIndex = 3;
            button10.Text = "ADMINISTRAR TIENDA";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // button11
            // 
            button11.ForeColor = Color.Black;
            button11.Location = new Point(33, 64);
            button11.Margin = new Padding(4, 2, 4, 2);
            button11.Name = "button11";
            button11.Size = new Size(282, 62);
            button11.TabIndex = 2;
            button11.Text = "REGISTRAR TIENDA";
            button11.UseVisualStyleBackColor = true;
            button11.Click += button11_Click;
            // 
            // button7
            // 
            button7.Location = new Point(422, 183);
            button7.Margin = new Padding(4, 2, 4, 2);
            button7.Name = "button7";
            button7.Size = new Size(332, 81);
            button7.TabIndex = 6;
            button7.Text = "CAMBIAR A PENDIENTE";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(787, 183);
            button8.Margin = new Padding(4, 2, 4, 2);
            button8.Name = "button8";
            button8.Size = new Size(422, 81);
            button8.TabIndex = 7;
            button8.Text = "EXPORTAR A EXCEL";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(1237, 183);
            button9.Margin = new Padding(4, 2, 4, 2);
            button9.Name = "button9";
            button9.Size = new Size(308, 81);
            button9.TabIndex = 8;
            button9.Text = "RECARGAR TABLA";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // VENDEDOR
            // 
            VENDEDOR.HeaderText = "VENDEDOR";
            VENDEDOR.MinimumWidth = 10;
            VENDEDOR.Name = "VENDEDOR";
            // 
            // TELEFONO
            // 
            TELEFONO.HeaderText = "TELEFONO DE LA TIENDA";
            TELEFONO.MinimumWidth = 10;
            TELEFONO.Name = "TELEFONO";
            // 
            // DOMICILIO
            // 
            DOMICILIO.HeaderText = "DOMICILIO";
            DOMICILIO.MinimumWidth = 10;
            DOMICILIO.Name = "DOMICILIO";
            // 
            // ESTATUS
            // 
            ESTATUS.HeaderText = "ESTATUS DE COBRO";
            ESTATUS.MinimumWidth = 10;
            ESTATUS.Name = "ESTATUS";
            // 
            // IDTIENDA
            // 
            IDTIENDA.HeaderText = "ID DE TIENDA";
            IDTIENDA.MinimumWidth = 10;
            IDTIENDA.Name = "IDTIENDA";
            // 
            // Column1
            // 
            Column1.HeaderText = "MONTO DE COBRO";
            Column1.MinimumWidth = 10;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "COLOR DE RUTA";
            Column2.MinimumWidth = 10;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "DESCRIPCION";
            Column3.MinimumWidth = 10;
            Column3.Name = "Column3";
            // 
            // COLORRUTA
            // 
            COLORRUTA.HeaderText = "NOTAS";
            COLORRUTA.MinimumWidth = 10;
            COLORRUTA.Name = "COLORRUTA";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(192F, 192F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            ClientSize = new Size(2254, 1118);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 2, 4, 2);
            MaximizeBox = false;
            Name = "Home";
            Text = "PAGINA PRINCIPAL";
            WindowState = FormWindowState.Maximized;
            Load += Home_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private Button button7;
        private Button button8;
        private Button button9;
        private SaveFileDialog saveFileDialog1;
        private DataGridViewTextBoxColumn NOMBRE;
        private Button button12;
        private DataGridViewTextBoxColumn VENDEDOR;
        private DataGridViewTextBoxColumn TELEFONO;
        private DataGridViewTextBoxColumn DOMICILIO;
        private DataGridViewTextBoxColumn ESTATUS;
        private DataGridViewTextBoxColumn IDTIENDA;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn COLORRUTA;
    }
}