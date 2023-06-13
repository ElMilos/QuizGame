using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektpk4
{
    internal class Quiz
    {
       static Pytanie_Controls Hold = new Pytanie_Controls(); 
       static private List<Pytanie> list = Hold.Quiz_List();
       static private int question_count = list.Count;



       static List<int> numbers = new List<int>();
       static Random random = new Random();
       static int randomNumber = random.Next(0, question_count);
       static int i = 0;


        static public void Next_Question()
        {
            int n = 0;
            while (n == 0) 
            {

                randomNumber = random.Next(0, question_count);


                if (!numbers.Contains(randomNumber))
                {
                    Form1.Button1 = Pytanie.get_A(list, randomNumber);
                    Form1.Button2 = Pytanie.get_B(list, randomNumber);
                    Form1.Button3 = Pytanie.get_C(list, randomNumber);
                    Form1.Button4 = Pytanie.get_D(list, randomNumber);
                    Form1.pytanie_form = Pytanie.get_Pytanie(list, randomNumber);

                    numbers.Add(randomNumber);
                    n = 1;
                }



            }
            i++;



        }





        static public void Check(string button_text)
        {
            if (i == question_count&& button_text == (Pytanie.get_Odp(list, randomNumber)))
            {
                MessageBox.Show("koniec pytan");
                System.Windows.Forms.Application.Exit();

            }


           else if (button_text==(Pytanie.get_Odp(list, randomNumber)))
            {
               Next_Question();
            }


            else
            {
                MessageBox.Show("przegrałes");
            }




        }

    }


}
