Random random = new Random();
int numeroSecreto = random.Next(1, 11);

int numeroTentativa;
do
{
    Console.WriteLine("\nDigite um número: ");
    String input = Console.ReadLine();

    Boolean valido = Int32.TryParse(input, out numeroTentativa);

    if (!valido)
    {
        Console.WriteLine("Número inválido.");
        continue;
    }

    if (numeroSecreto != numeroTentativa)
    {
        Console.WriteLine("Número errado.");
        continue;
    }

    Console.WriteLine("\nParabéns, você acertou o número: " + numeroSecreto);
} while (numeroSecreto != numeroTentativa);

