using ооп3;
class Program
{
    static void Main()
    {
        IDateTimeFormatter european = new EuropeanDateTimeFormatter();
        IDateTimeFormatter american = new AmericanDateTimeFormatter();

        IDateTimeFormatter decorated = new AddAsterisksDecorator(new AddBracketsDecorator(european));
        Console.WriteLine(decorated.Format());

        decorated = new AddBracketsDecorator(american);
        Console.WriteLine(decorated.Format());
    }
}