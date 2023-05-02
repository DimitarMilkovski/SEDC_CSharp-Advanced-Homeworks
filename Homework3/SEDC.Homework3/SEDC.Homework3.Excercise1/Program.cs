

using Newtonsoft.Json;
using SEDC.Homework3.Domain;
using SEDC.Homework3.Domain.Models;

string appPath = @"..\..\..\";
string folderPath = appPath + @"DataBase\";
string filePath = folderPath + "jsonFile.json";

ReaderWriter readerWriter = new ReaderWriter();

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("Folder was created!");
}

if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
    Console.WriteLine("New file was created!");
}

while (true)
{

    Console.WriteLine();

    Console.WriteLine("Creating new dog with Name, Age and Color: ");

    Console.Write("Please enter the name of the dog: -->");
    string dogName = Console.ReadLine();

    Console.Write("Please enter the Age of the dog: -->");
    bool isNumber = int.TryParse(Console.ReadLine(), out int dogAge);

    if (!isNumber)
    {
        Console.WriteLine("wrong entry, please try again!");
        continue;
    }
    
    Console.Write("Please enter the Color of the dog: -->");
    string dogColor = Console.ReadLine();

    Dog newDog = new Dog (dogName, dogAge, dogColor);
    string dogObjectString = JsonConvert.SerializeObject(newDog);

    readerWriter.Writer(filePath,dogObjectString);


    Console.WriteLine("new dog was created!");

    Console.WriteLine("Do you want to enter a new dog? (y/n) ");
    Console.WriteLine("Else the program will exit with listing all the dogs written in the json file.");

    string userInput = Console.ReadLine();
    if (userInput.ToLower() == "y")
    {
        continue;
    }
    else
    {
        string jsonFilleContent =  readerWriter.Reader(filePath);

        var listOfDogs = JsonConvert.DeserializeObject<List<Dog>>(jsonFilleContent);

        Console.WriteLine("List of all Dogs:");
        int counter = 1;
        foreach (Dog dog in listOfDogs)
        {
            
            Console.WriteLine($"{counter}) Name: {dog.Name}, Age: {dog.Age}, Color: {dog.Color}");
            counter++;
        }

        break;
    }
}



