using NET23_DesignLabb1.Factory;
using NET23_DesignLabb1.Singleton;
using NET23_DesignLabb1.Strategy;
using NET23_DesignLabb1.Strategy.ConcreteStrategies;

//I've implemented the design patterns Factory, Strategy and Singleton.

//Create singleton objects and output data
ImportantData data1 = ImportantData.GetImportantData();
ImportantData data2 = ImportantData.GetImportantData();

data1.ShowImportantData();
data2.ShowImportantData();
Console.WriteLine("\n\n");
//-----------------------------------------------------------------------------------------------------

//Initialize calculator
var calculator = new CalculatorContext();
var userInput = "0";

//Code to let user select calculator options
while (userInput is not ("1" or "2" or "3"))
{
    Console.WriteLine("Select calculator mode:\n1. Add\n2. Subtract\n3. Multiply");
    userInput = Console.ReadLine();

    //Set corresponding strategy
    switch (userInput)
    {
        case "1":
            calculator.SetCalculator(new CalculatorAdd());
            Console.WriteLine("Addition selected\n");
            break;

        case "2":
            calculator.SetCalculator(new CalculatorSubtract());
            Console.WriteLine("Subtraction selected\n");
            break;

        case "3":
            calculator.SetCalculator(new CalculatorMultiply());
            Console.WriteLine("Multiplication selected\n");
            break;

        default:
            Console.WriteLine("Invalid input\n");
            break;
    }
}

//Get user input
var firstNumber = HandleCalculatorInput("first");
var secondNumber = HandleCalculatorInput("second");

int HandleCalculatorInput(string number)
{
    //Code to handle user input of numbers
    while (true)
    {
        Console.WriteLine($"Enter {number} number:");
        var userInput = Console.ReadLine();

        if (int.TryParse(userInput, out int i))
        {
            return i;
        }

        Console.WriteLine("Invalid input, try again.");
    }
}

//Call method
calculator.MakeMathHappen(firstNumber, secondNumber);
Console.WriteLine("\n\n");
//-----------------------------------------------------------------------------------------------------

var factoryFactory = new Factory();
IFactory factory = factoryFactory.BuildFactory();
factory.Construct();