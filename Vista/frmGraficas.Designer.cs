namespace SistemaParaPrediccionDeVentas.Vista
{
    partial class frmGraficas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGraficas));
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel5 = new Panel();
            label1 = new Label();
            btnMaximizar = new Button();
            btnRestaurar = new Button();
            btnCerrar = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            formsPlot1 = new ScottPlot.FormsPlot();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(78, 78, 78);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnMaximizar);
            panel1.Controls.Add(btnRestaurar);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 74);
            panel1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(842, 12);
            button3.Name = "button3";
            button3.Size = new Size(45, 45);
            button3.TabIndex = 18;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(227, 101, 113);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(223, 17, 3);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(893, 12);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 17;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(842, 12);
            button1.Name = "button1";
            button1.Size = new Size(45, 45);
            button1.TabIndex = 16;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel5.Location = new Point(6, 74);
            panel5.Name = "panel5";
            panel5.Size = new Size(1688, 446);
            panel5.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lato", 23.9999962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Gainsboro;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(135, 39);
            label1.TabIndex = 15;
            label1.Text = "Gráficas";
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.FlatAppearance.BorderSize = 0;
            btnMaximizar.FlatStyle = FlatStyle.Flat;
            btnMaximizar.Image = (Image)resources.GetObject("btnMaximizar.Image");
            btnMaximizar.Location = new Point(1592, 12);
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
            btnRestaurar.Location = new Point(1592, 12);
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
            btnCerrar.Location = new Point(1643, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(45, 45);
            btnCerrar.TabIndex = 11;
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(78, 78, 78);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 74);
            panel2.Name = "panel2";
            panel2.Size = new Size(6, 484);
            panel2.TabIndex = 4;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(78, 78, 78);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(944, 74);
            panel3.Name = "panel3";
            panel3.Size = new Size(6, 484);
            panel3.TabIndex = 5;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(78, 78, 78);
            panel4.Dock = DockStyle.Bottom;
            panel4.Location = new Point(6, 550);
            panel4.Name = "panel4";
            panel4.Size = new Size(938, 8);
            panel4.TabIndex = 6;
            // 
            // formsPlot1
            // 
            formsPlot1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            formsPlot1.ForeColor = SystemColors.ControlText;
            formsPlot1.Location = new Point(10, 80);
            formsPlot1.Margin = new Padding(4, 3, 4, 3);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(927, 464);
            formsPlot1.TabIndex = 7;
            // 
            // frmGraficas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(950, 558);
            Controls.Add(formsPlot1);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmGraficas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmGraficas";
            Load += frmGraficas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel5;
        private Label label1;
        private Button btnMaximizar;
        private Button btnRestaurar;
        private Button btnCerrar;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button button1;
        private Button button2;
        private ScottPlot.FormsPlot formsPlot1;
        private Button button3;
    }
}