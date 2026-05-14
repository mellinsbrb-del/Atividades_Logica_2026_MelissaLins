
string nomeJogador;
string escolhaJogador;
int escolhaRobo; // O robô vai escolher um número de 1 a 3
int oxigenio = 100;

Console.WriteLine("DESAFIO DO GUARDA ROBÔ");
Console.WriteLine("Para passar pela porta da Fase 2, você deve vencer o Robô no Jokenpô!");
nomeJogador = Console.ReadLine(); // INTERAÇÃO (Requisito 2)

Console.Clear();
Console.WriteLine("Comandante " + nomeJogador + ", escolha sua arma:");
Console.WriteLine("1 - Laser");
Console.WriteLine("2 - Escudo");
Console.WriteLine("3 - Espada");
Console.Write("Sua escolha: ");
escolhaJogador = Console.ReadLine();

// O Robô escolhe aleatoriamente (1, 2 ou 3)
Random gerador = new Random();
escolhaRobo = gerador.Next(1, 4);


if (escolhaRobo == 1) Console.WriteLine("O Robô escolheu: Laser");
if (escolhaRobo == 2) Console.WriteLine("O Robô escolheu: Escudo");
if (escolhaRobo == 3) Console.WriteLine("O Robô escolheu: Espada");

if (escolhaJogador == escolhaRobo.ToString())
{
    Console.WriteLine("\EMPATE! Os sistemas travaram. Você perdeu um pouco de oxigênio tentando de novo.");
    oxigenio = oxigenio - 5;
}
else if ((escolhaJogador == "1" (escolhaRobo == 3) ||
         (escolhaJogador == "2" ( escolhaRobo == 1) ||
         (escolhaJogador == "3" ( escolhaRobo == 2))
{
    Console.WriteLine("\VITÓRIA! O robô desliga e a porta se abre. Você avança intacto!");
}
else
{
    Console.WriteLine("\nDERROTA! O robô te deu um choque. Você perdeu 20% de oxigênio!");
    oxigenio = oxigenio - 20;
}

Console.WriteLine("Oxigênio atual: " + oxigenio + "%");
Console.WriteLine("\Pressione Enter para a fase final...");
Console.ReadLine();