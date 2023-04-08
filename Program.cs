// name,age and education information will be taken from user and suitability will be checked for driver licence

Console.Write("Name : ");
string name = Console.ReadLine();

Console.Write("Age : ");
int age = int.Parse(Console.ReadLine());


if (age>=18)
{
    Console.WriteLine("Age is available, check education information.");

    Console.Write("Education : ");
    string education = Console.ReadLine();

    if (education == "High School" || education == "University")
    {
        Console.Write("Education is available");

    }
    else
    {
        Console.Write("Education is not available");

    }
}
else
{
    Console.Write("Age is not available.");
}
