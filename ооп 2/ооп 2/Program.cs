using ооп_2;

class Program
{
    static void Main()
    {
        
        var r1 = new Rational(5, 10);
        var r2 = new Rational(1, 2);

        Console.WriteLine(r1); 
        Console.WriteLine(r2); 

        var r3 = r1 + r2;
        Console.WriteLine(r3); 
        var r4 = r1 - r2;
        Console.WriteLine(r4); 
    }
}