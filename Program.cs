// while loop
int number=11;
while (number>=10&&number<=99)
{
Console.Write("Hello User, enter a number between 10 and 99: ");
number = Convert.ToInt32(Console.ReadLine());
int result1=number%23;
int result2=number%2;
if (result1==0 && result2==0)
{
    Console.BackgroundColor=ConsoleColor.Green;
    Console.Clear();
}
else if (result1==0&&result2>0)
{
    Console.BackgroundColor=ConsoleColor.Red;
    Console.Clear();
}
else if (number<=10||number>99)
{
Console.WriteLine("That is not a number bewteen 10 and 99. Try again");
continue;
}
string exit =Convert.ToString(number);
if (exit=="Exit"|| exit=="exit")
    Console.WriteLine("Thanks for playing");
break;
}

// do while loop
int number1;
do 
{
Console.Write("Hello User, enter a number between 10 and 99: ");
number1 = Convert.ToInt32(Console.ReadLine());
int result3=number1%34;
int result4=number1%2;
if (result3==0 && result4==0)
Console.BackgroundColor=ConsoleColor.Green;
else if (result3==0&&result4>0)
{
Console.BackgroundColor=ConsoleColor.Red;
}
string exit1 =Convert.ToString(number1);
if (exit1=="Exit"|| exit1=="exit")
{
Console.WriteLine("Thanks for playing");
break;
}
}
while (number1>=10&&number1<=99);

// for loop
for (int number2=11;number2>=10&&number2<=99;)
{
Console.Write("Hello User, enter a number between 10 and 99: ");
number2 = Convert.ToInt32(Console.ReadLine());
int result5=number2%33;
int result6=number2%2;
if (result5==0 && result6==0)
Console.BackgroundColor=ConsoleColor.Green;
else if (result5==0&&result6>0)
Console.BackgroundColor=ConsoleColor.Red;
string exit2 =Convert.ToString(number2);
if (exit2=="Exit"|| exit2=="exit")
Console.WriteLine("Thanks for playing");
break;
}

