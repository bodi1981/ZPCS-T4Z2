using System;

namespace T4Z2
{
    class Program
    {
        private static FizzBuzz fizzBuzz = new FizzBuzz();
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Podaj liczbę: ");
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    string result = fizzBuzz.CheckFizzBuzz(number);
                    Console.WriteLine($"Wynik: {result}");
                }
                else
                    Console.WriteLine("Podano nieprawidłową liczbę");

                Console.WriteLine("Aby kontynuować naciśnij dowolny klawisz, aby wyjść naciśnij w");
                if (Char.ToUpper(Console.ReadKey().KeyChar) == 'W')
                    return;
            }
        }
    }
}
