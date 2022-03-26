double m ,kg, IMC;

Console.WriteLine("Digite a Altura (m)..:");
m = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Digite o seu peso (kg))..:");
kg = Convert.ToDouble(Console.ReadLine()!);

IMC = (kg / (Math.Pow(m,2)));

Console.WriteLine($"IMC:{IMC}kg/m²");