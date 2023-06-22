using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.LinkLabel;

namespace projektpk4
{
    internal class Ranking_Controls : Controls
    {

      private static List<Gracz> Player_List = new List<Gracz>();

      private static int set_limit = 3;


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

      public static void load_ranking()
        {

            int end_of_line = 2;

  


            Controls B = new Ranking_Controls(); 
            string filetext = B.Czytaj();


            string[] slowa = filetext.Split('\n'); 



            foreach (string podzial in slowa)
            {
                string[] slowo = podzial.Split(' ');

                if (slowo.Length== end_of_line)
                {
                    Player_List.Add(new Gracz(slowo[0], int.Parse(slowo[1])));                 
                }

            }

            if (Player_List.Count > set_limit) 
            {
                Player_List.RemoveRange(set_limit, Player_List.Count - set_limit);
            }

        }


        public string Show_List()
        {


            string Ranks = string.Format("{0}\t{1}\t{2}\r\n", "Miejsce", "Nazwa", "Punkty");
            int position = 1;

            foreach (var element in Player_List)
            {
                Ranks += string.Format("{0}\t{1}\t{2}\r\n", position++, element.name, element.points);
            }


            return Ranks;
        }

       static public List<Gracz> get_List()
        {
            return Player_List;
        }

        static public void repalce_ranks(List<Gracz> Updated_List)
        {
            Player_List= Updated_List;


            if (Player_List.Count > set_limit)
            {
                Player_List.RemoveRange(set_limit, Player_List.Count - set_limit);
            }
        }

        static public void save_Ranking()
        {
            string playerData = string.Join("", Player_List.Select(player => $"{player.name} {player.points}\r\n"));

 
            int lastIndex = playerData.LastIndexOf("\r\n");

            if (lastIndex >= 0)
            {
                playerData = playerData.Remove(lastIndex, 1);
            }


            try
            {
                File.WriteAllText("E:\\Proejkt\\projektpk4\\projektpk4\\ranking.txt", playerData);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Wystąpił błąd podczas zapisu do pliku: " + ex.Message);
            }


        }

    }
}
