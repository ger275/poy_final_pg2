namespace SistemaParaPrediccionDeVentas.Vista
{
    partial class frmPredecirVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPredecirVentas));
            panel4 = new Panel();
            panel10 = new Panel();
            panel9 = new Panel();
            panelTitulo = new Panel();
            button1 = new Button();
            panel7 = new Panel();
            panel6 = new Panel();
            panel1 = new Panel();
            button2 = new Button();
            lblTitulo = new Label();
            btnMaximizar = new Button();
            btnRestaurar = new Button();
            btnCerrar = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            panel2 = new Panel();
            panel11 = new Panel();
            panel8 = new Panel();
            btnGrafica = new Button();
            btnReporte = new Button();
            label4 = new Label();
            label6 = new Label();
            cmbPeriodoHasta = new ComboBox();
            checkBox1 = new CheckBox();
            txtPeriodoDesde = new TextBox();
            grProductosAgregar = new DataGridView();
            grProductosAgregados = new DataGridView();
            chkCrecimientoMensual = new CheckBox();
            checkBox4 = new CheckBox();
            label1 = new Label();
            grPrediccion = new DataGridView();
            frmGrafica = new ScottPlot.FormsPlot();
            txtCosto = new TextBox();
            txtVenta = new TextBox();
            lblCosto = new Label();
            lblVenta = new Label();
            txtValorRoi = new TextBox();
            lblValorRoi = new Label();
            panel4.SuspendLayout();
            panelTitulo.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grProductosAgregar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grProductosAgregados).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grPrediccion).BeginInit();
            SuspendLayout();
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(74, 87, 108);
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(panel9);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(0, 608);
            panel4.Name = "panel4";
            panel4.Size = new Size(1250, 8);
            panel4.TabIndex = 7;
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(104, 116, 135);
            panel10.Dock = DockStyle.Right;
            panel10.Location = new Point(1249, 0);
            panel10.Name = "panel10";
            panel10.Size = new Size(1, 7);
            panel10.TabIndex = 1;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(104, 116, 135);
            panel9.Dock = DockStyle.Bottom;
            panel9.Location = new Point(0, 7);
            panel9.Name = "panel9";
            panel9.Size = new Size(1250, 1);
            panel9.TabIndex = 0;
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(74, 87, 108);
            panelTitulo.Controls.Add(button1);
            panelTitulo.Controls.Add(panel7);
            panelTitulo.Controls.Add(panel6);
            panelTitulo.Controls.Add(panel1);
            panelTitulo.Controls.Add(button2);
            panelTitulo.Controls.Add(lblTitulo);
            panelTitulo.Controls.Add(btnMaximizar);
            panelTitulo.Controls.Add(btnRestaurar);
            panelTitulo.Controls.Add(btnCerrar);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(1250, 59);
            panelTitulo.TabIndex = 10;
            panelTitulo.MouseDown += panelTitulo_MouseDown;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(227, 101, 113);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 17, 3);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1198, 8);
            button1.Name = "button1";
            button1.Size = new Size(45, 45);
            button1.TabIndex = 32;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(104, 116, 135);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 1);
            panel7.Name = "panel7";
            panel7.Size = new Size(1, 58);
            panel7.TabIndex = 31;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(104, 116, 135);
            panel6.Dock = DockStyle.Right;
            panel6.Location = new Point(1249, 1);
            panel6.Name = "panel6";
            panel6.Size = new Size(1, 58);
            panel6.TabIndex = 30;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(104, 116, 135);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1250, 1);
            panel1.TabIndex = 29;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(227, 101, 113);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 17, 3);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1390, 8);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 17;
            button2.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Lato", 23.9999962F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Gainsboro;
            lblTitulo.Image = (Image)resources.GetObject("lblTitulo.Image");
            lblTitulo.ImageAlign = ContentAlignment.MiddleLeft;
            lblTitulo.Location = new Point(12, 8);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(283, 40);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Predecir Ventas";
            lblTitulo.TextAlign = ContentAlignment.MiddleRight;
            lblTitulo.MouseDown += lblTitulo_MouseDown;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(2089, 12);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(45, 45);
            btnMaximizar.TabIndex = 14;
            btnMaximizar.UseVisualStyleBackColor = true;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.FlatAppearance.BorderSize = 0;
            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(2089, 12);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(45, 45);
            btnRestaurar.TabIndex = 13;
            btnRestaurar.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(227, 101, 113);
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 17, 3);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(2140, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(45, 45);
            btnCerrar.TabIndex = 11;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(74, 87, 108);
            panel3.Controls.Add(panel5);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1244, 59);
            panel3.Name = "panel3";
            panel3.Size = new Size(6, 549);
            panel3.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(104, 116, 135);
            panel5.Dock = DockStyle.Right;
            panel5.Location = new Point(5, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1, 549);
            panel5.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(74, 87, 108);
            panel2.Controls.Add(panel11);
            panel2.Controls.Add(panel8);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(6, 549);
            panel2.TabIndex = 12;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(104, 116, 135);
            panel11.Dock = DockStyle.Bottom;
            panel11.Location = new Point(1, 548);
            panel11.Name = "panel11";
            panel11.Size = new Size(5, 1);
            panel11.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(104, 116, 135);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1, 549);
            panel8.TabIndex = 0;
            // 
            // btnGrafica
            // 
            btnGrafica.BackColor = Color.FromArgb(74, 87, 108);
            btnGrafica.FlatAppearance.BorderColor = Color.FromArgb(17, 31, 52);
            btnGrafica.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 31, 52);
            btnGrafica.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 62, 80);
            btnGrafica.FlatStyle = FlatStyle.Flat;
            btnGrafica.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnGrafica.ForeColor = Color.White;
            btnGrafica.Image = (Image)resources.GetObject("btnGrafica.Image");
            btnGrafica.ImageAlign = ContentAlignment.TopCenter;
            btnGrafica.Location = new Point(276, 518);
            btnGrafica.Name = "btnGrafica";
            btnGrafica.Size = new Size(134, 70);
            btnGrafica.TabIndex = 23;
            btnGrafica.Text = "Generar Gráfica PDF";
            btnGrafica.TextAlign = ContentAlignment.BottomCenter;
            btnGrafica.UseVisualStyleBackColor = false;
            btnGrafica.Click += btnGrafica_Click;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.FromArgb(74, 87, 108);
            btnReporte.FlatAppearance.BorderColor = Color.FromArgb(17, 31, 52);
            btnReporte.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 31, 52);
            btnReporte.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 62, 80);
            btnReporte.FlatStyle = FlatStyle.Flat;
            btnReporte.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            btnReporte.ForeColor = Color.Gainsboro;
            btnReporte.Image = (Image)resources.GetObject("btnReporte.Image");
            btnReporte.ImageAlign = ContentAlignment.TopCenter;
            btnReporte.Location = new Point(126, 518);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(134, 70);
            btnReporte.TabIndex = 22;
            btnReporte.Text = "Generar Reporte PDF";
            btnReporte.TextAlign = ContentAlignment.BottomCenter;
            btnReporte.UseVisualStyleBackColor = false;
            btnReporte.Click += btnReporte_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(27, 250);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 34;
            label4.Text = "Predecir hasta";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(27, 284);
            label6.Name = "label6";
            label6.Size = new Size(51, 20);
            label6.TabIndex = 35;
            label6.Text = "Desde";
            // 
            // cmbPeriodoHasta
            // 
            cmbPeriodoHasta.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPeriodoHasta.Font = new Font("Segoe UI", 11.25F);
            cmbPeriodoHasta.FormattingEnabled = true;
            cmbPeriodoHasta.Location = new Point(236, 252);
            cmbPeriodoHasta.Name = "cmbPeriodoHasta";
            cmbPeriodoHasta.Size = new Size(220, 28);
            cmbPeriodoHasta.TabIndex = 40;
            cmbPeriodoHasta.SelectedValueChanged += cmbPeriodoHasta_SelectedValueChanged;
            // 
            // checkBox1
            // 
            checkBox1.Font = new Font("Segoe UI", 11F);
            checkBox1.Location = new Point(172, 540);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(220, 28);
            checkBox1.TabIndex = 42;
            checkBox1.Text = "ver valores de las ventas";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.Visible = false;
            // 
            // txtPeriodoDesde
            // 
            txtPeriodoDesde.Enabled = false;
            txtPeriodoDesde.Font = new Font("Segoe UI", 11.25F);
            txtPeriodoDesde.Location = new Point(236, 286);
            txtPeriodoDesde.MaxLength = 200;
            txtPeriodoDesde.Multiline = true;
            txtPeriodoDesde.Name = "txtPeriodoDesde";
            txtPeriodoDesde.Size = new Size(220, 28);
            txtPeriodoDesde.TabIndex = 44;
            // 
            // grProductosAgregar
            // 
            grProductosAgregar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grProductosAgregar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grProductosAgregar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grProductosAgregar.GridColor = SystemColors.ActiveCaption;
            grProductosAgregar.Location = new Point(25, 93);
            grProductosAgregar.MultiSelect = false;
            grProductosAgregar.Name = "grProductosAgregar";
            grProductosAgregar.ReadOnly = true;
            grProductosAgregar.RowTemplate.Height = 25;
            grProductosAgregar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grProductosAgregar.Size = new Size(262, 144);
            grProductosAgregar.TabIndex = 45;
            grProductosAgregar.DoubleClick += grProductosAgregar_DoubleClick;
            // 
            // grProductosAgregados
            // 
            grProductosAgregados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grProductosAgregados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grProductosAgregados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grProductosAgregados.Location = new Point(293, 93);
            grProductosAgregados.Name = "grProductosAgregados";
            grProductosAgregados.ReadOnly = true;
            grProductosAgregados.RowTemplate.Height = 25;
            grProductosAgregados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grProductosAgregados.Size = new Size(262, 144);
            grProductosAgregados.TabIndex = 46;
            grProductosAgregados.DoubleClick += grProductosAgregados_DoubleClick;
            // 
            // chkCrecimientoMensual
            // 
            chkCrecimientoMensual.Font = new Font("Segoe UI", 11F);
            chkCrecimientoMensual.Location = new Point(236, 320);
            chkCrecimientoMensual.Name = "chkCrecimientoMensual";
            chkCrecimientoMensual.Size = new Size(220, 28);
            chkCrecimientoMensual.TabIndex = 47;
            chkCrecimientoMensual.Text = "ver crecimiento mensual";
            chkCrecimientoMensual.UseVisualStyleBackColor = true;
            chkCrecimientoMensual.Click += chkCrecimientoMensual_Click;
            // 
            // checkBox4
            // 
            checkBox4.Font = new Font("Segoe UI", 11F);
            checkBox4.Location = new Point(236, 354);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(220, 28);
            checkBox4.TabIndex = 48;
            checkBox4.Text = "calcular ROI";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.Click += checkBox4_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(27, 67);
            label1.Name = "label1";
            label1.Size = new Size(260, 23);
            label1.TabIndex = 49;
            label1.Text = "Seleccione producto(s)";
            // 
            // grPrediccion
            // 
            grPrediccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            grPrediccion.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grPrediccion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grPrediccion.Location = new Point(587, 93);
            grPrediccion.Name = "grPrediccion";
            grPrediccion.ReadOnly = true;
            grPrediccion.RowTemplate.Height = 25;
            grPrediccion.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grPrediccion.Size = new Size(637, 184);
            grPrediccion.TabIndex = 50;
            // 
            // frmGrafica
            // 
            frmGrafica.Font = new Font("Segoe UI", 11F);
            frmGrafica.Location = new Point(541, 284);
            frmGrafica.Margin = new Padding(5, 4, 5, 4);
            frmGrafica.Name = "frmGrafica";
            frmGrafica.Size = new Size(704, 324);
            frmGrafica.TabIndex = 51;
            // 
            // txtCosto
            // 
            txtCosto.Font = new Font("Segoe UI", 11.25F);
            txtCosto.Location = new Point(236, 388);
            txtCosto.MaxLength = 200;
            txtCosto.Multiline = true;
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(220, 28);
            txtCosto.TabIndex = 52;
            txtCosto.TextChanged += txtCosto_TextChanged;
            // 
            // txtVenta
            // 
            txtVenta.Font = new Font("Segoe UI", 11.25F);
            txtVenta.Location = new Point(236, 422);
            txtVenta.MaxLength = 200;
            txtVenta.Multiline = true;
            txtVenta.Name = "txtVenta";
            txtVenta.Size = new Size(220, 28);
            txtVenta.TabIndex = 53;
            txtVenta.TextChanged += txtVenta_TextChanged;
            // 
            // lblCosto
            // 
            lblCosto.AutoSize = true;
            lblCosto.Font = new Font("Segoe UI", 11.25F);
            lblCosto.ForeColor = SystemColors.ControlText;
            lblCosto.Location = new Point(29, 391);
            lblCosto.Name = "lblCosto";
            lblCosto.Size = new Size(175, 20);
            lblCosto.TabIndex = 54;
            lblCosto.Text = "Ingrese el valor del costo";
            // 
            // lblVenta
            // 
            lblVenta.AutoSize = true;
            lblVenta.Font = new Font("Segoe UI", 11.25F);
            lblVenta.ForeColor = SystemColors.ControlText;
            lblVenta.Location = new Point(29, 425);
            lblVenta.Name = "lblVenta";
            lblVenta.Size = new Size(171, 20);
            lblVenta.TabIndex = 55;
            lblVenta.Text = "Ingrese el valor de venta";
            // 
            // txtValorRoi
            // 
            txtValorRoi.Enabled = false;
            txtValorRoi.Font = new Font("Segoe UI", 11.25F);
            txtValorRoi.Location = new Point(236, 456);
            txtValorRoi.MaxLength = 200;
            txtValorRoi.Multiline = true;
            txtValorRoi.Name = "txtValorRoi";
            txtValorRoi.Size = new Size(220, 28);
            txtValorRoi.TabIndex = 56;
            // 
            // lblValorRoi
            // 
            lblValorRoi.AutoSize = true;
            lblValorRoi.Font = new Font("Segoe UI", 11.25F);
            lblValorRoi.ForeColor = SystemColors.ControlText;
            lblValorRoi.Location = new Point(29, 459);
            lblValorRoi.Name = "lblValorRoi";
            lblValorRoi.Size = new Size(203, 20);
            lblValorRoi.TabIndex = 57;
            lblValorRoi.Text = "Valor del ROI para el período";
            // 
            // frmPredecirVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(104, 116, 135);
            ClientSize = new Size(1250, 616);
            Controls.Add(lblValorRoi);
            Controls.Add(txtValorRoi);
            Controls.Add(lblVenta);
            Controls.Add(lblCosto);
            Controls.Add(txtVenta);
            Controls.Add(txtCosto);
            Controls.Add(frmGrafica);
            Controls.Add(grPrediccion);
            Controls.Add(label1);
            Controls.Add(checkBox4);
            Controls.Add(chkCrecimientoMensual);
            Controls.Add(grProductosAgregados);
            Controls.Add(grProductosAgregar);
            Controls.Add(txtPeriodoDesde);
            Controls.Add(cmbPeriodoHasta);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(btnGrafica);
            Controls.Add(btnReporte);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panelTitulo);
            Controls.Add(panel4);
            Controls.Add(checkBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPredecirVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPredecirVentas";
            Load += frmPredecirVentas_Load;
            panel4.ResumeLayout(false);
            panelTitulo.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)grProductosAgregar).EndInit();
            ((System.ComponentModel.ISupportInitialize)grProductosAgregados).EndInit();
            ((System.ComponentModel.ISupportInitialize)grPrediccion).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel4;
        private Panel panel10;
        private Panel panel9;
        private Panel panelTitulo;
        private Panel panel7;
        private Panel panel6;
        private Panel panel1;
        private Button button2;
        private Label lblTitulo;
        private Button btnMaximizar;
        private Button btnRestaurar;
        private Button btnCerrar;
        private Button button1;
        private Panel panel3;
        private Panel panel5;
        private Panel panel2;
        private Panel panel11;
        private Panel panel8;
        private Button btnGrafica;
        private Button btnReporte;
        private Label label4;
        private Label label6;
        private ComboBox cmbPeriodoHasta;
        private CheckBox checkBox1;
        private TextBox txtPeriodoDesde;
        private DataGridView grProductosAgregar;
        private DataGridView grProductosAgregados;
        private CheckBox chkCrecimientoMensual;
        private CheckBox checkBox4;
        private Label label1;
        private DataGridView grPrediccion;
        private ScottPlot.FormsPlot frmGrafica;
        private TextBox txtCosto;
        private TextBox txtVenta;
        private Label lblCosto;
        private Label lblVenta;
        private TextBox txtValorRoi;
        private Label lblValorRoi;
    }
}