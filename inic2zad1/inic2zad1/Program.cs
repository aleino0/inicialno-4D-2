using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Definirajte klasu Biljka, te definirajte od nje izvedenu klasu Stablo sa sljedećim članicama:
• varijabla tipa bool opadajuListovi
• svojstvo OpadajuListovi
• konstruktor Stablo(bool) koji će dodijeliti vrijednost proslijeđenog argumenta varijabli
opadajuListovi
Definirajte klasu Cvijet izvedenu iz klase Biljka.
Definirajte klase Bijelogoricno i Crnogoricno izvedene iz klase Stablo.
Klasama definirajte odgovarajuće konstruktore.
Definirajte dva objekta Hrast i Bor tipova Bijelogoricno i Crnogoricno, te ispišite vrijednosti
njihovih članica opadajuListovi.
*/


namespace inic2zad1
{
    internal class Program
    {
        class Biljka
        {

        }
        class Stablo : Biljka
        {
            bool opadajuListovi;

            public bool OpadajuListovi { get => opadajuListovi; set => opadajuListovi = value; }
            public Stablo() { }
            public Stablo(bool b)
            {
                OpadajuListovi = b;
            }
        }
        class Cvijet : Biljka
        {

        }
        class Bijelogoricno : Stablo
        {
            public Bijelogoricno() { }
            public Bijelogoricno(bool b) { OpadajuListovi = b; }
        }
        class Crnogoricno : Stablo
        {
            public Crnogoricno() { }
            public Crnogoricno(bool b) { OpadajuListovi = b; }
        }
        static void Main(string[] args)
        {
            Bijelogoricno Hrast = new Bijelogoricno(true);
            Crnogoricno Bor = new Crnogoricno(false);
            Console.Write("Hrast ");
            if (Hrast.OpadajuListovi == true)
            {
                Console.Write("opadaju listovi.");
            }
            else
            {
                Console.Write("ne opadaju listovi.");
            }
            Console.Write(" A bor ");
            if (Bor.OpadajuListovi == true)
            {
                Console.Write("opadaju listovi.");
            }
            else
            {
                Console.Write("ne opadaju listovi.");
            }
            Console.ReadLine();
        }
    }
}
