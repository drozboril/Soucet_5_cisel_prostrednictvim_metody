using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Trida
{
    public int Nas(int b, int c, int d, int e, int f)
    { return (b + c + d + e + f); }
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
        Console.WriteLine("Součet zadaných hodnot je {0}", t.Nas(b, c, d, e, f));
        Console.ReadLine();
    }
}