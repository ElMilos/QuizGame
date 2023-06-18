using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektpk4
{
    internal class Pytanie
    {

      private string pytanie;
      private string OdpA;
      private string OdpB;
      private string OdpC;
      private string OdpD;
      private string OdpPrawidlowa;
        public Pytanie(string pytaniee, string Odpa, string Odpb, string Odpc, string Odpd, string Odpprawidlowa)
        {
            pytanie = pytaniee;
            OdpA = Odpa;
            OdpB = Odpb;
            OdpC = Odpc;
            OdpD = Odpd;
            OdpPrawidlowa = Odpprawidlowa;
        }

        static public string get_A(List<Pytanie> list, int n)
        {
            return list[n].OdpA;
        }
        static public string get_B(List<Pytanie> list, int n)
        {
            return list[n].OdpB;
        }
        static public string get_C(List<Pytanie> list, int n)
        {
            return list[n].OdpC;
        }
        static public string get_D(List<Pytanie> list, int n)
        {
            return list[n].OdpD;
        }
        static public string get_Pytanie(List<Pytanie> list, int n)
        {
            return list[n].pytanie;
        }
        static public string get_Odp(List<Pytanie> list, int n)
        {
            return list[n].OdpPrawidlowa;
        }
    }
}
