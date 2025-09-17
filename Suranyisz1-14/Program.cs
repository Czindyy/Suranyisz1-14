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
        
        static void F15()
        {
            Console.WriteLine("Adj meg egy pozitív egész számot!");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void F16()
        {
            Console.WriteLine("Adj meg egy pozitív egész számot!");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }

        static void F17() 
        {
            Console.WriteLine("Adj meg egy pozitív egész számot!");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Az osztók:");
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static void F18() 
        {
            Console.WriteLine("Adj meg egy pozitív egész számot!");
            int n = int.Parse(Console.ReadLine());
            int osztoSzam = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    osztoSzam++;
                }
            }
            Console.WriteLine("Az osztók száma: " + osztoSzam);
        }

        static void F19() 
        {
            Console.WriteLine("Adj meg egy pozitív egész számot!");
            int n = int.Parse(Console.ReadLine());
            int osztoOsszeg = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    osztoOsszeg += i;
                }
            }
            if (osztoOsszeg == n)
            {
                Console.WriteLine(n + " tökéletes szám.");
            }
            else
            {
                Console.WriteLine(n + " nem tökéletes szám.");
            }
        }

        static void F20() 
        {
            Console.WriteLine("Adj meg egy számot (alap)!");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Adj meg egy számot (kitevő)!");
            int b = int.Parse(Console.ReadLine());
            int hatvanyErtek = 1;
            for (int i = 1; i <= b; i++)
            {
                hatvanyErtek *= a;
            }
            Console.WriteLine(a + " a " + b + ". hatványon: " + hatvanyErtek);
        }

        static void F21()
        {
            int n;
            do
            {
                Console.WriteLine("Adj meg egy pozitív egész számot!");
                n = int.Parse(Console.ReadLine());
            } while (n <= 0);
        }

        static void F22()
        {
            int szam;
            int osszeg = 0;
            do
            {
                Console.WriteLine("Adj meg egy számot!");
                szam = int.Parse(Console.ReadLine());
                if (szam < 10)
                {
                    osszeg += szam;
                }
            } while (szam < 10);
            Console.WriteLine("A beolvasott számok összege: " + osszeg);
        }

        static void F23()
        {
        }

        static void F24()
        {
            string szo;
            do
            {
                Console.WriteLine("Adj meg egy szót!");
                szo = Console.ReadLine();
            } while (szo != "alma");
            Console.WriteLine("Az alma gyümölcs!");
        }

        static void F25() 
        {

        }

        static void F26()
        {
            Console.WriteLine("Adj meg egy pozitív egész számot!");
            int n = int.Parse(Console.ReadLine());
            if (n < 2)
            {
                Console.WriteLine(n + " nem prímszám.");
                return;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(n + " nem prímszám.");
                    return;
                }
            }
            Console.WriteLine(n + " prímszám.");
        }

        static void F27() 
        {
            Console.WriteLine("Adj meg egy pozitív egész számot!");
            int n = int.Parse(Console.ReadLine());
            for (int num = 2; num <= n; num++)
            {
                bool isPrime = true;
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write(num + " ");
                }
            }
            Console.WriteLine();
        }

        static void F28() //beolvas egy számot, és kiírja a szám prímosztóit 
        {
            Console.WriteLine("Adj meg egy pozitív egész számot!");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("A prímosztók:");
            for (int i = 2; i <= n; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime && n % i == 0)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static void F29() //beolvas egy számot, majd kiírja a szám prímtényezős felbontását
        {
            Console.WriteLine("Adj meg egy pozitív egész számot!");
            int n = int.Parse(Console.ReadLine());
            Console.Write(n + " = ");
            for (int i = 2; i <= n; i++)
            {
                while (n % i == 0)
                {
                    Console.Write(i);
                    n /= i;
                    if (n > 1)
                    {
                        Console.Write(" * ");
                    }
                }
            }
            Console.WriteLine();
        }

        static void F30() 
        {
            Console.WriteLine("Adj meg két pozitív egész számot!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            Console.WriteLine("A legnagyobb közös osztó: " + a);
        }

        static void F31() 
        {
            Console.WriteLine("Adj meg két pozitív egész számot!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int elsoA = a;
            int elsoB = b;
            while (b != 0)
            {
                int t = b;
                b = a % b;
                a = t;
            }
            int lkt = (elsoA * elsoB) / a;
            Console.WriteLine("A legkisebb közös többszörös: " + lkt);
        }
        static void Main(string[] args)
        {
            
        }
    }
}
