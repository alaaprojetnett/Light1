namespace LightShadowGame
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.panelBottom = new System.Windows.Forms.FlowLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.Lumiere = new System.Windows.Forms.PictureBox();
			this.Ombre = new System.Windows.Forms.PictureBox();
			this.GameTimer = new System.Windows.Forms.Timer(this.components);
			this.panelMid = new System.Windows.Forms.Panel();
			this.panel5 = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Lumiere)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Ombre)).BeginInit();
			this.SuspendLayout();
			// 
			// panelBottom
			// 
			this.panelBottom.BackColor = System.Drawing.Color.Silver;
			this.panelBottom.Location = new System.Drawing.Point(0, 621);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new System.Drawing.Size(1257, 50);
			this.panelBottom.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Location = new System.Drawing.Point(0, 407);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(988, 63);
			this.panel1.TabIndex = 2;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Silver;
			this.panel2.Controls.Add(this.flowLayoutPanel7);
			this.panel2.Location = new System.Drawing.Point(181, 255);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1076, 61);
			this.panel2.TabIndex = 3;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Silver;
			this.panel3.Location = new System.Drawing.Point(270, 97);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(706, 63);
			this.panel3.TabIndex = 4;
			this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
			// 
			// Lumiere
			// 
			this.Lumiere.BackColor = System.Drawing.Color.White;
			this.Lumiere.Location = new System.Drawing.Point(0, 583);
			this.Lumiere.Name = "Lumiere";
			this.Lumiere.Size = new System.Drawing.Size(40, 40);
			this.Lumiere.TabIndex = 7;
			this.Lumiere.TabStop = false;
			this.Lumiere.Click += new System.EventHandler(this.Lumiere_Click);
			// 
			// Ombre
			// 
			this.Ombre.BackColor = System.Drawing.Color.Black;
			this.Ombre.Location = new System.Drawing.Point(0, 489);
			this.Ombre.Name = "Ombre";
			this.Ombre.Size = new System.Drawing.Size(40, 40);
			this.Ombre.TabIndex = 8;
			this.Ombre.TabStop = false;
			// 
			// GameTimer
			// 
			this.GameTimer.Enabled = true;
			this.GameTimer.Interval = 20;
			this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
			// 
			// panelMid
			// 
			this.panelMid.BackColor = System.Drawing.Color.Silver;
			this.panelMid.Location = new System.Drawing.Point(0, 526);
			this.panelMid.Name = "panelMid";
			this.panelMid.Size = new System.Drawing.Size(235, 51);
			this.panelMid.TabIndex = 9;
			// 
			// panel5
			// 
			this.panel5.BackColor = System.Drawing.Color.Silver;
			this.panel5.Location = new System.Drawing.Point(1088, 512);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(169, 111);
			this.panel5.TabIndex = 10;
			this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.panel5_Paint);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(938, 248);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(69, 68);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.BackColor = System.Drawing.Color.Black;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(338, 248);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(73, 68);
			this.flowLayoutPanel2.TabIndex = 0;
			this.flowLayoutPanel2.Tag = "Noir";
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.BackColor = System.Drawing.Color.White;
			this.flowLayoutPanel3.Location = new System.Drawing.Point(225, 402);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(73, 68);
			this.flowLayoutPanel3.TabIndex = 1;
			this.flowLayoutPanel3.Tag = "Blanc";
			// 
			// flowLayoutPanel4
			// 
			this.flowLayoutPanel4.BackColor = System.Drawing.Color.Black;
			this.flowLayoutPanel4.Location = new System.Drawing.Point(744, 402);
			this.flowLayoutPanel4.Name = "flowLayoutPanel4";
			this.flowLayoutPanel4.Size = new System.Drawing.Size(73, 68);
			this.flowLayoutPanel4.TabIndex = 1;
			this.flowLayoutPanel4.Tag = "Noir";
			// 
			// flowLayoutPanel5
			// 
			this.flowLayoutPanel5.BackColor = System.Drawing.Color.Black;
			this.flowLayoutPanel5.Location = new System.Drawing.Point(424, 609);
			this.flowLayoutPanel5.Name = "flowLayoutPanel5";
			this.flowLayoutPanel5.Size = new System.Drawing.Size(73, 62);
			this.flowLayoutPanel5.TabIndex = 1;
			this.flowLayoutPanel5.Tag = "Noir";
			// 
			// flowLayoutPanel6
			// 
			this.flowLayoutPanel6.BackColor = System.Drawing.Color.White;
			this.flowLayoutPanel6.Location = new System.Drawing.Point(810, 609);
			this.flowLayoutPanel6.Name = "flowLayoutPanel6";
			this.flowLayoutPanel6.Size = new System.Drawing.Size(73, 62);
			this.flowLayoutPanel6.TabIndex = 11;
			this.flowLayoutPanel6.Tag = "Blanc";
			// 
			// flowLayoutPanel7
			// 
			this.flowLayoutPanel7.BackColor = System.Drawing.Color.Gray;
			this.flowLayoutPanel7.Location = new System.Drawing.Point(447, -4);
			this.flowLayoutPanel7.Name = "flowLayoutPanel7";
			this.flowLayoutPanel7.Size = new System.Drawing.Size(128, 65);
			this.flowLayoutPanel7.TabIndex = 1;
			this.flowLayoutPanel7.Tag = "Gris";
			// 
			// flowLayoutPanel8
			// 
			this.flowLayoutPanel8.BackColor = System.Drawing.Color.Gray;
			this.flowLayoutPanel8.Location = new System.Drawing.Point(470, 402);
			this.flowLayoutPanel8.Name = "flowLayoutPanel8";
			this.flowLayoutPanel8.Size = new System.Drawing.Size(128, 68);
			this.flowLayoutPanel8.TabIndex = 1;
			this.flowLayoutPanel8.Tag = "Gris";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.MenuBar;
			this.ClientSize = new System.Drawing.Size(1253, 671);
			this.Controls.Add(this.flowLayoutPanel8);
			this.Controls.Add(this.flowLayoutPanel6);
			this.Controls.Add(this.flowLayoutPanel5);
			this.Controls.Add(this.flowLayoutPanel4);
			this.Controls.Add(this.flowLayoutPanel3);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.flowLayoutPanel2);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panelMid);
			this.Controls.Add(this.Ombre);
			this.Controls.Add(this.Lumiere);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelBottom);
			this.KeyPreview = true;
			this.Name = "Form1";
			this.Text = "Light and Shadow Duo ";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Lumiere)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Ombre)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel panelBottom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox Ombre;
        private System.Windows.Forms.PictureBox Lumiere;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Panel panelMid;
        private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel8;
	}
}

