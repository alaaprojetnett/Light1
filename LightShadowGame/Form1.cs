using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightShadowGame
{
    public partial class Form1 : Form
    {
        // =========================
        // VARIABLES
        // =========================
        bool goLeft1, goRight1, jumping1;
        bool goLeft2, goRight2, jumping2;

        bool controlLumiere = true;
		bool lumierePasse = false;
		int speed = 5;
        int jumpSpeed1 = 0;
        int jumpSpeed2 = 0;
        private int gravity = 1;

        // =========================
        // CONSTRUCTEUR
        // =========================
        public Form1()
        {
            InitializeComponent();
        }

        // =========================
        // GAME LOOP
        // =========================
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            // --- LUMIÈRE ---
            Lumiere.Top += jumpSpeed1;
            jumpSpeed1 += gravity;

            if (Lumiere.Top >= panelBottom.Top - Lumiere.Height)
            {
                Lumiere.Top = panelBottom.Top - Lumiere.Height;
                jumpSpeed1 = 0;
                jumping1 = false;
            }

            // --- OMBRE ---
            bool onMidPlatform =
                Ombre.Right > panelMid.Left &&
                Ombre.Left < panelMid.Right;

            Ombre.Top += jumpSpeed2;
            jumpSpeed2 += gravity;

            if (onMidPlatform &&
                Ombre.Bottom >= panelMid.Top &&
                Ombre.Top < panelMid.Top &&
                jumpSpeed2 >= 0)
            {
                Ombre.Top = panelMid.Top - Ombre.Height;
                jumpSpeed2 = 0;
                jumping2 = false;
            }
            else if (Ombre.Bottom >= panelBottom.Top)
            {
                Ombre.Top = panelBottom.Top - Ombre.Height;
                jumpSpeed2 = 0;
                jumping2 = false;
            }

            // --- VÉRIFICATION ---
            VerificationZones();
        }

        // =========================
        // VÉRIFICATION DES ZONES
        // =========================
        private void VerificationZones()
        {
            foreach (Control x in this.Controls)
            {
                if (x is Panel && x.Tag != null)
                {
                    string tag = x.Tag.ToString();

                    // Lumière sur Noir
                    if (Lumiere.Bounds.IntersectsWith(x.Bounds) && tag == "Noir")
                    {
                        if (!jumping1)
                        {
                            GameOver("La Lumière a touché une zone d'ombre !");
                        }
                    }

                    // Ombre sur Blanc
                    if (Ombre.Bounds.IntersectsWith(x.Bounds) && tag == "Blanc")
                    {
                        if (!jumping2)
                        {
                            GameOver("L'Ombre a touché une zone de lumière !");
                        }
                    }

					// Zone Grise (mort directe)
					// Zone Grise (brouillard — séquence obligatoire)
					if (tag == "Gris")
					{
						// Lumière traverse la zone grise → elle est passée
						if (Lumiere.Bounds.IntersectsWith(x.Bounds))
						{
							lumierePasse = true; // on note qu'elle est passée
						}

						// Ombre tente de traverser la zone grise
						if (Ombre.Bounds.IntersectsWith(x.Bounds))
						{
							if (!lumierePasse)
							{
								// Ombre passe avant Lumière → défaite
								GameOver("L'Ombre a sauté avant La Lumière dans le brouillard !");
							}
							else
							{
								// Ombre passe après Lumière → on remet à false pour la prochaine zone
								lumierePasse = false;
							}
						}
					}
				}
            }
        }

        // =========================
        // GAME OVER
        // =========================
        private void GameOver(string message)
        {
            GameTimer.Stop();
            MessageBox.Show(message + "\nCliquez sur OK pour recommencer.");
            Application.Restart();
        }

        // =========================
        // INPUT CLAVIER
        // =========================
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (controlLumiere)
            {
                if (e.KeyCode == Keys.Left) Lumiere.Left -= 10;
                if (e.KeyCode == Keys.Right) Lumiere.Left += 10;

                if (e.KeyCode == Keys.Up && !jumping1)
                {
                    jumping1 = true;
                    jumpSpeed1 = -15;
                }
            }
            else
            {
                if (e.KeyCode == Keys.Left) Ombre.Left -= 10;
                if (e.KeyCode == Keys.Right) Ombre.Left += 10;

                if (e.KeyCode == Keys.Up && !jumping2)
                {
                    jumping2 = true;
                    jumpSpeed2 = -15;
                }
            }

            // Switch personnage
            if (e.KeyCode == Keys.Tab)
            {
                controlLumiere = !controlLumiere;
            }
        }

        // =========================
        // LOAD
        // =========================
        private void Form1_Load(object sender, EventArgs e)
        {
            Lumiere.Top = panelBottom.Top - Lumiere.Height;
            Ombre.Top = panelMid.Top - Ombre.Height;
        }

		// =========================
		// EVENTS VIDES
		// =========================
		private void Lumiere_Click(object sender, EventArgs e)
		{
		}
		private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel3_Paint(object sender, PaintEventArgs e) { }
        private void panel5_Paint(object sender, PaintEventArgs e) { }
    }
}
