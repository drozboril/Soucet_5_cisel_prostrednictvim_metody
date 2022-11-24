using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Trida
{
    public int Nas(int a, int b, int c, int d, int e, int f)
    { return (a + b + c + d + e + f); }
    public void Vyp(int a)
    { Console.WriteLine("Zadejte {0}. hodnotu", a); }
}
class Program
{
    static void Main(string[] args)
    {
        Trida t = new Trida();
        int a = 1;
        t.Vyp(a); a++;
        int b = int.Parse(Console.ReadLine());
        t.Vyp(a); a++;
        int c = int.Parse(Console.ReadLine());
        t.Vyp(a); a++;
        int d = int.Parse(Console.ReadLine());
        t.Vyp(a); a++;
        int e = int.Parse(Console.ReadLine());
        t.Vyp(a); a++;
        int f = int.Parse(Console.ReadLine());
        Console.WriteLine("Součet zadaných hodnot je {0}", t.Nas(a, b, c, d, e, f) - 6); //proměnná a se zvýší o 1 po zadání každého čísla, kterých je celkem 6 a tím pádem musí být odečetna při finálním výpočtu
        Console.ReadLine();
    }
}