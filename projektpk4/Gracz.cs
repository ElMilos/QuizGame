using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektpk4
{
    internal class Gracz
    {
      public int points { get;  }
      public string name { get;  }

        public Gracz(string n, int p=0) 
        {
            name = n;
            points = p; 

        }



    }
}
