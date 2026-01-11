using System;
using System.Data;
using System.Windows.Forms;

namespace frmCalculette
{
    public partial class Form1 : Form
    {
        private bool estNouveauCalcul = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void AjouterOperateur(string op)
        {
            if (estNouveauCalcul)
                estNouveauCalcul = false;

            char dernierCaractere = txtResult.Text[txtResult.Text.Length - 1];

            if ("+-×÷".Contains(dernierCaractere.ToString()))
                return;

            txtResult.Text += op;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // ===================== CHIFFRES =====================
        private void AfficherChiffre(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || estNouveauCalcul)
            {
                txtResult.Clear();
                estNouveauCalcul = false;
            }

            Button btn = (Button)sender;
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
           
        }

        // ===================== OPERATEURS =====================
        

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
                string expression = txtResult.Text;
                expression = expression.Replace("×", "*");
                expression = expression.Replace("÷", "/");
                expression = expression.Replace(",", ".");

                DataTable table = new DataTable();
                object resultat = table.Compute(expression, "");

                txtResult.Text = Convert.ToDouble(resultat).ToString();
                estNouveauCalcul = true;
            }
            catch
            {
                MessageBox.Show("Expression invalide", "Erreur");
                txtResult.Text = "0";
            }
        }

        // ===================== CLEAR =====================
        private void button1_Click(object sender, EventArgs e) // C
        {

        }

        private void button2_Click(object sender, EventArgs e) // CE
        {
        }

        // ===================== DELETE ONE =====================
        private void bntDeleteOne_Click(object sender, EventArgs e)
        {
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





