using System;
using System.Data;
using System.Windows.Forms;

namespace frmCalculette
{
    public partial class Form1 : Form
    {
        // Indique si un nouveau calcul doit commencer après avoir cliqué sur "="
        private bool estNouveauCalcul = false;

        public Form1()
        {
            InitializeComponent();
        }

        // ===================== GESTION DES OPERATEURS =====================
        private void AjouterOperateur(string op)
        {
            if (estNouveauCalcul)
                estNouveauCalcul = false;

            // Récupère le dernier caractère affiché
            char dernierCaractere = txtResult.Text[txtResult.Text.Length - 1];

            // Empêche d'ajouter deux opérateurs successifs (+ - × ÷)
            if ("+-×÷".Contains(dernierCaractere.ToString()))
                return;

            // Ajoute l'opérateur à l'affichage
            txtResult.Text += op;
        }

        // ===================== CHARGEMENT DU FORMULAIRE =====================
        private void Form1_Load(object sender, EventArgs e)
        {
            // Valeur initiale affichée
            txtResult.Text = "0";
        }

        // ===================== BOUTON QUITTER =====================
        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // pour  Ferme l'application
        }

        // ===================== les  CHIFFRES =====================
        private void AfficherChiffre(object sender, EventArgs e)
        {
            // Si l'affichage est "0" ou après un calcul, on réinitialise
            if (txtResult.Text == "0" || estNouveauCalcul)
            {
                txtResult.Clear();
                estNouveauCalcul = false;
            }

            // Récupère le bouton cliqué
            Button btn = (Button)sender;

            // Ajoute le chiffre à l'affichage
            txtResult.Text += btn.Text;
        }

        private void bnt0_Click(object sender, EventArgs e) { AfficherChiffre(sender, e); }
        private void bnt1_Click(object sender, EventArgs e) { AfficherChiffre(sender, e); }
        private void btn2_Click(object sender, EventArgs e) { AfficherChiffre(sender, e); }
        private void bnt3_Click(object sender, EventArgs e) { AfficherChiffre(sender, e); }
        private void bnt4_Click(object sender, EventArgs e) { AfficherChiffre(sender, e); }
        private void bnt5_Click(object sender, EventArgs e) { AfficherChiffre(sender, e); }
        private void bnt6_Click(object sender, EventArgs e) { AfficherChiffre(sender, e); }
        private void btn7_Click(object sender, EventArgs e) { AfficherChiffre(sender, e); }
        private void bnt8_Click(object sender, EventArgs e) { AfficherChiffre(sender, e); }
        private void bnt9_Click(object sender, EventArgs e) { AfficherChiffre(sender, e); }



        // ===================== VIRGULE =====================
        private void bntVigule_Click(object sender, EventArgs e)
        {
            // Si nouveau calcul, commencer par 0,
            if (estNouveauCalcul)
            {
                txtResult.Text = "0,";
                estNouveauCalcul = false;
                return;
            }

            // Ajoute la virgule
            txtResult.Text += ",";
        }

        // =====================Les  OPERATEURS =====================
        private void bntPlus_Click(object sender, EventArgs e)
        {
            AjouterOperateur("+");
        }

        private void bntMoin_Click(object sender, EventArgs e)
        {
            AjouterOperateur("-");
        }

        private void bntProduit_Click(object sender, EventArgs e)
        {
            AjouterOperateur("×");
        }

        private void bntDivision_Click(object sender, EventArgs e)
        {
            AjouterOperateur("÷");
        }

        // ===================== EGAL =====================
        private void bntEgale_Click(object sender, EventArgs e)
        {
            try
            {
                // Récupère l'expression saisie
                string expression = txtResult.Text;

                // Remplace les symboles pour que DataTable puisse calculer
                expression = expression.Replace("×", "*");
                expression = expression.Replace("÷", "/");
                expression = expression.Replace(",", ".");

                // Utilise DataTable pour calculer l'expression
                DataTable table = new DataTable();
                object resultat = table.Compute(expression, "");

                // Affiche le résultat
                txtResult.Text = Convert.ToDouble(resultat).ToString();

                // Indique qu'un nouveau calcul peut commencer
                estNouveauCalcul = true;
            }
            catch
            {
                MessageBox.Show("Expression invalide", "Erreur");
                txtResult.Text = "0";
            }
        }

        // ===================== le bouton AC =====================
        private void button1_Click(object sender, EventArgs e) // C
        {
            // Réinitialise complètement l'affichage
            txtResult.Text = "0";
            estNouveauCalcul = false;
        }

        private void button2_Click(object sender, EventArgs e) // CE
        {
            // Supprime le dernier caractère
            if (txtResult.Text.Length > 1)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
            else
            {
                // Si un seul caractère reste, afficher 0
                txtResult.Text = "0";
            }
        }

        // ===================== DELETE ONE =====================
        private void bntDeleteOne_Click(object sender, EventArgs e)
        {
            // Supprimer une a une 
            if (txtResult.Text.Length > 1)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
            else
            {
                txtResult.Text = "0";
            }
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {
        }
    }
}










//Cours C# n*4

//Formulaire MBA: Formulaire qui s'ouvre a partir d'un outre formulaire 

//introduction general:
//-contexte: 
//-problematique: 
//-objectif: 

//analyse et realisation:
//-Methologie et outils
//*Metodologie : Comment s'organiser


//ORM ( Object Relationnel Mapping )