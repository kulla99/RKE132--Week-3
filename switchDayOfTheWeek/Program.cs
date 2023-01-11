int weekDay = Convert.ToInt32(DateTime.Now.DayOfWeek); //0-6

switch (weekDay)
{
    case 0:
        Console.WriteLine("its sunday");
        break;
    case 1:
        Console.WriteLine("its monday");
        break;
    case 2:
        Console.WriteLine("its tuesday");
        break;
    case 3:
        Console.WriteLine("its wendsday");
        break;
    case 4:
        Console.WriteLine("its thursday");
        break;
    case 5:
        Console.WriteLine("its friday");
        break;
    case 6:
        Console.WriteLine("its saturday");
        break;
    default:
        Console.WriteLine("Oops, your caander must be broken");
        break;
}

Console.WriteLine("have a nice day!");