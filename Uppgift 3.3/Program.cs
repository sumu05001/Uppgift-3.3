using System;
namespace uppgift3
{
    class program
    {
        static void Main(string[] args)
        {
            int avgift = 80;
            int maximala = 950;
            Console.WriteLine("hur mång timmar vill du hyra bilen ");
            int timmar = Convert.ToInt32(Console.ReadLine());
            int kosta = avgift * timmar;
            if (kosta > maximala)
            {
                maximala = 950;
            }
            Console.WriteLine("Den totala kostnaden är = " + kosta);
        }
    }
}

