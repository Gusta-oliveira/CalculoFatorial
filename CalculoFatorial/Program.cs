int factor, aux_calc;

Console.Write("Informe numero a ser fatorado: ");
factor = int.Parse(Console.ReadLine());

aux_calc = factor;
Console.WriteLine($"Você desejou ver {factor}!");
Console.Read();
while (factor > 1)
{
    Console.Write($"{factor} X ");
    aux_calc = aux_calc * (factor - 1);
    factor--;
}
Console.Write($"{factor} = {aux_calc}");
Console.Read();