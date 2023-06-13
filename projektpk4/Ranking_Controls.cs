using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;

namespace projektpk4
{
    internal class Ranking_Controls : Controls
    {

      public override string Czytaj()
        {
           
            
                string file = "E:\\Proejkt\\projektpk4\\projektpk4\\ranking.txt";
                string filestring = "";

                if (File.Exists(file))
                {
                    filestring = File.ReadAllText(file);
                }
                else
                {
                    MessageBox.Show("Plik z rankingiem nie istnieje.");
                }

                return filestring;
            
        }

      public string load_ranking()
        {

            int end_of_line = 2;


            Controls B = new Ranking_Controls(); // sprawdzenie polimorfizmu
            string filetext = B.Czytaj();


            string[] slowa = filetext.Split('\n'); // rozdziela wiersze string na osobne zmienne string


            List<Gracz> Player_List= new List<Gracz>();

            // Przechodzenie przez każde słowo w tablicy
            foreach (string podzial in slowa)
            {
                string[] slowo = podzial.Split(' ');

                if (slowo.Length== end_of_line)
                {
                    Gracz a = new Gracz(slowo[0], int.Parse(slowo[1]));

                    Player_List.Add(new Gracz(slowo[0], int.Parse(slowo[1])));
                  
                }

            }

            return filetext; 
        }
    }
}
