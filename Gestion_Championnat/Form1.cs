using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Championnat
{
    public partial class Form1 : FormBase
    {
        public Form1()
        {
            InitializeComponent();
            //Arbitre arb = new Arbitre();
            //Joueur jou = new Joueur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string equipe = textBox1.Text;
            //string ville = textBox2.Text;
            //string stade = textBox3.Text;
            //string Nomjoueur = textBox4.Text;
            //string NomEntraineur = textBox5.Text;

            //Equipe monEquipe = new Equipe(equipe, ville, stade);
            //Joueur monJoueur = new Joueur(Nomjoueur);
            //monEquipe.addJoueur(monJoueur);
            //monEquipe.entraineur = new Entraineur(NomEntraineur);
            Form2 CreerChampionnatForm = new Form2();
            CreerChampionnatForm.Show();
        }
    }
}
