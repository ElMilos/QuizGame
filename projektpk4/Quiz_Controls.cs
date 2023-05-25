using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektpk4
{
    internal class Quiz_Controls
    {

       static private List<Pytanie> list;

        static public string Quiz_Cont()
        {
            list = Pytanie.Quiz_List();
            string A =Pytanie.get_A(list,0);

            return A;


        }

        static private void Check(string button)
        {
            if(button==(Pytanie.get_Pytanie(list, 0)))
            {

            }
        }

    }


}
