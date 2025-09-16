namespace Suranyisz1_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. feladat
            Console.WriteLine("Hello, World!");

            // 2. feladat
            Console.WriteLine("Mi a neved?");
            string nev = Console.ReadLine();
            Console.WriteLine("Szia " + nev + "!");

            // 3. feladat
            Console.WriteLine("Szorozz egy számot 2-vel!");
            int szam = int.Parse(Console.ReadLine());
            int szam2 = szam * 2;
            Console.WriteLine(szam + " * 2 = " + szam2);

            // 4. feladat
            Console.WriteLine("Adj meg 2 szamot!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(a + " + " + b + " = " + (a + b));
            Console.WriteLine(a + " - " + b + " = " + (a - b));
            Console.WriteLine(a + " * " + b + " = " + (a * b));
            Console.WriteLine(a + " / " + b + " = " + (a / b));

            // 5. feladat
            Console.WriteLine("Adj meg 2 szamot!");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Max(x, y) + " a nagyobbik szám.");

            // 6. feladat
            Console.WriteLine("Adj meg 3 szamot!");
            int ax = int.Parse(Console.ReadLine());
            int ay = int.Parse(Console.ReadLine());
            int az = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Min(ax, Math.Min(ay, az)) + " a legkisebb szám.");

            // 7. feladat
            Console.WriteLine("Adj meg egy háromszög oldalainak hosszát!");
            int oldal1 = int.Parse(Console.ReadLine());
            int oldal2 = int.Parse(Console.ReadLine());
            int oldal3 = int.Parse(Console.ReadLine());
            if (oldal1 + oldal2 > oldal3 && oldal1 + oldal3 > oldal2 && oldal2 + oldal3 > oldal1)
            {
                Console.WriteLine("A háromszög létezik.");
            }
            else
            {
                Console.WriteLine("A háromszög nem létezik.");
            }

            // 8. feladat 
            Console.WriteLine("Adj meg 2 pozitív számot!");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            if (num1 > 0 && num2 > 0)
            {
                double szamtaniKozep = (num1 + num2) / 2;
                double meretaniKozep = Math.Sqrt(num1 * num2);
                Console.WriteLine("Számtani közép: " + szamtaniKozep);
                Console.WriteLine("Mértani közép: " + meretaniKozep);
            }
            else
            {
                Console.WriteLine("A számoknak pozitívnak kell lenniük.");
            }

            // 9. feladat

            // 10. feladat

            // 11. feladat
            Console.WriteLine("Adj meg egy derékszögű háromszög két befogójának hosszát!");
            double befogo1 = double.Parse(Console.ReadLine());
            double befogo2 = double.Parse(Console.ReadLine());
            double atfogo = Math.Sqrt(befogo1 * befogo1 + befogo2 * befogo2);
            Console.WriteLine("Az átfogó hossza: " + atfogo);

            // 12. feladat
            Console.WriteLine("Adj meg egy téglatest három élének hosszát!");
            double aOldal = double.Parse(Console.ReadLine());
            double bOldal = double.Parse(Console.ReadLine());
            double cOldal = double.Parse(Console.ReadLine());
            double felszin = 2 * (aOldal * bOldal + aOldal * cOldal + bOldal * cOldal);
            double terfogat = aOldal * bOldal * cOldal;
            Console.WriteLine("A téglatest területe: " + felszin);
            Console.WriteLine("A téglatest térfogata: " + terfogat);

            // 13. feladat 
            Console.WriteLine("Adj meg egy kör átmérőjét!");
            double atmero = double.Parse(Console.ReadLine());
            double kerulet = Math.PI * atmero;
            double terulet = (Math.PI * atmero * atmero) / 4;
            Console.WriteLine("A kör kerülete: " + kerulet);
            Console.WriteLine("A kör területe: " + terulet);

            // 14. feladat

        }
    }
}
