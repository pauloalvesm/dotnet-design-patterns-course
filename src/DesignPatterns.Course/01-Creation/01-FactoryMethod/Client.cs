using DesignPatterns.Course._01_Creation._01_FactoryMethod.Enums;

namespace DesignPatterns.Course._01_Creation._01_FactoryMethod;

public class Client
{
    public void ExecuteProductCreation()
    {
        var serviceSelector = new ServiceSelector();
        var continueRunning = true;

        while (continueRunning)
        {
            Console.WriteLine("Select the service type:\n");
            Console.WriteLine("0 - Traditional");
            Console.WriteLine("1 - Premium");
            Console.WriteLine("2 - Master");
            Console.WriteLine("3 - Coverage");

            Console.Write("Enter the number of the service you wish to bill: ");

            if (!int.TryParse(Console.ReadLine(), out int serviceType))
            {
                Console.WriteLine("Invalid input! Please enter a valid number.\n");
                continue;
            }

            var productService = serviceSelector.ManufactureProduct((ServiceType)serviceType);

            Console.Write("Do you want to calculate another service? (1-Yes or 2-No): ");

            if (int.TryParse(Console.ReadLine(), out int response))
            {
                continueRunning = response == 1;
            }
            else
            {
                Console.WriteLine("Invalid option. Exiting application...");
                continueRunning = false;
            }
        }
    }
}