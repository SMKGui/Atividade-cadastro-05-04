Console.WriteLine($"Digite seu nome: ");
string nome = Console.ReadLine()!;

while (nome == "")
{
    Console.WriteLine($"Digite novamente!");
    nome = Console.ReadLine()!;
}

Console.WriteLine($"Digite sua idade: ");
int idade = int.Parse (Console.ReadLine()!);

while (idade < 0 || idade > 100)
{
    Console.WriteLine($"Digite novamente!");
    idade = int.Parse (Console.ReadLine()!);
}

Console.WriteLine($"Digite seu salario");
float salario = float.Parse (Console.ReadLine()!);

while (salario <= 0)
{
    Console.WriteLine($"Digite novamente!");
    salario = float.Parse (Console.ReadLine()!);
}

Console.WriteLine(@$"Indique seu estado civil:
(s) Solteiro
(c) Casado
(v) Viúvo
(d) Divorciado
");

char civil = char.Parse (Console.ReadLine()!);

while (civil != 's' && civil != 'c' && civil != 'v' && civil != 'd')
{
    Console.WriteLine($"Digite novamente!");
    civil = char.Parse(Console.ReadLine().ToUpper());
}
