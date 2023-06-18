using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace projektpk4
{
    internal class Quiz
    {
       static private Pytanie_Controls Hold = new Pytanie_Controls(); 
       static private List<Pytanie> list = Hold.Quiz_List();
       static private int question_count = list.Count;



       static private List<int> numbers = new List<int>();
       static private Random random = new Random();
       static private int randomNumber = random.Next(0, question_count);
       static private int used_questions = 0;

       static private string name="";
       static private int points;




        static public void Next_Question()
        {
            int n = 0;
            while (n == 0) 
            {

                randomNumber = random.Next(0, question_count);


                if (!numbers.Contains(randomNumber))
                {
                    Quiz_Form.Button1 = Pytanie.get_A(list, randomNumber);
                    Quiz_Form.Button2 = Pytanie.get_B(list, randomNumber);
                    Quiz_Form.Button3 = Pytanie.get_C(list, randomNumber);
                    Quiz_Form.Button4 = Pytanie.get_D(list, randomNumber);
                    Quiz_Form.pytanie_form = Pytanie.get_Pytanie(list, randomNumber);

                    numbers.Add(randomNumber);
                    n = 1;
                }



            }
            used_questions++;


        }

        public static void send_name(string namee)
        {
            name = namee;
            points = 0;

        }



        static public bool Check(string button_text)
        {
            if (used_questions == question_count && button_text == (Pytanie.get_Odp(list, randomNumber)))
            {
                MessageBox.Show("koniec pytan");
                points++;

                check_with_ranks();

                used_questions = 0;
                numbers.Clear();

                return false;
            }


           else if (button_text==(Pytanie.get_Odp(list, randomNumber)))
            {

                points++;

                Next_Question();

                return true;
            }


            else
            {
                MessageBox.Show("Zła Odpowiedz");
                check_with_ranks();

                used_questions = 0; // zerowanie uyżytych pytań
                numbers.Clear(); // czyszczenie listy z użytymi pytaniami

                return false;
            }

        }

         static void check_with_ranks()
        {
            List<Gracz> Player_List=Ranking_Controls.get_List();

            for(int i=0; i<Player_List.Count; i++)
            {
                if (points > Player_List[i].points)
                {
                    Player_List.Insert(i,new Gracz(name, points));

                    Ranking_Controls.repalce_ranks(Player_List);

                    return;
                }
                else if(Player_List.Count<Player_List.Capacity-1)
                {
                    Player_List.Add(new Gracz(name, points));

                    Ranking_Controls.repalce_ranks(Player_List);

                    return;
                }
            }
            return;

        }




    }


}
