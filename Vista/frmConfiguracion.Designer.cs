namespace SistemaParaPrediccionDeVentas.Vista
{
    partial class frmConfiguracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracion));
            panelTitulo = new Panel();
            button2 = new Button();
            panel5 = new Panel();
            label1 = new Label();
            btnMaximizar = new Button();
            btnRestaurar = new Button();
            btnCerrar = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            txtHost = new TextBox();
            txtUsuario = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtContrasena = new TextBox();
            label4 = new Label();
            cmbServidor = new ComboBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            txtPuerto = new TextBox();
            label7 = new Label();
            btnGuardar = new Button();
            btnModificar = new Button();
            btnCancelar = new Button();
            panelTitulo.SuspendLayout();
            SuspendLayout();
            // 
            // panelTitulo
            // 
            panelTitulo.BackColor = Color.FromArgb(74, 87, 108);
            panelTitulo.Controls.Add(button2);
            panelTitulo.Controls.Add(panel5);
            panelTitulo.Controls.Add(label1);
            panelTitulo.Controls.Add(btnMaximizar);
            panelTitulo.Controls.Add(btnRestaurar);
            panelTitulo.Controls.Add(btnCerrar);
            panelTitulo.Dock = DockStyle.Top;
            panelTitulo.Location = new Point(0, 0);
            panelTitulo.Name = "panelTitulo";
            panelTitulo.Size = new Size(391, 74);
            panelTitulo.TabIndex = 3;
            panelTitulo.MouseDown += panelTitulo_MouseDown;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(227, 101, 113);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 17, 3);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(334, 12);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 17;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Location = new Point(6, 74);
            panel5.Name = "panel5";
            panel5.Size = new Size(1129, 446);
            panel5.TabIndex = 6;
            // 
            // label1
            // 
            label1.Font = new Font("Lato", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(170, 40);
            label1.TabIndex = 15;
            label1.Text = "Servidor";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1033, 12);
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
            btnRestaurar.Location = new Point(1033, 12);
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
            btnCerrar.Location = new Point(1084, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(45, 45);
            btnCerrar.TabIndex = 11;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(74, 87, 108);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(6, 351);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(74, 87, 108);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(385, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(6, 351);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(74, 87, 108);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(6, 417);
            panel4.Name = "panel4";
            panel4.Size = new Size(379, 8);
            panel4.TabIndex = 6;
            // 
            // txtHost
            // 
            txtHost.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtHost.Location = new Point(119, 131);
            txtHost.MaxLength = 200;
            txtHost.Multiline = true;
            txtHost.Name = "txtHost";
            txtHost.Size = new Size(220, 28);
            txtHost.TabIndex = 7;
            txtHost.Text = "127.0.0.1";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsuario.Location = new Point(119, 199);
            txtUsuario.Multiline = true;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(220, 28);
            txtUsuario.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(73, 131);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 9;
            label2.Text = "Host";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(30, 233);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 10;
            label3.Text = "Contraseña";
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtContrasena.Location = new Point(119, 233);
            txtContrasena.Multiline = true;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(220, 28);
            txtContrasena.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(54, 199);
            label4.Name = "label4";
            label4.Size = new Size(59, 20);
            label4.TabIndex = 12;
            label4.Text = "Usuario";
            // 
            // cmbServidor
            // 
            cmbServidor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServidor.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbServidor.FormattingEnabled = true;
            cmbServidor.Location = new Point(119, 97);
            cmbServidor.Name = "cmbServidor";
            cmbServidor.Size = new Size(220, 28);
            cmbServidor.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(49, 100);
            label5.Name = "label5";
            label5.Size = new Size(64, 20);
            label5.TabIndex = 14;
            label5.Text = "Servidor";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(119, 267);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(220, 28);
            textBox4.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(47, 267);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 16;
            label6.Text = "Consulta";
            // 
            // txtPuerto
            // 
            txtPuerto.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPuerto.Location = new Point(119, 165);
            txtPuerto.MaxLength = 200;
            txtPuerto.Multiline = true;
            txtPuerto.Name = "txtPuerto";
            txtPuerto.Size = new Size(220, 28);
            txtPuerto.TabIndex = 17;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(61, 168);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 18;
            label7.Text = "Puerto";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(74, 87, 108);
            btnGuardar.FlatAppearance.BorderColor = Color.FromArgb(17, 31, 52);
            btnGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 31, 52);
            btnGuardar.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 62, 80);
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnGuardar.ForeColor = Color.Gainsboro;
            btnGuardar.Image = (Image)resources.GetObject("btnGuardar.Image");
            btnGuardar.ImageAlign = ContentAlignment.TopCenter;
            btnGuardar.Location = new Point(20, 344);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 50);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.BottomCenter;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.FromArgb(74, 87, 108);
            btnModificar.FlatAppearance.BorderColor = Color.FromArgb(17, 31, 52);
            btnModificar.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 31, 52);
            btnModificar.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 62, 80);
            btnModificar.FlatStyle = FlatStyle.Flat;
            btnModificar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnModificar.ForeColor = Color.White;
            btnModificar.Image = (Image)resources.GetObject("btnModificar.Image");
            btnModificar.ImageAlign = ContentAlignment.TopCenter;
            btnModificar.Location = new Point(139, 344);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(100, 50);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "Modificar";
            btnModificar.TextAlign = ContentAlignment.BottomCenter;
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(74, 87, 108);
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(17, 31, 52);
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 31, 52);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 62, 80);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Image = (Image)resources.GetObject("btnCancelar.Image");
            btnCancelar.ImageAlign = ContentAlignment.TopCenter;
            btnCancelar.Location = new Point(255, 344);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 50);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.BottomCenter;
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // frmConfiguracion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(104, 116, 135);
            ClientSize = new Size(391, 425);
            Controls.Add(btnCancelar);
            Controls.Add(btnModificar);
            Controls.Add(btnGuardar);
            Controls.Add(label7);
            Controls.Add(txtPuerto);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(cmbServidor);
            Controls.Add(label4);
            Controls.Add(txtContrasena);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(txtHost);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panelTitulo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmConfiguracion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmConfiguracion";
            Load += frmConfiguracion_Load;
            panelTitulo.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTitulo;
        private Panel panel5;
        private Label label1;
        private Button btnMaximizar;
        private Button btnRestaurar;
        private Button btnCerrar;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button2;
        private TextBox txtHost;
        private TextBox txtUsuario;
        private Label label2;
        private Label label3;
        private TextBox txtContrasena;
        private Label label4;
        private ComboBox cmbServidor;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox txtPuerto;
        private Label label7;
        private Button btnGuardar;
        private Button btnModificar;
        private Button btnCancelar;
    }
}