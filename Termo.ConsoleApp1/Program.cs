namespace Termo.ConsoleApp1;

using System.ComponentModel;
using System.Security.Cryptography;

public static class Program
{
    static void Main(string[] args)
    {
        while (true == true)
        {
            string[] ultimasPalavras = new string[0];
            string palavraDigitada = "";
            string palavraParaJogar = "".SortWord();

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║   _____ _____ ____  __  __  ___    ║");
            Console.WriteLine(@"║  |_   _| ____|  _ \|  \/  |/ _ \   ║");
            Console.WriteLine(@"║    | | |  _| | |_) | |\/| | | | |  ║");
            Console.WriteLine(@"║    | | | |___|  _ <| |  | | |_| |  ║");
            Console.WriteLine(@"║    |_| |_____|_| \_\_|  |_|\___/   ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Console.WriteLine("Para sair do jogo, digite 'SAIR'.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Se a letra estiver na posição correta, ela ficará verde.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Se a letra estiver na palavra, mas na posição errada, ela ficará amarela.");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Se a letra não estiver na palavra, ela ficará vermelha.");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");

            while (palavraDigitada != palavraParaJogar && palavraDigitada != "SAIR")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite uma palavra: ");
                palavraDigitada = Console.ReadLine().ToUpper();


                if (palavraDigitada.Length != 0)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("últimas palavras digitadas: " + string.Join(", ", ultimasPalavras) + "\n");
                }


                if (palavraDigitada == "SAIR")
                {
                    Console.WriteLine("Obrigado por jogar!");
                    break;
                }

                if (ultimasPalavras.Contains(palavraDigitada))
                {
                    Console.WriteLine("Você já digitou essa palavra!");
                    continue;
                }

                if (palavraDigitada.Length > palavraParaJogar.Length)
                {
                    Console.WriteLine("A palavra digitada é maior que a palavra para jogar!");
                    continue;
                }

                ultimasPalavras = ultimasPalavras.Append(palavraDigitada).ToArray();

                //laco de repetição para verificar cada letra da palavra digitada e comparar com a palavra para jogar
                for (int i = 0; i < palavraDigitada.Length; i++)
                {
                    //letra na posição correta
                    if (palavraDigitada[i] == palavraParaJogar[i])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(palavraParaJogar[i]);
                    }

                    //letra existe na palavra mas não está na posição correta
                    else if (palavraParaJogar.Contains(palavraDigitada[i]))
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write(palavraDigitada[i]);
                    }

                    //letra não existe na palavra
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(palavraDigitada[i]);
                    }
                }
                Console.WriteLine();
            }
        }

    }

    public static string SortWord(this string word)
    {
        string[] Lista = [
                "CARRO",
                "MANGA",
                "VERDE",
                "PRETO",
                "BRAVO",
                "FELIZ",
                "FORTE",
                "LENTO",
                "GARFO",
                "CLARO",
                "SANTO",
                "MAGRO",
                "GORDO",
                "CALMO",
                "TENSA",
                "PRATO",
                "FALAR",
                "DOCES",
                "MENTE",
                "AMIGO",
                "RADIO",
                "SONHO",
                "MEDOS",
                "RISCO",
                "VALOR",
                "TEMPO",
                "HORAS",
                "MANHA",
                "NOITE",
                "TARDE"
            ];
        Random random = new Random();
        int index = random.Next(Lista.Length);
        return Lista[index];
    }
}