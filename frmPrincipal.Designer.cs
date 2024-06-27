namespace SistemaParaPrediccionDeVentas
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            pMenu = new Panel();
            btnConfiguracion = new Button();
            btnRestaurar = new Button();
            btnMinimizar = new Button();
            btnMaximizar = new Button();
            btnGraficas = new Button();
            btnReportes = new Button();
            btnPredecir = new Button();
            btnSalir = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            pFormulariosHijos = new Panel();
            pConfiguracion = new Panel();
            btnEntrenarModelo = new Button();
            btnConfigServidor = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pReportes = new Panel();
            button6 = new Button();
            btnComparativo = new Button();
            btnPrediccionActual = new Button();
            pMenu.SuspendLayout();
            pFormulariosHijos.SuspendLayout();
            pConfiguracion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pReportes.SuspendLayout();
            SuspendLayout();
            // 
            // pMenu
            // 
            pMenu.BackColor = Color.FromArgb(51, 62, 80);
            pMenu.Controls.Add(btnConfiguracion);
            pMenu.Controls.Add(btnRestaurar);
            pMenu.Controls.Add(btnMinimizar);
            pMenu.Controls.Add(btnMaximizar);
            pMenu.Controls.Add(btnGraficas);
            pMenu.Controls.Add(btnReportes);
            pMenu.Controls.Add(btnPredecir);
            pMenu.Controls.Add(btnSalir);
            pMenu.Dock = DockStyle.Top;
            pMenu.Location = new Point(0, 0);
            pMenu.Name = "pMenu";
            pMenu.Size = new Size(1121, 60);
            pMenu.TabIndex = 0;
            pMenu.MouseDown += panel1_MouseDown;
            // 
            // btnConfiguracion
            // 
            btnConfiguracion.FlatAppearance.BorderSize = 0;
            btnConfiguracion.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 87, 108);
            btnConfiguracion.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnConfiguracion.FlatStyle = FlatStyle.Flat;
            btnConfiguracion.Font = new Font("Lato", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfiguracion.ForeColor = Color.Gainsboro;
            btnConfiguracion.Location = new Point(504, 7);
            btnConfiguracion.Name = "btnConfiguracion";
            btnConfiguracion.Size = new Size(160, 40);
            btnConfiguracion.TabIndex = 12;
            btnConfiguracion.Text = "Configuración";
            btnConfiguracion.UseVisualStyleBackColor = true;
            btnConfiguracion.Click += btnConfiguracion_Click;
            btnConfiguracion.MouseEnter += btnMouseEnter;
            btnConfiguracion.MouseLeave += btnMouseLeave;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.FlatAppearance.BorderSize = 0;
            btnRestaurar.FlatStyle = FlatStyle.Flat;
            btnRestaurar.Image = (Image)resources.GetObject("btnRestaurar.Image");
            btnRestaurar.Location = new Point(1025, 3);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(45, 45);
            btnRestaurar.TabIndex = 10;
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.FlatAppearance.BorderSize = 0;
            btnMinimizar.FlatStyle = FlatStyle.Flat;
            btnMinimizar.Image = (Image)resources.GetObject("btnMinimizar.Image");
            btnMinimizar.Location = new Point(974, 0);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(45, 45);
            btnMinimizar.TabIndex = 9;
            btnMinimizar.UseVisualStyleBackColor = true;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1025, 0);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(45, 45);
            btnMaximizar.TabIndex = 8;
            btnMaximizar.UseVisualStyleBackColor = true;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnGraficas
            // 
            btnGraficas.FlatAppearance.BorderSize = 0;
            btnGraficas.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 87, 108);
            btnGraficas.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnGraficas.FlatStyle = FlatStyle.Flat;
            btnGraficas.Font = new Font("Lato", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnGraficas.ForeColor = Color.Gainsboro;
            btnGraficas.Location = new Point(338, 7);
            btnGraficas.Name = "btnGraficas";
            btnGraficas.Size = new Size(160, 40);
            btnGraficas.TabIndex = 7;
            btnGraficas.Text = "Gráficas";
            btnGraficas.UseVisualStyleBackColor = true;
            btnGraficas.Click += btnGraficas_Click;
            btnGraficas.MouseEnter += btnMouseEnter;
            btnGraficas.MouseLeave += btnMouseLeave;
            // 
            // btnReportes
            // 
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 87, 108);
            btnReportes.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Lato", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnReportes.ForeColor = Color.Gainsboro;
            btnReportes.Image = (Image)resources.GetObject("btnReportes.Image");
            btnReportes.ImageAlign = ContentAlignment.MiddleRight;
            btnReportes.Location = new Point(172, 7);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(160, 40);
            btnReportes.TabIndex = 6;
            btnReportes.Text = "Reportes ";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            btnReportes.MouseEnter += btnMouseEnter;
            btnReportes.MouseLeave += btnMouseLeave;
            // 
            // btnPredecir
            // 
            btnPredecir.FlatAppearance.BorderSize = 0;
            btnPredecir.FlatAppearance.MouseDownBackColor = Color.FromArgb(74, 87, 108);
            btnPredecir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnPredecir.FlatStyle = FlatStyle.Flat;
            btnPredecir.Font = new Font("Lato", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnPredecir.ForeColor = Color.Gainsboro;
            btnPredecir.Location = new Point(6, 7);
            btnPredecir.Name = "btnPredecir";
            btnPredecir.Size = new Size(160, 40);
            btnPredecir.TabIndex = 5;
            btnPredecir.Text = "Predecir";
            btnPredecir.UseVisualStyleBackColor = true;
            btnPredecir.Click += btnPredecir_Click;
            btnPredecir.MouseEnter += btnMouseEnter;
            btnPredecir.MouseLeave += btnMouseLeave;
            // 
            // btnSalir
            // 
            btnSalir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(227, 101, 113);
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 17, 3);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Image = (Image)resources.GetObject("btnSalir.Image");
            btnSalir.Location = new Point(1076, 0);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(45, 45);
            btnSalir.TabIndex = 4;
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 62, 80);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 60);
            panel2.Name = "panel2";
            panel2.Size = new Size(6, 610);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(51, 62, 80);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(1115, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(6, 610);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(51, 62, 80);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(6, 662);
            panel4.Name = "panel4";
            panel4.Size = new Size(1109, 8);
            panel4.TabIndex = 3;
            // 
            // pFormulariosHijos
            // 
            pFormulariosHijos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pFormulariosHijos.BackColor = Color.White;
            pFormulariosHijos.Controls.Add(pConfiguracion);
            pFormulariosHijos.Controls.Add(pictureBox1);
            pFormulariosHijos.Controls.Add(label1);
            pFormulariosHijos.Controls.Add(pReportes);
            pFormulariosHijos.Location = new Point(6, 60);
            pFormulariosHijos.Name = "pFormulariosHijos";
            pFormulariosHijos.Size = new Size(1109, 605);
            pFormulariosHijos.TabIndex = 5;
            // 
            // pConfiguracion
            // 
            pConfiguracion.BackColor = Color.FromArgb(74, 87, 108);
            pConfiguracion.Controls.Add(btnEntrenarModelo);
            pConfiguracion.Controls.Add(btnConfigServidor);
            pConfiguracion.Location = new Point(498, 0);
            pConfiguracion.Name = "pConfiguracion";
            pConfiguracion.Size = new Size(200, 173);
            pConfiguracion.TabIndex = 8;
            pConfiguracion.Visible = false;
            // 
            // btnEntrenarModelo
            // 
            btnEntrenarModelo.FlatAppearance.BorderSize = 0;
            btnEntrenarModelo.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnEntrenarModelo.FlatStyle = FlatStyle.Flat;
            btnEntrenarModelo.Font = new Font("Lato", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnEntrenarModelo.ForeColor = Color.White;
            btnEntrenarModelo.Location = new Point(0, 46);
            btnEntrenarModelo.Name = "btnEntrenarModelo";
            btnEntrenarModelo.Size = new Size(200, 40);
            btnEntrenarModelo.TabIndex = 10;
            btnEntrenarModelo.Text = "Entrenar modelo";
            btnEntrenarModelo.UseVisualStyleBackColor = true;
            btnEntrenarModelo.Click += btnEntrenarModelo_Click;
            // 
            // btnConfigServidor
            // 
            btnConfigServidor.FlatAppearance.BorderSize = 0;
            btnConfigServidor.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnConfigServidor.FlatStyle = FlatStyle.Flat;
            btnConfigServidor.Font = new Font("Lato", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnConfigServidor.ForeColor = Color.White;
            btnConfigServidor.Location = new Point(0, 0);
            btnConfigServidor.Name = "btnConfigServidor";
            btnConfigServidor.Size = new Size(200, 40);
            btnConfigServidor.TabIndex = 9;
            btnConfigServidor.Text = "Servidor";
            btnConfigServidor.UseVisualStyleBackColor = true;
            btnConfigServidor.Click += btnConfigServidor_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 549);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(491, 36);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(4, 583);
            label1.Name = "label1";
            label1.Size = new Size(222, 17);
            label1.TabIndex = 6;
            label1.Text = "Desarrollado por: Gerson López 2023";
            // 
            // pReportes
            // 
            pReportes.BackColor = Color.FromArgb(51, 62, 80);
            pReportes.Controls.Add(button6);
            pReportes.Controls.Add(btnComparativo);
            pReportes.Controls.Add(btnPrediccionActual);
            pReportes.Location = new Point(166, 0);
            pReportes.Name = "pReportes";
            pReportes.Size = new Size(200, 173);
            pReportes.TabIndex = 5;
            pReportes.Visible = false;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Lato", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.Gainsboro;
            button6.Location = new Point(0, 112);
            button6.Name = "button6";
            button6.Size = new Size(200, 40);
            button6.TabIndex = 10;
            button6.Text = "Prueba";
            button6.UseVisualStyleBackColor = true;
            // 
            // btnComparativo
            // 
            btnComparativo.FlatAppearance.BorderSize = 0;
            btnComparativo.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnComparativo.FlatStyle = FlatStyle.Flat;
            btnComparativo.Font = new Font("Lato", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnComparativo.ForeColor = Color.Gainsboro;
            btnComparativo.Location = new Point(0, 56);
            btnComparativo.Name = "btnComparativo";
            btnComparativo.Size = new Size(200, 40);
            btnComparativo.TabIndex = 9;
            btnComparativo.Text = "Comparativo";
            btnComparativo.UseVisualStyleBackColor = true;
            btnComparativo.Click += btnComparativo_Click;
            // 
            // btnPrediccionActual
            // 
            btnPrediccionActual.FlatAppearance.BorderSize = 0;
            btnPrediccionActual.FlatAppearance.MouseOverBackColor = Color.DeepSkyBlue;
            btnPrediccionActual.FlatStyle = FlatStyle.Flat;
            btnPrediccionActual.Font = new Font("Lato", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrediccionActual.ForeColor = Color.Gainsboro;
            btnPrediccionActual.Location = new Point(0, 0);
            btnPrediccionActual.Name = "btnPrediccionActual";
            btnPrediccionActual.Size = new Size(200, 40);
            btnPrediccionActual.TabIndex = 8;
            btnPrediccionActual.Text = "Predicción actual";
            btnPrediccionActual.UseVisualStyleBackColor = true;
            btnPrediccionActual.Click += btnPrediccionActual_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 670);
            Controls.Add(pFormulariosHijos);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(pMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            pMenu.ResumeLayout(false);
            pFormulariosHijos.ResumeLayout(false);
            pFormulariosHijos.PerformLayout();
            pConfiguracion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pReportes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pMenu;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btnSalir;
        private Button btnGraficas;
        private Button btnReportes;
        private Button btnPredecir;
        private Button btnMinimizar;
        private Button btnMaximizar;
        private Button btnRestaurar;
        private Panel pFormulariosHijos;
        private Panel pReportes;
        private Button button6;
        private Button btnComparativo;
        private Button btnPrediccionActual;
        private Label label1;
        private PictureBox pictureBox1;
        private Button btnConfiguracion;
        private Panel pConfiguracion;
        private Button btnEntrenarModelo;
        private Button btnConfigServidor;
    }
}