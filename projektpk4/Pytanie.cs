using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

namespace projektpk4
{
    internal class Pytanie
    {
        string pytanie;
        string OdpA;
        string OdpB;
        string OdpC;
        string OdpD;
        string OdpPrawidlowa;




        static public void przypisanie()
        {
         string file = "E:\\Proejkt\\projektpk4\\projektpk4\\Quiz.txt";
         string filetext=Czytnik.Czytaj(file);
         int n = 0;
         Regex r= new Regex("(@)");


            string[] lines = filetext.Split('\n');

            foreach (string line in lines)
            {
                MessageBox.Show(line);
                
            }

           // MessageBox.Show(filetext+1);

        }

    }
}
