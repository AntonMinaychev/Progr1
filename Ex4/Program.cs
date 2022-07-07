Console.WriteLine("Insert number");
int number = int.Parse(Console.ReadLine());

while (number > 0)
{
    if (number%2 == 0)
        {Console.WriteLine(number);}
    number--;
}