using System;

namespace zadanie23
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string tekst = " ";
            float wynik = 0;
            Console.Write("Podaj pierwszą liczbę: ");
            float l1 = float.Parse(Console.ReadLine());
            Console.Write("\nPodaj drugą liczbę: ");
            float l2 = float.Parse(Console.ReadLine());
            Console.WriteLine("\n0\tDodawanie\n1\tMnożenie\n2\tDzielenie\n3\tOdejmowanie");
            Console.Write("Wybór: ");
            int wybor = int.Parse(Console.ReadLine());
            while (wybor<0||wybor>3)
            {
                Console.WriteLine("Operacja nieznana! Spróbuj jeszcze raz...");
                Console.Write("\nWybór: ");
                wybor = int.Parse(Console.ReadLine());
            }
            switch(wybor)
            {
                case 0:
                    wynik = l1 + l2;
                    tekst = "dodawania";
                    break;
                case 1:
                    wynik = l1 * l2;
                    tekst = "mnożenia";
                    break;
                case 2:
                    wynik = l1 / l2;
                    tekst = "dzielenia";
                    break;
                case 3:
                    wynik = l1 - l2;
                    tekst = "odejmowania";
                    break;

            }
            Console.WriteLine($"\nWynik operacji {tekst} liczb {l1} i {l2} to: {wynik}.\nNaciśnij dowolny klawisz, aby wyjść...");
            Console.ReadKey();
        }
    }
}
