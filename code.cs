using System;
class rectangle
{
    static void Main()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());
        int z = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < y; i++)
        {
            for(int j = 0; j < y; j++)
            {
                Console.Write(x);
            }
            Console.WriteLine();
        }
    }
}
