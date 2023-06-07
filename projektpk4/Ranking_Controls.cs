using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektpk4
{
    internal class Ranking_Controls
    {
        //List<string> Ranking_list; może użyć listy ?

     static string ranking_text;


     static public string load_ranking()
        {
            string file = "E:\\Proejkt\\projektpk4\\projektpk4\\ranking.txt";
            Ranking_Controls.ranking_text = Czytnik.Czytaj(file);
                 
            return ranking_text;
            
        }
    }
}
