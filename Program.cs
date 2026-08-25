using System.Security.Cryptography;

Console.WriteLine("================================");
Console.WriteLine("        ROLAGEM DE DADO");
Console.WriteLine("================================");

int faces;

while (true)
{
    Console.Write("\nQuantas faces o dado possui? ");

    if (int.TryParse(Console.ReadLine(), out faces) && faces >= 2)
    {
        break;
    }

    Console.WriteLine("Digite um número inteiro maior ou igual a 2.");
}

Console.WriteLine("\nDado criado com sucesso!");
Console.WriteLine($"Quantidade de faces: {faces}");

string resposta;

do
{
    int sorteado = RandomNumberGenerator.GetInt32(1, faces + 1);

    Console.WriteLine("\n--------------------------------");
    Console.WriteLine($"Resultado da rolagem: {sorteado}");
    Console.WriteLine("--------------------------------");

    Console.Write("\nDeseja rolar novamente? (S/N): ");
    resposta = Console.ReadLine()?.ToUpper() ?? "N";

}
while (resposta == "S");

Console.WriteLine("\n================================");
Console.WriteLine("Obrigado por utilizar o programa!");
Console.WriteLine("================================");

