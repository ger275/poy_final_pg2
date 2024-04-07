namespace SistemaParaPrediccionDeVentas.Vista
{
    partial class frmPredecir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPredecir));
            panel1 = new Panel();
            panel5 = new Panel();
            label1 = new Label();
            btnMaximizar = new Button();
            btnRestaurar = new Button();
            btnCerrar = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            btnCargarArchivo = new Button();
            btnGenerarPrediccion = new Button();
            btnCargarProductos = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(78, 78, 78);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMaximizar);
            panel1.Controls.Add(btnRestaurar);
            panel1.Controls.Add(btnCerrar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 74);
            panel1.TabIndex = 2;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Location = new Point(6, 74);
            panel5.Name = "panel5";
            panel5.Size = new Size(938, 472);
            panel5.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(324, 39);
            label1.TabIndex = 15;
            label1.Text = "Generar Predicciones";
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(842, 12);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(45, 45);
            btnMaximizar.TabIndex = 14;
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.FlatAppearance.BorderSize = 0;
            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(842, 12);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(45, 45);
            btnRestaurar.TabIndex = 13;
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(227, 101, 113);
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 17, 3);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(893, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(45, 45);
            btnCerrar.TabIndex = 11;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(78, 78, 78);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(6, 484);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(78, 78, 78);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(944, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(6, 484);
            panel3.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(78, 78, 78);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(6, 550);
            panel4.Name = "panel4";
            panel4.Size = new Size(938, 8);
            panel4.TabIndex = 5;
            // 
            // btnCargarArchivo
            // 
            btnCargarArchivo.Anchor = AnchorStyles.Top;
            btnCargarArchivo.BackColor = Color.FromArgb(90, 90, 90);
            btnCargarArchivo.FlatAppearance.BorderColor = Color.FromArgb(51, 62, 80);
            btnCargarArchivo.FlatAppearance.BorderSize = 3;
            btnCargarArchivo.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 62, 80);
            btnCargarArchivo.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 110, 110);
            btnCargarArchivo.FlatStyle = FlatStyle.Flat;
            btnCargarArchivo.Font = new Font("Lato Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargarArchivo.ForeColor = Color.Gainsboro;
            btnCargarArchivo.Image = (Image)resources.GetObject("btnCargarArchivo.Image");
            btnCargarArchivo.ImageAlign = ContentAlignment.TopCenter;
            btnCargarArchivo.Location = new Point(364, 251);
            btnCargarArchivo.Name = "btnCargarArchivo";
            btnCargarArchivo.Size = new Size(234, 112);
            btnCargarArchivo.TabIndex = 6;
            btnCargarArchivo.Text = "\r\n\r\n\r\nCargar Archivo (.CSV)";
            btnCargarArchivo.UseVisualStyleBackColor = false;
            btnCargarArchivo.Click += btnCargarArchivo_Click;
            // 
            // btnGenerarPrediccion
            // 
            btnGenerarPrediccion.Anchor = AnchorStyles.Top;
            btnGenerarPrediccion.BackColor = Color.FromArgb(90, 90, 90);
            btnGenerarPrediccion.FlatAppearance.BorderColor = Color.FromArgb(51, 62, 80);
            btnGenerarPrediccion.FlatAppearance.BorderSize = 3;
            btnGenerarPrediccion.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 62, 80);
            btnGenerarPrediccion.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 110, 110);
            btnGenerarPrediccion.FlatStyle = FlatStyle.Flat;
            btnGenerarPrediccion.Font = new Font("Lato", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGenerarPrediccion.ForeColor = Color.Gainsboro;
            btnGenerarPrediccion.Image = (Image)resources.GetObject("btnGenerarPrediccion.Image");
            btnGenerarPrediccion.ImageAlign = ContentAlignment.TopCenter;
            btnGenerarPrediccion.Location = new Point(364, 392);
            btnGenerarPrediccion.Name = "btnGenerarPrediccion";
            btnGenerarPrediccion.Size = new Size(234, 112);
            btnGenerarPrediccion.TabIndex = 7;
            btnGenerarPrediccion.Text = "\r\n\r\n\r\nGenerar Predicción";
            btnGenerarPrediccion.UseVisualStyleBackColor = false;
            btnGenerarPrediccion.Click += btnGenerarPrediccion_Click;
            // 
            // btnCargarProductos
            // 
            btnCargarProductos.Anchor = AnchorStyles.Top;
            btnCargarProductos.BackColor = Color.FromArgb(90, 90, 90);
            btnCargarProductos.FlatAppearance.BorderColor = Color.FromArgb(51, 62, 80);
            btnCargarProductos.FlatAppearance.BorderSize = 3;
            btnCargarProductos.FlatAppearance.MouseDownBackColor = Color.FromArgb(51, 62, 80);
            btnCargarProductos.FlatAppearance.MouseOverBackColor = Color.FromArgb(110, 110, 110);
            btnCargarProductos.FlatStyle = FlatStyle.Flat;
            btnCargarProductos.Font = new Font("Lato Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCargarProductos.ForeColor = Color.Gainsboro;
            btnCargarProductos.Image = (Image)resources.GetObject("btnCargarProductos.Image");
            btnCargarProductos.ImageAlign = ContentAlignment.TopCenter;
            btnCargarProductos.Location = new Point(364, 114);
            btnCargarProductos.Name = "btnCargarProductos";
            btnCargarProductos.Size = new Size(234, 112);
            btnCargarProductos.TabIndex = 8;
            btnCargarProductos.Text = "\r\n\r\n\r\nCargar Productos (.CSV)";
            btnCargarProductos.UseVisualStyleBackColor = false;
            btnCargarProductos.Click += btnCargarProductos_Click;
            // 
            // frmPredecir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(950, 558);
            Controls.Add(btnCargarProductos);
            Controls.Add(btnGenerarPrediccion);
            Controls.Add(btnCargarArchivo);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPredecir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPredecir";
            Load += frmPredecir_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Button btnRestaurar;
        private Button btnCerrar;
        private Button btnMaximizar;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Label label1;
        private Panel panel5;
        private Button btnCargarArchivo;
        private Button btnGenerarPrediccion;
        private Button btnCargarProductos;
    }
}