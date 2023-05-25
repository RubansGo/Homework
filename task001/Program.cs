int FirstNumber = 0;
int SecondNumer = 0;
Console.WriteLine("Get first numbers");
FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Get second numbers");
SecondNumer = Convert.ToInt32(Console.ReadLine());
if (FirstNumber > SecondNumer)
{
    Console.WriteLine("Greater number: " + FirstNumber);
    Console.WriteLine("Smaller number: " + SecondNumer);
}
else 
{
    Console.WriteLine("Greater number: " + SecondNumer);
    Console.WriteLine("Smaller number: " + FirstNumber);
}