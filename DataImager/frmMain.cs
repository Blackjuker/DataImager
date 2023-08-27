using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataImager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void picLinkedIn_Click(object sender, EventArgs e)
        {

            string url = "https://www.linkedin.com/in/arnaud-ngabgna-6247b5238/";  // Remplacez ceci par l'URL que vous souhaitez ouvrir

            // Utilisation de Process.Start pour ouvrir l'URL dans le navigateur par défaut
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur s'est produite : " + ex.Message);
            }
        }

        private void picGitHub_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/Blackjuker";  // Remplacez ceci par l'URL que vous souhaitez ouvrir

            // Utilisation de Process.Start pour ouvrir l'URL dans le navigateur par défaut
            try
            {
                Process.Start(url);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur s'est produite : " + ex.Message);
            }
        }
    }
}
