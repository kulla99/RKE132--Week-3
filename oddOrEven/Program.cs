

Console.WriteLine("enter a number:");
int userNum = Convert.ToInt32(Console.ReadLine());

//kas kasujtaja arv on paaris või paaritu

int result = userNum % 2;

if(result != 0)
{
    Console.WriteLine("user number is odd");
}else
{
    Console.WriteLine("user number is even");
}