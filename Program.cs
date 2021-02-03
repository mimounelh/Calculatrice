using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BaseForm());
        }
    }

    public class CalculsDec
    {
        public double valueDec;
        public string sommeDec(double val1 , double val2)
        {
            double somme = val1 + val2;
            string resultat = somme.ToString();
            return resultat;
        }
    }
}
