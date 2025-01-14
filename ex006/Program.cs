// See https://aka.ms/new-console-template for more information

Console.WriteLine("digite um numero");
int num1 = int.Parse(Console.ReadLine());

Console.WriteLine("digite outro numero");
int num2 = int.Parse(Console.ReadLine());

Console.Clear();
Console.WriteLine("=================");
Console.WriteLine("=================");
Console.WriteLine("=================");


Console.WriteLine($"A adição é: {num1 + num2} ");
Console.WriteLine($"A subtração é: {num1 - num2} ");
Console.WriteLine($"A multiplicação é: {num1 * num2} ");

if (num2 != 0)
{
    Console.WriteLine("/ : " + (num1 / num2));
}
else
{
    Console.WriteLine("/ : DIVISÃO POR ZERO NÃO É POSSIVEL");

}
Console.WriteLine("=============");
Console.WriteLine("os numeros são iguais " + (num1 = num2));
Console.WriteLine("numero 1 é maior que numero 2" + (num1 < num2));
Console.WriteLine("numero 1 é menor que numero 2" + (num1 > num2));
Console.WriteLine("numero 1 é maior igual ao numero 2 " + (num1 >= num2));
Console.WriteLine("numero 1 é menor igual ao numero 2 " + (num1 <= num2));