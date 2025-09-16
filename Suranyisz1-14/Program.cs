namespace Suranyisz1_14
{
    internal class Program
    {
        static void F1()
        {
            Console.WriteLine("Hello, World!");
        }

        static void F2()
        {
            Console.WriteLine("Mi a neved?");
            string nev = Console.ReadLine();
            Console.WriteLine("Szia " + nev + "!");
        }

        static void F3()
        {
            Console.WriteLine("Szorozz egy számot 2-vel!");
            int szam = int.Parse(Console.ReadLine());
            int eredmeny = szam * 2;
            Console.WriteLine(szam + " * 2 = " + eredmeny);
        }
        static void F4()
        {
            Console.WriteLine("Adj meg 2 szamot!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + " + " + b + " = " + (a + b));
            Console.WriteLine(a + " - " + b + " = " + (a - b));
            Console.WriteLine(a + " * " + b + " = " + (a * b));
            Console.WriteLine(a + " / " + b + " = " + (a / b));
        }
        static void F5()
        {
            Console.WriteLine("Adj meg 2 szamot!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(a, b) + " a nagyobbik szám.");
        }
        static void F6()
        {
            Console.WriteLine("Adj meg 3 szamot!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Min(a, Math.Min(b, c)) + " a legkisebb szám.");
        }
        static void F7()
        {
            Console.WriteLine("Adj meg egy háromszög oldalainak hosszát!");
            int aOldal = int.Parse(Console.ReadLine());
            int bOldal = int.Parse(Console.ReadLine());
            int cOldal = int.Parse(Console.ReadLine());
            if (aOldal + bOldal > cOldal && aOldal + cOldal > bOldal && bOldal + cOldal > aOldal)
            {
                Console.WriteLine("A háromszög létezik.");
            }
            else
            {
                Console.WriteLine("A háromszög nem létezik.");
            }
        }
        static void F8()
        {
            Console.WriteLine("Adj meg 2 pozitív számot!");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            if (a > 0 && b > 0)
            {
                double szamtaniKozep = (a + b) / 2;
                double meretaniKozep = Math.Sqrt(a * b);
                Console.WriteLine("Számtani közép: " + szamtaniKozep);
                Console.WriteLine("Mértani közép: " + meretaniKozep);
            }
            else
            {
                Console.WriteLine("A számoknak pozitívnak kell lenniük.");
            }
        }
        static void F9()
        {

        }

        static void F10()
        {

        }

        static void F11()
        {
            Console.WriteLine("Adj meg egy derékszögű háromszög két befogójának hosszát!");
            double aBefogo = double.Parse(Console.ReadLine());
            double bBefogo = double.Parse(Console.ReadLine());
            double atfogo = Math.Sqrt(aBefogo * aBefogo + bBefogo * bBefogo);
            Console.WriteLine("Az átfogó hossza: " + atfogo);
        }
        static void F12()
        {
            Console.WriteLine("Adj meg egy téglatest három élének hosszát!");
            double aOldal = double.Parse(Console.ReadLine());
            double bOldal = double.Parse(Console.ReadLine());
            double cOldal = double.Parse(Console.ReadLine());
            double felszin = 2 * (aOldal * bOldal + aOldal * cOldal + bOldal * cOldal);
            double terfogat = aOldal * bOldal * cOldal;
            Console.WriteLine("A téglatest felszíne: " + felszin);
            Console.WriteLine("A téglatest térfogata: " + terfogat);
        }
        static void F13()
        {
            Console.WriteLine("Adj meg egy kör átmérőjét!");
            double atmero = double.Parse(Console.ReadLine());
            double kerulet = Math.PI * atmero;
            double terulet = (Math.PI * atmero * atmero) / 4;
            Console.WriteLine("A kör kerülete: " + kerulet);
            Console.WriteLine("A kör területe: " + terulet);
        }
        static void F14()
        {

        }
        static void Main(string[] args)
        {
            F1();
            F2();
            F3();
            F4();
            F5();
            F6();
            F7();
            F8();
            F9();
            F10();
            F11();
            F12();
            F13();
            F14();
        }
    }
}
