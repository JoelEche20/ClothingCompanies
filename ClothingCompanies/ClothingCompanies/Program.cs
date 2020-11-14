using System;

namespace ClothingCompanies
{
    class Program
    {
        static void Main(string[] args)
        {
            Cotton cotton = new Cotton(1.10);
            cotton.Attach(new ClothingCompany("Almanza", 1.00));
            cotton.Attach(new ClothingCompany("Julyo's", 1.05));
            cotton.Attach(new ClothingCompany("El Corte Ingles", 1.08));

            cotton.PricePerMeter = 1.05;
            cotton.PricePerMeter = 1.15;
            cotton.PricePerMeter = 1.25;
            cotton.PricePerMeter = 1.00;

            Console.ReadKey();
        }
    }
}
