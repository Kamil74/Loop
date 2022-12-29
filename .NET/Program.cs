
internal class Program
{
    private static void Main(string[] args)
    {
        string[] cars = { "Volvo", "BMW", "Mazda" };
        Console.WriteLine(cars[0]);
        int arrayLenght = cars.Length;
        cars[2] = "Tesla";
        Console.WriteLine(cars[cars.Length - 1]);


        Console.WriteLine("************************");


        string[] cars1 = { "Volvo", "BMW", "Mazda" };
        int i = 0;
        while (i < cars1.Length)
        {
            Console.WriteLine(cars1[i]);
            if (cars1[i] == "BMW")
            {
                Console.WriteLine("Bay");
                break;
            }
            i++;
        }

        for (int j = 0; j < cars.Length; j++)
        {
            Console.WriteLine(cars1[j]);
            if (cars1[j] == "BMW")
            {
                Console.WriteLine("Bay");
                break;
            }
        }

        foreach (string car in cars)
        {
            Console.WriteLine(car);
            if(car == "BMW")
            {
                Console.WriteLine("Bay");
                break;
            }
        }




        Console.WriteLine("*********************");


        Console.WriteLine("To exit, type 'x'");
        string userImput;
        do
        {
            userImput = Console.ReadLine();
            Console.WriteLine($"Echo: {userImput}");
        } while (userImput != "x");

        Console.WriteLine("******************************");



        }
}
