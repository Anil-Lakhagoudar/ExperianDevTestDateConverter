// See https://aka.ms/new-console-template for more information
using DateConverter;

Console.WriteLine("Date convert");

/// <summary>
/// global variables
/// </summary>
string dateInput = string.Empty;
int numberOfDays = 0;

Console.WriteLine("Enter date: ");
dateInput = Console.ReadLine();

Console.WriteLine("Enter number of days to be added: ");
numberOfDays = Convert.ToInt32(Console.ReadLine());

string outDate = DateConvert.Convert(dateInput, numberOfDays);
Console.WriteLine(string.Format("New Date: {0}", outDate));

Console.ReadKey();