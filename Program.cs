Console.WriteLine("gender");
var gender = Console.ReadLine();
Console.WriteLine("age");
var age = int.Parse(Console.ReadLine());

if (gender == "m" && age <= 18)
{
    Console.WriteLine("Boy");
}
else if (gender == "m" && age > 18)
{
    Console.WriteLine("Mr");
}
if (gender == "f" && age <= 18);
{
    Console.WriteLine("Girl");
}
if (gender == "f" && age > 18)
{
    Console.WriteLine("Ms");
}