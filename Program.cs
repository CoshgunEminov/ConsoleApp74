namespace ConsoleApp74
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Selsi °C-dən Fahrenheit °F-ə");
            Console.WriteLine("2. Fahrenheit °F-dən Selsi °C-ə");
            Console.WriteLine("Seçim edin (1/2): ");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Selsi dərəcəsini daxil edin: ");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = TemperatureConverter.CelsiusToFahrenheit(celsius);
                Console.WriteLine($"{celsius} °C = {fahrenheit} °F");
            }
            else if (choice == 2)
            {
                Console.Write("Fahrenheit dərəcəsini daxil edin: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = TemperatureConverter.FahrenheitToCelsius(fahrenheit);
                Console.WriteLine($"{fahrenheit} °F = {celsius} °C");

            }
            else 
            {
                Console.WriteLine("sehvdir");
            }

           

            int x = 5;
            Console.WriteLine(x.factorial());
            Console.ReadLine();
        }
    }
}