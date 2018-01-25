using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _141035
{
    class Program
    {
        static void Main(string[] args)
        {
            KlasaTest klasa = new KlasaTest();

            klasa.Druga();
            klasa.TestMetoda(12);

            LinkedList<double> lista = new LinkedList<double>();

            lista.AddLast(3);
            lista.AddLast(4);
            lista.AddLast(5);

            foreach (var liczba in lista)
            {
                Console.WriteLine(liczba);
            }

            Console.WriteLine("Po dodaniu");

            LinkedListNode<double> node = lista.Find(3);

            lista.AddAfter(node, 3.5);
            LinkedListNode<double> node2 = lista.Find(4);
            lista.AddAfter(node2, 5.5);

            foreach (var liczba in lista)
            {
                Console.WriteLine(liczba);
            }

            List<Bohater> bohaterzy = new List<Bohater>();
            bohaterzy.Add(new Elf(75, "kula ognia"));
            bohaterzy.Add(new Elf(80, "lodowy pocisk"));
            bohaterzy.Add(new Ork(150, 50));
            bohaterzy.Add(new Ork(135, 60));
            bohaterzy.Sort();
            foreach (var n in bohaterzy)
            {
                Console.WriteLine(n);
            }
            
            Sport klasasport = new Sport();
            klasasport.sportmetoda("Jakas nazwa");

            Console.WriteLine("Podaj 1sza liczbe:");
            int liczba1 = 0;
            try
            {
                liczba1 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Prosze podac liczbe!");
            }
            
            Bohater obiekt = new Bohater(liczba1);
            Console.WriteLine(obiekt);

            var slownik = new Dictionary<string, List<int>>
            {
                {"Kot", new List<int>{1}},
                {"Pies", new List<int>{2}}
            };


            Console.ReadKey();

        }
    }
}
