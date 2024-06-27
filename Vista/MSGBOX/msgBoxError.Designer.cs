namespace SistemaParaPrediccionDeVentas.Vista.MSGBOX
{
    partial class msgBoxError
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(msgBoxError));
            label1 = new Label();
            btnOk = new Button();
            txtMensaje = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(50, 50);
            label1.TabIndex = 13;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.FromArgb(74, 87, 108);
            btnOk.FlatAppearance.BorderColor = Color.FromArgb(17, 31, 52);
            btnOk.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 31, 52);
            btnOk.FlatAppearance.MouseOverBackColor = Color.FromArgb(51, 62, 80);
            btnOk.FlatStyle = FlatStyle.Flat;
            btnOk.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOk.ForeColor = Color.White;
            btnOk.Location = new Point(106, 99);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 40);
            btnOk.TabIndex = 15;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(68, 9);
            txtMensaje.Multiline = true;
            txtMensaje.Name = "txtMensaje";
            txtMensaje.ScrollBars = ScrollBars.Vertical;
            txtMensaje.Size = new Size(226, 72);
            txtMensaje.TabIndex = 16;
            txtMensaje.Text = "Mensaje";
            // 
            // msgBoxError
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(306, 151);
            ControlBox = false;
            Controls.Add(txtMensaje);
            Controls.Add(btnOk);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "msgBoxError";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "msgBoxError";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnOk;
        public TextBox txtMensaje;
    }
}