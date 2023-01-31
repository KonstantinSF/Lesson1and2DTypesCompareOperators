// See https://aka.ms/new-console-template for more information
//Console.WriteLine(@"Hello, World!\n and what?");

//#define TASK1
//#define TASK2
//#define TASK3
//#define TASK4

#if TASK1

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

#if TASK2 //number and percent

Console.WriteLine("Enter a number to calculate a percent%: ");
double number = Convert.ToInt32 (Console.ReadLine());
Console.WriteLine("Enter a percent: "); 
sbyte percent = Convert.ToSByte(Console.ReadLine());
double result = number *percent/100;
Console.WriteLine($"{percent}% from {number} is {result}");

#endif

#if TASK3
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

#if TASK4

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