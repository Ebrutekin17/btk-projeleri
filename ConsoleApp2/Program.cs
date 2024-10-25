Console.Write("boyunuz kaç?");
double boy = double.Parse(Console.ReadLine());

Console.Write("kilonuz kaç?");
double kilo = Convert .ToDouble(Console.ReadLine());

double boy2 = boy / 100;
double vki = kilo / (boy2 * boy2);
Console.WriteLine($"vki değeri={vki}");

if (vki < 18.5)
    Console.WriteLine("zayıf");
else if (vki >=18.5 && vki<25)
    Console.WriteLine("normal");
else if (vki >= 25 && vki < 30)
    Console.WriteLine("kilolu");
else if (vki >= 30 )
    Console.WriteLine("aşırı kilolu");
