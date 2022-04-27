string str = "############# Wellcome to calculator v 1.0 ###############";
Console.SetCursorPosition((Console.WindowWidth - str.Length) / 2, Console.CursorTop); // это загуглил 
Console.WriteLine(str);
Console.ForegroundColor = ConsoleColor.Green;

double firstnumber; //калькулятор решил сделать со значениями double, а не int, так будет покорректнее считать.
double secondnumber;
double result = 0;
bool isRuning = true;

while (isRuning)
{
    Console.Write("enter the first number: ");
    string input1 = Console.ReadLine();
    bool isSuccessFul = double.TryParse(input1, out firstnumber);

    if (isSuccessFul)
        isRuning = true;
    else
    {
        Console.WriteLine("Invalid input");
        goto Found; // это тож загуглил (знаю что goto зло:))
    }

    Console.Write("enter the second number: ");
    string input2 = Console.ReadLine();
    bool isSuccesFul1 = double.TryParse(input2, out secondnumber);

    if (isSuccesFul1)
        isRuning = true;
    else
    {
        Console.WriteLine("Invalid input");
        goto Found;
    }

    Console.WriteLine("what needs to be done with the numbers?: | + | | - | | * | | / | | % |");
    var symbol = Console.ReadLine();

    switch (symbol)
    {

        case "+":
            result = firstnumber + secondnumber;
            break;
        case "-":
            result = firstnumber - secondnumber;
            break;
        case "*":
            result = firstnumber * secondnumber;
            break;
        case "/":
            result = firstnumber / secondnumber;
            if (secondnumber == 0)
                Console.WriteLine("error, division by zero");
            break;
        case "%":
            result = firstnumber % secondnumber;
            break;
        default:
            Console.WriteLine("incorrect input, try again");
            break;

    }

    Console.WriteLine($"result: {result}");
Found:
    Console.WriteLine("continue Y/N ?");
    string key = Console.ReadLine();

    if (key == "Y" || key == "y" || key == "Н" || key == "н")
        isRuning = true;
    else
    {
        isRuning = false; 
        Console.ForegroundColor = ConsoleColor.Red;
        string str1 = "Create by Alexandr Trushin"; // фича))
        Console.SetCursorPosition((Console.WindowWidth - str1.Length) / 2, Console.CursorTop);
        Console.WriteLine(str1);
        Console.ResetColor();
    }
}