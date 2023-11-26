Console.Clear();

int numero;

Console.WriteLine();
Console.Write("Digite um número e se quiser sair digite 0: ");
numero = Convert.ToInt32(Console.ReadLine());

while (numero < 0 || numero > 9)
{
    Console.Write("Só digite números entre 1 e 9 ou 0 se quiser sair: ");
    numero = Convert.ToInt32(Console.ReadLine());
}

if (numero == 0)
{
    Console.WriteLine("Tchau, volte sempre");
}
else
{
    Console.WriteLine("......");
    Thread.Sleep(1500);
    Console.WriteLine($"O número selecionado foi {numero}");
}