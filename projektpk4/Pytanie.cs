using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;

using System.Security.Cryptography.X509Certificates;


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



        public Pytanie(string pytaniee, string Odpa, string Odpb, string Odpc, string Odpd, string Odpprawidlowa)
        {
            pytanie = pytaniee;
            OdpA = Odpa;
            OdpB = Odpb;
            OdpC = Odpc;
            OdpD = Odpd;
            OdpPrawidlowa = Odpprawidlowa;
        }

        static public List<Pytanie> Quiz_List()
        {
            List<Pytanie> list = new List<Pytanie>();


            string file = "E:\\Proejkt\\projektpk4\\projektpk4\\Quiz.txt";
            string filetext = Czytnik.Czytaj(file);


            string pattern = "@";
            Regex regex = new Regex(pattern);
            string Answer = "";

            string[] lines = filetext.Split('\n'); // rozdziela wiersze string na osobne zmienne string

            for (int n = 0; n < lines.Length; n++)
            {

                if (regex.IsMatch(lines[n]))
                {
                    Answer = regex.Replace(lines[n], "");
                    lines[n] = Answer;
                }

                if (string.IsNullOrWhiteSpace(lines[n]))
                {

                    list.Add(new Pytanie(lines[n - 5], lines[n - 4], lines[n - 3], lines[n - 2], lines[n - 1], Answer));
                    /*

                    Quest = lines[n - 5];
                    A=lines[n-4];
                    B=lines[n-3];
                    C=lines[n-2];
                    D=lines[n-1];

                    MessageBox.Show(Quest+A+B+C+D+Answer);
                    */


                }

            }


            return list;
        }
        static public void showw(List<Pytanie> list)
        {
            MessageBox.Show(list[0].pytanie + list[0].OdpA + list[0].OdpB + list[0].OdpC + list[0].OdpD + list[0].OdpPrawidlowa);
        }

        static public string get_A(List<Pytanie> list, int n)
        {
            return list[n].OdpA;
        }
        static public string get_B(List<Pytanie> list, int n)
        {
            return list[n].OdpB;
        }
        static public string get_C(List<Pytanie> list, int n)
        {
            return list[n].OdpC;
        }
        static public string get_D(List<Pytanie> list, int n)
        {
            return list[n].OdpD;
        }
        static public string get_Pytanie(List<Pytanie> list, int n)
        {
            return list[n].pytanie;
        }
        static public string get_Odp(List<Pytanie> list, int n)
        {
            return list[n].OdpPrawidlowa;
        }


    }


}


