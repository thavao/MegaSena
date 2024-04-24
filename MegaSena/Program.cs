int qtdNumerosPremiados = 6, aux, maximoSorteado = 98;
int[] numerosPremiados = new int[qtdNumerosPremiados];
bool existeRepetido;
int contadorLacos = 0;
int i = 0, j = 0;

for (i = 0; i < qtdNumerosPremiados; i++)
{
    numerosPremiados[i] = new Random().Next(0, maximoSorteado + 1);
}

int anterior = 0;
do
{
    existeRepetido = false;

    //ordena o vetor em ordem crescente
    for (i = 0; i < qtdNumerosPremiados; i++)
    {
        for (j = i + 1; j < qtdNumerosPremiados; j++)
        {
            if (numerosPremiados[i] > numerosPremiados[j])
            {
                aux = numerosPremiados[i];
                numerosPremiados[i] = numerosPremiados[j];
                numerosPremiados[j] = aux;
            }
        }
    }
    //verifica se existe algum valor repetido
    for (i = 0; i < qtdNumerosPremiados; i++)
    {
        if (anterior == numerosPremiados[i] && i != 0)
        {
            existeRepetido = true;
            i = qtdNumerosPremiados - 1;
        }


        anterior = numerosPremiados[i];
    }

    //gera um novo numero caso ele esteja repetido
    if( existeRepetido )
    for (i = 0; i < qtdNumerosPremiados; i++)
    {
        if (anterior == numerosPremiados[i] && i != 0)
            while (anterior == numerosPremiados[i])
                numerosPremiados[i] = new Random().Next(0, maximoSorteado + 1);


        anterior = numerosPremiados[i];
    }

    contadorLacos++;
} while (existeRepetido);

Console.WriteLine("Números premiados: ");

for (i = 0; i < qtdNumerosPremiados; i++)
{
    Console.Write(numerosPremiados[i] + " ");
}
contadorLacos--;
Console.WriteLine();
Console.WriteLine("Contador de repetições até não existir números repetidos: " + contadorLacos);

Console.WriteLine("Pressione Enter para encerrar...");
Console.ReadLine();