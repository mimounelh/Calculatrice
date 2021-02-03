using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
            btnComa.Enabled = false;  //Pour le moment je desactive ce bouton
        }

        Calculatrice.CalculsDec calculsDec = new CalculsDec();

        private void btn7_Click(object sender, EventArgs e)
        {
            string actualNumber = ecranBox.Text;
            ecranBox.Text = actualNumber + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string actualNumber = ecranBox.Text;
            ecranBox.Text = actualNumber + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string actualNumber = ecranBox.Text;
            ecranBox.Text = actualNumber + "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string actualNumber = ecranBox.Text;
            ecranBox.Text = actualNumber + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string actualNumber = ecranBox.Text;
            ecranBox.Text = actualNumber + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string actualNumber = ecranBox.Text;
            ecranBox.Text = actualNumber + "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string actualNumber = ecranBox.Text;
            ecranBox.Text = actualNumber + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string actualNumber = ecranBox.Text;
            ecranBox.Text = actualNumber + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string actualNumber = ecranBox.Text;
            ecranBox.Text = actualNumber + "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            string actualNumber = ecranBox.Text;
            ecranBox.Text = actualNumber + "0";
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            ecranBox.Text = string.Empty;
            ecranBoxSup.Text = string.Empty;
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            string actualNumber = ecranBox.Text;
            ecranBox.Text = actualNumber + ".";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //<summary> Les types de calcul
        // typeDeCalcul = 1 = SOMME
        // typeDeCalcul = 2 = SUSTRACTION
        // typeDeCalcul = 3 = MULTIPLICATION
        // typeDeCalcul = 4 = DIVISION
        // calculDecimal = true or false;
        //</summary>
        public static int typeDeCalcul;  //Determine le type de calcul finale       
        public static int valeur; //celle ci represente la première valeur
        public double valeurDec; //Si la première valeur est decimale
        public double valeurDec2;
       

        public bool checkDec()  //Checker si c'est une valeur decimale
        {
            bool dec;
            string texte = ecranBox.Text;
            if (texte.Contains("."))
            {
                dec = true;
            }
            else
            {
                dec = false;
            }
            return dec;
        }

    

        #region somme
        public int somme()
        {
            int valeur = Convert.ToInt32(ecranBox.Text);           
            ecranBoxSup.Text = ecranBox.Text + " +";
            ecranBox.Text = string.Empty;
            typeDeCalcul = 1;
            return valeur;
        }

      

        public void sommePlus()
        {
            string nombreStr = ecranBox.Text;
            bool noInput = false;
            if(nombreStr == string.Empty)
            {
                noInput = true;
            }
            
            if(noInput == false)
            {
                int nombre = Convert.ToInt32(nombreStr);
                string nombre2Str = ecranBoxSup.Text.Remove(ecranBoxSup.Text.Length - 2);
                int nombre2 = Convert.ToInt32(nombre2Str);
                ecranBoxSup.Text = string.Empty;
                int somme = nombre + nombre2;
                string resultat = somme.ToString();
                ecranBox.Text = resultat;
                typeDeCalcul = 1;
            }         
        }

   

        public void sommeIntro(int value)
        {
            int somme = valeur + value;
            string resultat = somme.ToString();
            ecranBoxSup.Text = string.Empty;
            ecranBox.Text = resultat;
        }

   
        #endregion

        #region division
        public int division()
        {
            int valeur = Convert.ToInt32(ecranBox.Text);
            ecranBoxSup.Text = ecranBox.Text + " /";
            ecranBox.Text = string.Empty;
            typeDeCalcul = 4;
            return valeur;
        }

        public void divisionPlus()
        {
            string nombreStr = ecranBox.Text;
            bool noInput = false;
            if (nombreStr == string.Empty)
            {
                noInput = true;
            }
            if(noInput == false)
            {
                int nombre = Convert.ToInt32(nombreStr);
                string nombre2Str = ecranBoxSup.Text.Remove(ecranBoxSup.Text.Length - 2);
                int nombre2 = Convert.ToInt32(nombre2Str);
                ecranBoxSup.Text = string.Empty;
                int division = nombre2 / nombre;
                string resultat = division.ToString();
                typeDeCalcul = 4;
                ecranBox.Text = resultat;
            }          
        }

        public void divisionIntro(int value)
        {
            int somme = valeur / value;
            string resultat = somme.ToString();
            ecranBoxSup.Text = string.Empty;
            ecranBox.Text = resultat;
        }
        #endregion

        #region multiplication
        public int multiplication()
        {
            int valeur = Convert.ToInt32(ecranBox.Text);
            ecranBoxSup.Text = ecranBox.Text + " x";
            ecranBox.Text = string.Empty;
            typeDeCalcul = 3;
            return valeur;
        }

        public void multiplicationPlus()
        {
            string nombreStr = ecranBox.Text;
            bool noInput = false;
            if (nombreStr == string.Empty)
            {
                noInput = true;
            }
            if (noInput == false)
            {
                int nombre = Convert.ToInt32(nombreStr);
                string nombre2Str = ecranBoxSup.Text.Remove(ecranBoxSup.Text.Length - 2);
                int nombre2 = Convert.ToInt32(nombre2Str);
                ecranBoxSup.Text = string.Empty;
                int multiplication = nombre * nombre2;
                string resultat = multiplication.ToString();
                typeDeCalcul = 3;
                ecranBox.Text = resultat;
            }
            
        }

        public void multiplicationIntro(int value)
        {
            int somme = valeur * value;
            string resultat = somme.ToString();
            ecranBoxSup.Text = string.Empty;
            ecranBox.Text = resultat;
        }
        #endregion

        #region sustraction
        public int sustraction()
        {
            int valeur = Convert.ToInt32(ecranBox.Text);
            ecranBoxSup.Text = ecranBox.Text + " -";
            ecranBox.Text = string.Empty;
            typeDeCalcul = 2;
            return valeur;
        }

        public void sustractionPlus()
        {
            string nombreStr = ecranBox.Text;
            bool noInput = false;
            if (nombreStr == string.Empty)
            {
                noInput = true;
            }
            if (noInput == false)
            {
                int nombre = Convert.ToInt32(nombreStr);
                string nombre2Str = ecranBoxSup.Text.Remove(ecranBoxSup.Text.Length - 2);
                int nombre2 = Convert.ToInt32(nombre2Str);
                ecranBoxSup.Text = string.Empty;
                int sustraction = nombre2 - nombre;
                string resultat = sustraction.ToString();
                typeDeCalcul = 2;
                ecranBox.Text = resultat;
            }
            
        }

        public void sustractionIntro(int value)
        {
            int somme = valeur - value;
            string resultat = somme.ToString();
            ecranBoxSup.Text = string.Empty;
            ecranBox.Text = resultat;
        }
        #endregion

        #region boutons de calcul
        public void btnSomme_Click(object sender, EventArgs e)
        {
            bool checkDecimal = checkDec();

            if (ecranBoxSup.Text != string.Empty && checkDecimal == false )  
            {
                sommePlus();
            }
            
            if( ecranBoxSup.Text != string.Empty && checkDecimal == true)
            {
                //Ajouter la methode
            }
            
            if (ecranBox.Text != string.Empty && checkDecimal == false)
            {
                valeur = somme();
            }

            if (ecranBox.Text != string.Empty && checkDecimal == true)
            {
                valeurDec = double.Parse(ecranBox.Text);
                ecranBoxSup.Text = ecranBox.Text + " +";
                ecranBox.Text = string.Empty;
                typeDeCalcul = 1;
            }


        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            if (ecranBoxSup.Text != string.Empty)   
            {
                multiplicationPlus();
            }
            if (ecranBox.Text != string.Empty)
            {
                valeur = multiplication();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (ecranBoxSup.Text != string.Empty)
            {
                divisionPlus();
            }
            if (ecranBox.Text != string.Empty)
            {
                valeur = division();
            }
        }

        private void btnSus_Click(object sender, EventArgs e)
        {
            if (ecranBoxSup.Text != string.Empty)
            {
                sustractionPlus();
            }
            if (ecranBox.Text != string.Empty)
            {
                valeur = sustraction();
            }
        }
        #endregion

        private void BtnIntro_Click(object sender, EventArgs e)
        {
            if (ecranBox.Text == string.Empty)
            {
                ecranBox.Text = "0";
            }

            bool checkDecimal = checkDec();
            int valeur2 = 0;
            

            if (checkDecimal == false)
            {
                valeur2 = Convert.ToInt32(ecranBox.Text);
            }
            else
            {
                valeurDec2 = double.Parse(ecranBox.Text);
                string resultat = calculsDec.sommeDec(valeurDec, valeurDec2);
            }
                       
            
            if (valeur > 0 && typeDeCalcul == 1 && checkDecimal == false) //Pour la somme
            {
                sommeIntro(valeur2);
                checkDecimal = checkDec();
            }
            else if(valeur > 0 && typeDeCalcul == 3 && checkDecimal == false)  //Pour la multiplication
            {
                multiplicationIntro(valeur2);
            }
            else if (valeur > 0 && typeDeCalcul == 4 && checkDecimal == false)  //Pour la division
            {
                divisionIntro(valeur2);
            }
            else if (valeur > 0 && typeDeCalcul == 2 && checkDecimal == false)  //Pour la sustraction
            {
                sustractionIntro(valeur2);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)  //Info extra
        {
            MessageBox.Show("Calculatrice faite par Mimoun,\nélève de Terminale au lycée de l'arc 2021", "Infomation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #region Pour déplacer la fenetre
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();


        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void ControlPanel_paint(object sender, PaintEventArgs e)
        {

        }
        private void ControlPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion
    }
}
