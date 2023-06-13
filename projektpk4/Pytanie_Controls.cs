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
    internal class Pytanie_Controls : Controls
    {
        public override string Czytaj()
        {


            string file = "E:\\Proejkt\\projektpk4\\projektpk4\\Questions.txt";
            string filestring = "";

            if (File.Exists(file))
            {
                filestring = File.ReadAllText(file);
            }
            else
            {
                MessageBox.Show("Plik z pytaniami nie istnieje.");
            }

            return filestring;

        }

        public List<Pytanie> Quiz_List()
        {
            List<Pytanie> list = new List<Pytanie>();

            Controls A = new Pytanie_Controls(); // sprawdzenie polimorfizmu
            string filetext = A.Czytaj();


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


                }

            }


            return list;
        }








    }


}


