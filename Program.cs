using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
Console.Clear();

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
    bool maiorOuMenor = Math.Sign(erro) == -1;
    if (!acertou)
    {
        tentativa++;

        if(distanciaErro <= 3)
        {
            Colorir("Pelando\n", ConsoleColor.Red);
        }
        else if(distanciaErro <= 10)
        {
            Colorir("Quente\n", ConsoleColor.DarkRed);
        }
        else if(distanciaErro >= 30)
        {
            Colorir("Congelando\n", ConsoleColor.DarkBlue);
            
            Console.Write("tente um número mais ");
            Colorir(maiorOuMenor ? "alto" : "baixo", maiorOuMenor ? ConsoleColor.DarkYellow : ConsoleColor.DarkMagenta);
            Console.WriteLine(".");
        }
        else
        {
            Colorir("Frio\n", ConsoleColor.Blue);
            
            Console.Write("tente um número mais ");
            Colorir(maiorOuMenor ? "alto" : "baixo", maiorOuMenor ? ConsoleColor.DarkYellow : ConsoleColor.DarkMagenta);
            Console.WriteLine(".");
        }
            

         
    }

  
if(tentativa == 8 && !acertou)
{
    Console.Write($"\nO número que escolhi era {sorteado}");
    return;
}
else if(acertou)
{
    Console.WriteLine("\nParabéns você acertou o numero sorteado!");
    return;
}
}

void Colorir(string texto, ConsoleColor cor)
{
    Console.ForegroundColor = cor;
    Console.Write(texto);
    Console.ResetColor();
}