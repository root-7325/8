using System;
class pribavlenie
{
    static void Main()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"{x}{x}{x}"); 
        for(int y = 0; y < 3; y++)
        {
            Console.WriteLine($"{x} {x}");
        }
        Console.WriteLine($"{x}{x}{x}");
        Console.ReadKey(true);
    }
}
