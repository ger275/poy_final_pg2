namespace SistemaParaPrediccionDeVentas.Vista.MSGBOX
{
    partial class msgCargando
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
            btnOk = new Button();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            SuspendLayout();
            // 
            // btnOk
            // 
            btnOk.Location = new Point(219, 73);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(75, 23);
            btnOk.TabIndex = 20;
            btnOk.Text = "OK";
            btnOk.UseVisualStyleBackColor = true;
            btnOk.Visible = false;
            btnOk.Click += btnOk_Click;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Location = new Point(1, 47);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(304, 23);
            lblSubtitulo.TabIndex = 21;
            lblSubtitulo.Text = "Espere por favor.";
            lblSubtitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(-1, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(306, 38);
            lblTitulo.TabIndex = 22;
            lblTitulo.Text = "mensaje";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // msgCargando
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(306, 85);
            ControlBox = false;
            Controls.Add(lblTitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(btnOk);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "msgCargando";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
        }

        #endregion
        public Button btnOk;
        public Label lblSubtitulo;
        public Label lblTitulo;
    }
}