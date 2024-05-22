using System.Security.Cryptography;

Console.WriteLine("----QuenteFrio----");
Console.WriteLine("\nTente acertar o número sorteado pelo jogo de 1 A 100");
Console.WriteLine("Você terá 7 tentativas para acertar!\n");


int palpite = 0;
int tentativa = 1;
int sorteado;
bool acertou = false;
sorteado = RandomNumberGenerator.GetInt32(1, 101);

while(palpite != sorteado)
{
    Console.Write($"De seu palpite #{tentativa} ");
    palpite = Convert.ToInt32(Console.ReadLine());

    int erro = palpite - sorteado;
    int distanciaErro = Math.Abs(erro);
    acertou = (palpite == sorteado);

    if (!acertou)
    {
        tentativa++;

        if(distanciaErro <= 3)
        {
            Console.WriteLine("Pelando");
        }
        else if(distanciaErro <= 10)
        {
            Console.WriteLine("Quente");
        }
        else if(distanciaErro >= 30)
        {
            Console.WriteLine("Congelando");
        }
        else
        {
            Console.WriteLine("Frio");
        }
    }

  
if(tentativa == 8 && !acertou)
{
    Console.Write($"\nO número que escolhi era {sorteado}");
    return;
}
}