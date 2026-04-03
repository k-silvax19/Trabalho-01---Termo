namespace Termo.ConsoleApp1;

using System.ComponentModel;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        while (true == true)
        {
            string palavraAleatoria = ListaPalavras();
            int tentantiva = 6;
            bool[] letrasUsadas = new bool[palavraAleatoria.Length];

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║   _____ _____ ____  __  __  ___    ║");
            Console.WriteLine(@"║  |_   _| ____|  _ \|  \/  |/ _ \   ║");
            Console.WriteLine(@"║    | | |  _| | |_) | |\/| | | | |  ║");
            Console.WriteLine(@"║    | | | |___|  _ <| |  | | |_| |  ║");
            Console.WriteLine(@"║    |_| |_____|_| \_\_|  |_|\___/   ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Black;

            Console.WriteLine(" ");

            Console.Write("digite uma palavra: ");
            string inputJogador = Console.ReadLine().ToUpper();

            for (int contador = 0; contador < palavraAleatoria.Length; contador++)
            {
                if (inputJogador[contador] == palavraAleatoria[contador])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    letrasUsadas[contador] = true;
                }
                else
                {
                    bool encontrada = false;
                    for (int contador2 = 0; contador2 < palavraAleatoria.Length; j++)
                    {
                        if (!letrasUsadas[contador2] && inputJogador[contador2] == palavraAleatoria[contador2])
                        {
                            encontrada = true;
                            letrasUsadas[contador2] = true;
                            break;
                        }
                    }

                    if (encontrada)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                    }
                }

                Console.Write(inputJogador[i]);
            }

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine();

            Console.Write("Deseja continuar o jogo? (s/N): ");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper();

            if (opcaoContinuar != "S")
                break;

        }

        static string ListaPalavras()
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
            int dicionarioAleatorio = RandomNumberGenerator.GetInt32(Lista.Length);

            string palavraAleatoria = Lista[dicionarioAleatorio];

            return palavraAleatoria;
        }
    }
}