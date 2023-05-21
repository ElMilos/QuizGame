using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace projektpk4
{
   internal class Czytnik
    {


        static public string Czytaj(string file)
        {
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
    }
}

