Console.WriteLine("Insert first number");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Insert second number");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Insert third number");
int c = int.Parse(Console.ReadLine());



if (a > b & a > c)

{
    Console.WriteLine("Biggest is ");
    Console.Write(a);
}

else

if (b > a & b > c)
{
    Console.WriteLine("Biggest is ");
    Console.Write(b);
}

else 
{
    Console.Write(c);
}