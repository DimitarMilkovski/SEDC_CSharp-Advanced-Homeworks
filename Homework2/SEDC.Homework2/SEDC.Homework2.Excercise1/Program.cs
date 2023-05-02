


string appPath = @"..\..\..\";
string excerciseFolderPath = appPath + @"Excercise\";
string filePath = excerciseFolderPath + "calculations.txt";

if (!Directory.Exists(excerciseFolderPath))
{
    Directory.CreateDirectory(excerciseFolderPath);
    Console.WriteLine("Folder - Excercise Folder' was created!");
}

if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
    Console.WriteLine("New file was created!");
}

string sumTwoNumbers (int num1, int num2)
{
    return $"{num1} + {num2} = {num1 + num2}";
}

int ValidateNumber(string input)
{
    bool isValid = int.TryParse(input, out int choice);
    if (!isValid)
    {
        Console.WriteLine("Invalid Input...");
        Console.ReadKey();
        return -1;
    }

    return choice;
}

while (true)
{
    Console.WriteLine("======== Calculate 2 numbers ==========");
    Console.WriteLine();

    Console.Write("Please enter the first number -->");
    int firstNumber = ValidateNumber(Console.ReadLine());

    Console.Write("Please enter the second number -->");

    int secondNumber = ValidateNumber(Console.ReadLine());

    if (firstNumber < 0 || secondNumber < 0)
    {
        Console.WriteLine("Wrong entry! please try again");
        continue;
    }

    string result = sumTwoNumbers(firstNumber, secondNumber);
    Console.WriteLine($"Calculation: {result}");

    using (StreamWriter sw = new StreamWriter(filePath,true))
    {
        sw.WriteLine($"{result}  --> {DateTime.Now.ToString("dd/MM/yyyy H:mm:ss")}");
    }

    Console.WriteLine();

    Console.WriteLine("Do you want to enter new calculation? y/n");

    string userInput = Console.ReadLine();
    if(userInput.ToLower() == "y")
    {
        continue;
    }
    else
    {
        break;
    }



}
