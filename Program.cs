
// while loop
Console.WriteLine("While Loop");
Console.WriteLine("Type 'exit' if you want to end the loop");
while (true)
{
Console.Write("Hello User, enter a number between 10 and 99: ");
string? answer=Console.ReadLine();
    if (answer == "exit" || answer == "Exit")
    {
    Console.WriteLine("THANKS FOR PLAYING");
    break;
    }
int number = Convert.ToInt32(answer);
if (number % 23 == 0)
{
    Console.BackgroundColor=ConsoleColor.Green;
    Console.WriteLine("Divisible by 23");
}
else if (number >= 10 && number <= 100)
{
    Console.BackgroundColor=ConsoleColor.Red;
    Console.WriteLine("Not divisible by 23");
}
else 
{
Console.WriteLine("That is not a number bewteen 10 and 99. Try again");
}
}
Console.ResetColor();
// do while loop
Console.WriteLine("Do While");
do 
{
Console.Write("Hello User, enter a number between 10 and 99: ");
string? answer=Console.ReadLine();
    if (answer == "exit" || answer == "Exit")
    {
    Console.WriteLine("THANKS FOR PLAYING");
    break;
    }
int number = Convert.ToInt32(answer);
if (number%34==0)
{
    Console.BackgroundColor=ConsoleColor.Green;
    Console.WriteLine("Divisible by 34");
}
else if (number >= 10 && number <= 100)
{
    Console.BackgroundColor=ConsoleColor.Red;
    Console.WriteLine("Not divisible by 34");
}
else
{
Console.WriteLine("That is not a number bewteen 10 and 99. Try again");
}
}
while(true);
Console.ResetColor();
// for loop
Console.WriteLine("For Looping");
for (string? answer;(true);)
{
Console.Write("Hello User, enter a number between 10 and 99: ");
answer=Console.ReadLine();
    if (answer == "exit" || answer == "Exit")
    {
    Console.WriteLine("THANKS FOR PLAYING");
    break;
    }
int number = Convert.ToInt32(answer);
if (number%33==0)
{
    Console.BackgroundColor=ConsoleColor.Green;
    Console.WriteLine("Divisible by 33");
}
else if (number >= 10 && number <= 100)
{
    Console.BackgroundColor=ConsoleColor.Red;
    Console.WriteLine("Not divisible by 33");

}
else
{
Console.WriteLine("That is not a number bewteen 10 and 99. Try again");
}
}
Console.BackgroundColor=ConsoleColor.Black;
while (true)
{
Console.WriteLine("OPERATIONS MENU.",20);
Console.ForegroundColor=ConsoleColor.Cyan;
Console.WriteLine("1. ADD");
Console.ForegroundColor=ConsoleColor.Yellow;
Console.WriteLine("2. SUBSTRACT");
Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine("3. MULTIPLY");
Console.ForegroundColor=ConsoleColor.Magenta;
Console.WriteLine("4. DIVIDE");
Console.ForegroundColor=ConsoleColor.Red;
Console.WriteLine("5. Exit");
Console.ForegroundColor=ConsoleColor.White;
Console.WriteLine("Press the number of the action you want to do: ");
int choice= Convert.ToInt32(Console.ReadLine());
switch (choice)
{
 case 1:
 while(true)
 {
Console.ResetColor();
Console.WriteLine("Type 'Exit' if you want to go back to the menu.");
 Console.WriteLine("Type the 2 numbers you would like to operate (addition).");
 Console.Write("First number: ");
 string? exit=Console.ReadLine();
 if (exit=="Exit"|| exit=="exit")
 {
 break;
 }
 int number1=Convert.ToInt32(exit);
 Console.Write("Second number: ");
 string? exit1=Console.ReadLine();
 if (exit1=="Exit"|| exit1=="Exit")
 {
 break;
 }
 int number2=Convert.ToInt32(exit1);
Console.ForegroundColor=ConsoleColor.Cyan;
Console.WriteLine($"Result: {number1+number2} ");
 }
 break;

 case 2:
 while(true)
 {
Console.ResetColor();
Console.WriteLine("Type 'Exit' if you want to go back to the menu.");
 Console.WriteLine("Type the 2 numbers you would like to operate (substraction).");
 Console.Write("First number: ");
 string? exit=Console.ReadLine();
 if (exit=="Exit"|| exit=="exit")
 {
 break;
 }
 int number1=Convert.ToInt32(exit);
 Console.Write("Second number: ");
 string? exit1=Console.ReadLine();
 if (exit1=="Exit"|| exit1=="Exit")
 {
 break;
 }
 int number2=Convert.ToInt32(exit1);
Console.ForegroundColor=ConsoleColor.Yellow;
Console.WriteLine($"Result: {number1-number2} ");
 }
 break;

case 3:
 while(true)
 {
    Console.ResetColor();
Console.WriteLine("Type 'Exit' if you want to go back to the menu.");
 Console.WriteLine("Type the 2 numbers you would like to operate (Multiplication).");
 Console.Write("First number: ");
 string? exit=Console.ReadLine();
 if (exit=="Exit"|| exit=="exit")
 {
 break;
 }
 int number1=Convert.ToInt32(exit);
 Console.Write("Second number: ");
 string? exit1=Console.ReadLine();
 if (exit1=="Exit"|| exit1=="exit")
 {
 break;
 }
 int number2=Convert.ToInt32(exit1);
Console.ForegroundColor=ConsoleColor.Green;
Console.WriteLine($"Result: {number1*number2} ");
 }
 break;
 case 4:
 while(true)
 {
    Console.ResetColor();
Console.WriteLine("Type 'Exit' if you want to go back to the menu.");
 Console.WriteLine("Type the 2 numbers you would like to operate (division).");
 Console.Write("First number: ");
 string? exit=Console.ReadLine();
 if (exit=="Exit"|| exit=="exit")
 {
 break;
 }
 int number1=Convert.ToInt32(exit);
 Console.Write("Second number: ");
 string? exit1=Console.ReadLine();
 if (exit1=="Exit"|| exit1=="exit")
 {
 break;
 }
 int number2=Convert.ToInt32(exit1);
Console.ForegroundColor=ConsoleColor.Magenta;
Console.WriteLine($"Result: {number1/number2} ");
 }
 break;
}
if (choice==5)
{
    break;
}
}