using DesignPatterns.Course._01_Creation._02_AbstractFactory.Create.Factories;
using DesignPatterns.Course._01_Creation._02_AbstractFactory.Create.Interfaces;

namespace DesignPatterns.Course._01_Creation._02_AbstractFactory;

public class Client
{
    public void ConsultStudentRoutine()
    {
        var continueRunning = true;

        while (continueRunning)
        {
            IFactory factory = null;

            Console.WriteLine("-------------------------");
            Console.WriteLine("Select the desired routine: ");
            Console.WriteLine("1 - Monday and Thursday");
            Console.WriteLine("2 - Tuesday and Friday");
            Console.WriteLine("3 - Wednesday and Saturday");

            Console.Write("Select the desired routine: ");
            string option = Console.ReadLine();

            Console.WriteLine("-------------------------");

            switch (option)
            {
                case "1":
                    factory = new MondayThursdayFactory();
                    break;
                case "2":
                    factory = new TuesdayFridayFactory();
                    break;
                case "3":
                    factory = new WednesdaySaturdayFactory();
                    break;
                default:
                    break;
            }

            Console.Write("Do you want to see another routine? (1-Yes or 2-No): ");
            var response = Convert.ToInt32(Console.ReadLine());

            continueRunning = response == 1;
        }
    }
}
