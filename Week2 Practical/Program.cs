// Week 2 Practical 
// Clare Hamilton B00882634

Main();

void Main()
{
    PrintMenu();
    InputOption();
}

// Task 1: Create PrintMenu Method
void PrintMenu()
{
    Console.WriteLine("Please enter a valid option from below:");
    Console.WriteLine("1. Hello in French?");
    Console.WriteLine("2. Hello in Spanish?");
    Console.WriteLine("3. Hello in German?");
    Console.WriteLine("4. Hello in Italian?");
    Console.WriteLine("0. Exit Application");
}

//Task 2: Create GetOption Method
void InputOption() {

    int choice = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"You have chosen: {choice}");

    // try catch to catch any errors
    try
    {

        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                French();
                break;
            case "2":
                Spanish();
                break;
            case "3":
                German();
                break;
            case "4":
                Italian();
                break;
            default:
                Console.WriteLine("Invalid choice. Please try again.");
                break;

        }
    }
    catch
    {


    }


    static void French()
    {

    }

    static void Spanish()
    {

    }

    static void German()
    {

    }

    static void Italian()
    {

    }

}
