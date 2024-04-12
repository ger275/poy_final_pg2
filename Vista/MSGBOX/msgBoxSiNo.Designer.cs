namespace SistemaParaPrediccionDeVentas.Vista.MSGBOX
{
    partial class msgBoxSiNo
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
            btnSi = new Button();
            btnNo = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            lblTitulo = new Label();
            panel4 = new Panel();
            lblMensaje = new Label();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // btnSi
            // 
            btnSi.BackColor = Color.FromArgb(104, 116, 135);
            btnSi.FlatAppearance.BorderColor = Color.FromArgb(17, 31, 52);
            btnSi.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 31, 52);
            btnSi.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 62, 80);
            btnSi.FlatStyle = FlatStyle.Flat;
            btnSi.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSi.ForeColor = Color.FromArgb(200, 207, 219);
            btnSi.Location = new Point(57, 114);
            btnSi.Name = "btnSi";
            btnSi.Size = new Size(100, 40);
            btnSi.TabIndex = 4;
            btnSi.Text = "Sí";
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
            btnNo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNo.ForeColor = Color.FromArgb(200, 207, 219);
            btnNo.Location = new Point(181, 114);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(100, 40);
            btnNo.TabIndex = 5;
            btnNo.Text = "No";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += btnNo_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(17, 31, 52);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(6, 188);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(17, 31, 52);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(330, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(6, 188);
            panel2.TabIndex = 7;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(17, 31, 52);
            panel3.Controls.Add(lblTitulo);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(6, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(324, 49);
            panel3.TabIndex = 8;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.ForeColor = Color.FromArgb(200, 207, 219);
            lblTitulo.Location = new Point(6, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(312, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Titulo";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(17, 31, 52);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(6, 182);
            panel4.Name = "panel4";
            panel4.Size = new Size(324, 6);
            panel4.TabIndex = 9;
            // 
            // lblMensaje
            // 
            lblMensaje.CausesValidation = false;
            lblMensaje.Location = new Point(12, 52);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(312, 59);
            lblMensaje.TabIndex = 10;
            lblMensaje.Text = "Mensaje";
            // 
            // msgBoxSiNo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(336, 188);
            Controls.Add(lblMensaje);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnNo);
            Controls.Add(btnSi);
            FormBorderStyle = FormBorderStyle.None;
            Name = "msgBoxSiNo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "msgBoxSiNo";
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnSi;
        private Button btnNo;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        public Label lblTitulo;
        public Label lblMensaje;
    }
}