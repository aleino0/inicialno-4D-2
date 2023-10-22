using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Definirajte klasu GeometrijskiLik sa sljedećim članicama:
• varijabla tipa int BrojStranica
• niz tipa double veličine 10 Stranice
• metode UcitajStranice() koja će učitati od korisnika stranice geometrijskog lika
Opseg () koja će vratiti opseg geometrijskog lika
Definirajte klase Trokut i Cetverokut izvedene iz klase GeometrijskiLik, te im definirajte
konstruktore u kojima ćete varijabli BrojStranica dodijeliti odgovarajuću vrijednost.
Definirajte dva objekta tipa Trokut i Cetverokut, učitajte duljine stranica, te izračunajte
opsege.*/


namespace inic2zad2
{
    internal class Program
    {
        class GeometrijskiLik
        {
            int brojStranica;
            double[] stranice = new double[10];

            public int BrojStranica { get => brojStranica; set => brojStranica = value; }
            public double[] Stranice { get => stranice; set => stranice = value; }

            public void UcitajStranice()
            {
                for (int i = 0; i < BrojStranica; i++)
                {
                    Console.Write("Unesi " + (i + 1) + ". stranicu: ");
                    Stranice[i] = Convert.ToDouble(Console.ReadLine());
                }
            }
            public double Opseg()
            {
                double opseg = 0;
                for (int i = 0; i < BrojStranica; i++)
                {
                    opseg += Stranice[i];
                }
                return opseg;
            }
        }
        class Trokut : GeometrijskiLik
        {
            public Trokut()
            {
                BrojStranica = 3;
            }
        }
        class Cetverokut : GeometrijskiLik
        {
            public Cetverokut()
            {
                BrojStranica = 4;
            }
        }
        static void Main(string[] args)
        {
            Trokut trokut = new Trokut();
            Cetverokut cetverokut = new Cetverokut();
            Console.WriteLine("Unesi duljine sve 3 strane trokuta u cm");
            trokut.UcitajStranice();
            Console.WriteLine("Unesi duljine sve 4 strane cetverokuta u cm");
            cetverokut.UcitajStranice();
            Console.WriteLine("Opseg trokuta je " + trokut.Opseg() + "cm, a opseg cetverokuta je " + cetverokut.Opseg() + "cm.");
            Console.ReadLine();
        }
    }
}
