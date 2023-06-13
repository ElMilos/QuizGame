using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;

namespace projektpk4
{
    internal class Ranking_Controls
    {
        //List<string> Ranking_list; może użyć listy ?




     static public string load_ranking()
        {
            string file = "E:\\Proejkt\\projektpk4\\projektpk4\\ranking.txt";
            string filestring = Czytnik.Czytaj(file);


            string[] slowa = filestring.Split('\n'); // rozdziela wiersze string na osobne zmienne string


            List<Gracz> Player_List= new List<Gracz>();

            // Przechodzenie przez każde słowo w tablicy
            foreach (string podzial in slowa)
            {
                string[] slowo = podzial.Split(' ');

                if (slowo.Length==2)
                {
                    Gracz a = new Gracz(slowo[0], int.Parse(slowo[1]));

                    Player_List.Add(new Gracz(slowo[0], int.Parse(slowo[1])));

                   // MessageBox.Show( a.nazwa+" to jest nazwa", a.punkty.ToString());
                }

            }

            return filestring; 
        }
    }
}
