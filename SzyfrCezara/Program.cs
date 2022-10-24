using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzyfrCezara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] alfabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'w', 'y', 'z' };
            Console.WriteLine("Wprowadź Tekst do zaszyfrowania");
            string wiadomosc = Console.ReadLine();
            char[] wiadomoscWChar = wiadomosc.ToCharArray();
            char[] zaszyfrowanaWiadomosc = new char[wiadomoscWChar.Length];

            for (int i = 0; i < wiadomoscWChar.Length; i++)
            {
                char litera = wiadomoscWChar[i];
                int pozycjaAlfatet = Array.IndexOf(alfabet, litera);
                int nowaPozycjaAlfabet = (pozycjaAlfatet + 4) %23;
                char zaszyfrowanaLitera = alfabet[nowaPozycjaAlfabet];
                zaszyfrowanaWiadomosc[i] = zaszyfrowanaLitera;
            }

            string zaszyfrowanaWiadomoscString = String.Join("", zaszyfrowanaWiadomosc);

            Console.WriteLine(zaszyfrowanaWiadomoscString);
            Console.ReadKey();
        }
    }
}
