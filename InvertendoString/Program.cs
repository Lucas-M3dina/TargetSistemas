string recebidoUsuario;
char[] recebidoArray;
string invertida = "";

Console.Write("Digite uma palavra a ser invertida: ");
recebidoUsuario = Console.ReadLine();

recebidoArray = recebidoUsuario.ToCharArray();

for (int i = recebidoArray.Length - 1; i >= 0; i--)
{
    invertida += recebidoArray[i].ToString();
}

Console.Write(invertida);