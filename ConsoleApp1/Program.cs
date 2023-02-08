// See https://aka.ms/new-console-template for more information
//Console.WriteLine(@"Hello, World!\n and what?");
using static System.Console;
//#define TASK1
//#define TASK2
//#define TASK3
//#define TASK4
//#define TASK5
//#define TASK6


//TASK1
#if false

Console.WriteLine("Enter a number between 1 and 100: ");
String numberStr = Console.ReadLine();
int number = Convert.ToInt32(numberStr);
//Console.WriteLine(number);
Console.Write("Result: ");
if (number < 1 || number > 100) Console.WriteLine("U wrote a wrong number");
else if (number % 3 == 0 && number % 5 == 0) Console.WriteLine("FizzBuzz");
else if (number % 3 == 0) Console.WriteLine("Fizz");
else if (number % 5 == 0) Console.WriteLine("Buzz");
else Console.WriteLine(number);  
#endif

//TASK2 //number and percent
#if false

Console.WriteLine("Enter a number to calculate a percent%: ");
double number = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Enter a percent: "); 
sbyte percent = Convert.ToSByte(Console.ReadLine());
double result = number *percent/100;
Console.WriteLine($"{percent}% from {number} is {result}");

#endif

//TASK3
#if false
string[] Digit = new string[4];
for (int i = 0; i < 4; i++)
{
    if (i == 0) Console.WriteLine("Enter a first digit: ");
    else Console.WriteLine("Enter a next digit");
    Digit[i] =  Console.ReadLine(); 
}
Console.WriteLine("The hole number is: ");
foreach (string item in Digit) Console.Write(item);
#endif

//TASK4
#if false

Console.WriteLine("Enter a 6-digit number: ");
String numberString = Console.ReadLine();
Char [] numberChar = new char[6];
numberChar = numberString.ToCharArray();

if (numberChar.Length!=6)Console.Write("Input Error");//Check the number of digit in number

foreach (char item in numberChar)//check the INPUT is Digit?
{
    if (!Char.IsDigit(item))
    {
        Console.WriteLine("Input Error"); break;
    }
}
Console.WriteLine("Enter number of the first digit for replacing: ");
sbyte firstDigit = Convert.ToSByte(Console.ReadLine());
Console.WriteLine("Enter number of the second digit for replacing: ");
sbyte secondDigit = Convert.ToSByte(Console.ReadLine());
char buffer;
                     buffer = numberChar[firstDigit - 1]; 
 numberChar[firstDigit - 1] = numberChar[secondDigit - 1]; 
numberChar[secondDigit - 1] = buffer;

foreach (char item in numberChar) Console.Write(item);
//for (int i = 0; i < 256; i++)
//{
//    char c = (char)i;
//    Console.Write($"{i} = {c} \t"); //digit 48-57
//}
#endif

//TASK5
#if false
Console.WriteLine("Enter a date in format: dd.mm.yyyy"); 
string date = Console.ReadLine();
DateTime dateDateTime = DateTime.Parse(date);
//Console.WriteLine(dateDateTime); //12.08.1985 0:00:00
int month = dateDateTime.Month;
String season = null;
if (month >= 3 && month < 6) season = "spring";
else if (month is >= 6 and < 9) season = "summer";
else if (month >= 9 && month < 12) season = "autumn";
else season = "winter"; 
Console.WriteLine($"\nThe season is {season}, the day of week is {dateDateTime.DayOfWeek}");
#endif

//TASK6
#if false

Console.WriteLine("Enter a temperature in degreese of Celsium: \"xxxxC\" or Farenheit: \"xxxxF\"");
String temperatureString = Console.ReadLine();
bool isCelsium = temperatureString.Contains('C')||temperatureString.Contains('c');
Char[] temperatureChar = new char [5]; 
temperatureChar = temperatureString.ToCharArray();
double temperature = 0;
int firstDigit = 0;
if (!char.IsDigit(temperatureChar[0])) firstDigit = 1;
int numberOfDigit = -1; 
foreach (char c in temperatureChar)
{
    if (Char.IsDigit(c)) numberOfDigit++;
}
for (int i =firstDigit; i<4; i++)
{
    if (Char.IsDigit(temperatureChar[i]))
        temperature += (int)Char.GetNumericValue(temperatureChar[i]) * (int)Math.Pow(10, numberOfDigit);
    else break; 
    numberOfDigit--; 
}
if (!Char.IsDigit(temperatureChar[0])) temperature *= -1;  
//Console.WriteLine($"{temperature}"); 
if (isCelsium)
{
    temperature = 1.8 * temperature + 32; // in Farenheit
    Console.WriteLine($"Temperature in Farenheit is {temperature} F"); 
}
else
{
    temperature = (temperature - 32)/1.8;//in Celsium
    Console.WriteLine($"Temperature in Celsium is {temperature} C"); 
}
#endif

//TASK7
#if true

//string Check = "hello world";
//Write(Check); 
//char[] Checked  = new char[] {}; 
//Checked = Check.ToCharArray() ;
//for (int i = 0; i < 11; i++)Write($"{Checked[i]}\t");

WriteLine("Enter a two integer numbers as a boreder of the Span:");
string Num1 = ReadLine(); 
string Num2 = ReadLine();
int.TryParse(Num1, out int _num1); 
int.TryParse(Num2, out int _num2);
int NumOfEven = 0;
if (_num1 > _num2)
{
    int buf = _num1; _num1 = _num2; _num2 = buf;
}
for (int i = _num1 + 1; i < _num2; i++)
{
        if (i % 2 == 0)
        {
            Write("{0}\t", i); 
            NumOfEven++;
        }
}
WriteLine(); 
WriteLine("Number of Even in Span is {0}", NumOfEven); 
//WriteLine("{0} {1}", Num1, Num2 ); 
//Write(_num1 is int); 

#endif