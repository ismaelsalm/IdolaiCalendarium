// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Reflection.PortableExecutable;
using IdolaiCalendarium;

int nullJahr = -2570;
Console.Clear();
Console.WriteLine("input the operation");
Console.WriteLine("s - Search for a nullJahr");
Console.WriteLine($"dd/mm/yy - to convert a date using the nullJahr: {nullJahr}");
string? input = Console.ReadLine();

if(input == "s"){
    //search for nullJahr
    for (int i = 1800; i < 3000; i++)
    {
        IdolaiDateConverter converter = new IdolaiDateConverter(-i);
        IdolaiDate idolaiDate = converter.Convert(new DateTime(2001,6,7));
        if(idolaiDate.Month == 1 && idolaiDate.ZodiacYear == ZodiacYear.Kindori){
            Console.WriteLine();
            Console.WriteLine($"NullJahr: {i}");
            Console.WriteLine($"Ismael: {idolaiDate}");
            Console.WriteLine($"Jo: {converter.Convert(new DateTime(2001,10,13))}");
            Console.WriteLine($"Adolfo: {converter.Convert(new DateTime(1995,11,17))}");
        }
    }
    return;
}

if(input != null){
    string[] strings = input.Split('/');
    int[] numbers = [1,1,1];
    for (int i = 0; i < 3; i++)
    {
        if(int.TryParse(strings[i], out int number)){
            numbers[i] = number;
        }
    }

    IdolaiDateConverter converter = new IdolaiDateConverter(nullJahr);
    Console.WriteLine(converter.Convert(new DateTime(numbers[2], numbers[1], numbers[0])));
    Console.WriteLine( converter.ConvertAddDay(new DateTime(numbers[2], numbers[1], numbers[0])));
}