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
    public partial class frmSplash : Form
    {
        Random ran = new Random();
        bool isLinkOpen = false;

        public frmSplash()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                new frmMain().Show();
                return;
            }
            try
            {
                progressBar.Value += ran.Next(1, 10);
            }catch(Exception ex)
            {
                timer1.Stop();
                this.Hide();
                new frmMain().Show();
            }
                
          
        }

        private void Form1_Click(object sender, EventArgs e)
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

        private void frmSplash_FormClosed(object sender, FormClosedEventArgs e)
        {
            new frmMain().Show();
        }
    }
}
