// See https://aka.ms/new-console-template for more information


    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            int sumatoria = 0;

            while (true)
            {
                Console.Write("Ingrese un número: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out numero))
                {
                    Console.WriteLine("El valor ingresado no es un número válido.");
                    continue;
                }

                sumatoria += numero;

                Console.WriteLine($"La sumatoria actual es: {sumatoria}");

                if (sumatoria >= 100)
                {
                    Console.WriteLine($"Se alcanzó la sumatoria de 100 con el número {numero}.");
                    break;
                }
            }
        }
    }
