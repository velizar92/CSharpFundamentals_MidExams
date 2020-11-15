using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {

            double totalPriceWithTaxes = 0.0;
            double totalPriceWithoutTaxes = 0.0;
            double totalAmountOfTaxes = 0.0;
            bool validOrder = true;


            while (true)
            {

                string inputString = Console.ReadLine();
                if (inputString == "special")
                {
                    if (totalPriceWithTaxes == 0 || totalPriceWithTaxes == 0.0)
                    {
                        Console.WriteLine("Invalid order!");
                        validOrder = false;
                        break;
                    }
                    else
                    {
                        totalPriceWithTaxes = totalPriceWithTaxes - (totalPriceWithTaxes * 0.10); //special client
                        break;
                    }
                }
                else if (inputString == "regular")
                {
                    if (totalPriceWithTaxes == 0 || totalPriceWithTaxes == 0.0)
                    {
                        Console.WriteLine("Invalid order!");
                        validOrder = false;
                        break;
                    }
                    else
                    {
                        break;
                    }
                }
                else
                {

                    double priceWithoutTax = double.Parse(inputString); //without tax
                    if (priceWithoutTax < 0)
                    {
                        Console.WriteLine("Invalid price!");
                    }
                    else
                    {
                        totalPriceWithoutTaxes += priceWithoutTax;
                        totalPriceWithTaxes += priceWithoutTax + (priceWithoutTax * 0.20); ;                         //Acumulate all prices (with taxes)
                    }

                }
            }

            totalAmountOfTaxes = totalPriceWithoutTaxes * 0.20;


            if (validOrder == true)
            {
                Console.WriteLine("Congratulations you've just bought a new computer!\n" +
                                $"Price without taxes: {totalPriceWithoutTaxes:f2}$\n" +
                                $"Taxes: {totalAmountOfTaxes:f2}$\n" +
                                "-----------\n" +
                                $"Total price: {totalPriceWithTaxes:f2}$");
            }



        }
    }
}
