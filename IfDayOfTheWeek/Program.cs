
int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek);

if(weekDay == 0)
{
    Console.WriteLine("It´s Sunday!");
}
else if(weekDay == 1)
{
    Console.WriteLine("Its Monday!");
}
else if (weekDay == 2)
{
    Console.WriteLine("Its Tuesday");
}
else if (weekDay == 3)
{
    Console.WriteLine("its wendsday");
}
else if (weekDay == 4)
{
    Console.WriteLine("its thursday");
}
else if (weekDay == 5)
{
    Console.WriteLine("its friday");
}
else
{
    Console.WriteLine("its saturday");
}    
Console.WriteLine("have a nice day");

