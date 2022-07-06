int numeroAnterior = 0;
int numeroAtual = 1;
int fibonacci;
bool loop = true;

void Fibonacci(int numeroRecebido)
{
    while (loop)
    {
        fibonacci = numeroAnterior + numeroAtual;
        numeroAnterior = numeroAtual;
        numeroAtual = fibonacci;
        if (fibonacci == numeroRecebido)
        {
            Console.WriteLine($"\n O numero {numeroRecebido} existe na sequencia Fibonacci");
            loop = false;
        }
        else if (numeroRecebido < fibonacci)
        {
            Console.WriteLine($"\n O numero {numeroRecebido} não existe na sequencia Fibonacci");
            loop = false;
        }
    }
}


Console.Write("Digite um numero para verificar se ele esta presente na sequencia de Fibonacci: ");
Fibonacci(int.Parse(Console.ReadLine()));