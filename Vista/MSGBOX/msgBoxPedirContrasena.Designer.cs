namespace SistemaParaPrediccionDeVentas.Vista.MSGBOX
{
    partial class msgBoxPedirContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(msgBoxPedirContrasena));
            label1 = new Label();
            lblMensaje = new Label();
            btnSi = new Button();
            btnNo = new Button();
            txtContrasena = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 50);
            label1.TabIndex = 12;
            // 
            // lblMensaje
            // 
            lblMensaje.CausesValidation = false;
            lblMensaje.Location = new Point(68, 9);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(226, 44);
            lblMensaje.TabIndex = 13;
            lblMensaje.Text = "Mensaje";
            // 
            // btnSi
            // 
            btnSi.BackColor = Color.FromArgb(104, 116, 135);
            btnSi.FlatAppearance.BorderColor = Color.FromArgb(17, 31, 52);
            btnSi.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 31, 52);
            btnSi.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 62, 80);
            btnSi.FlatStyle = FlatStyle.Flat;
            btnSi.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSi.ForeColor = Color.White;
            btnSi.Location = new Point(38, 98);
            btnSi.Name = "btnSi";
            btnSi.Size = new Size(100, 40);
            btnSi.TabIndex = 14;
            btnSi.Text = "Aceptar";
            btnSi.UseVisualStyleBackColor = false;
            btnSi.Click += btnSi_Click;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.FromArgb(74, 87, 108);
            btnNo.FlatAppearance.BorderColor = Color.FromArgb(17, 31, 52);
            btnNo.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 31, 52);
            btnNo.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 62, 80);
            btnNo.FlatStyle = FlatStyle.Flat;
            btnNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNo.ForeColor = Color.White;
            btnNo.Location = new Point(164, 98);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(100, 40);
            btnNo.TabIndex = 15;
            btnNo.Text = "Cancelar";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(68, 61);
            txtContrasena.Multiline = true;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(173, 25);
            txtContrasena.TabIndex = 16;
            txtContrasena.TextAlign = HorizontalAlignment.Center;
            // 
            // msgBoxPedirContrasena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(306, 151);
            ControlBox = false;
            Controls.Add(txtContrasena);
            Controls.Add(btnNo);
            Controls.Add(btnSi);
            Controls.Add(lblMensaje);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "msgBoxPedirContrasena";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "msgBoxPedirContrasena";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public Label lblMensaje;
        private Button btnSi;
        private Button btnNo;
        public TextBox txtContrasena;
    }
}