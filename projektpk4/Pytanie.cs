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


        public Pytanie(string pytaniee,string Odpa, string Odpb, string Odpc, string Odpd, string Odpprawidlowa)
            {
             pytanie =pytaniee;
             OdpA = Odpa;
             OdpB = Odpb;
             OdpC = Odpc;
             OdpD = Odpd;
             OdpPrawidlowa = Odpprawidlowa;
        }

        static public void Quiz_List()
        {
         string A, B, C, D, Quest,Answer="";
         string file = "C:\\Users\\Miłosz\\Desktop\\PK4\\projekt\\projektpk4\\Quiz.txt";
         string filetext=Czytnik.Czytaj(file);

         string pattern = "#";
         Regex regex = new Regex(pattern);
         

            string[] lines = filetext.Split('\n'); // pętla przypisująca pytania i odp

            for (int n =0;n<lines.Length;n++)
            {
          
                 if(regex.IsMatch(lines[n]))
                {
                   Answer=regex.Replace(lines[n], "");
                    lines[n] = Answer;

                }

                if (string.IsNullOrWhiteSpace(lines[n]))
                {


                    Quest = lines[n - 5];
                    A=lines[n-4];
                    B=lines[n-3];
                    C=lines[n-2];
                    D=lines[n-1];

                    MessageBox.Show(Quest+A+B+C+D+Answer);
                }

            }


        }

    }
}
