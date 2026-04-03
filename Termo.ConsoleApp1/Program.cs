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
            string palavraDigitada;
            string palavraParaJogar = "".SortWord();
            int tentativas = 5;

            // cabecalho    
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

            // logica do jogo
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite uma palavra: ");
                palavraDigitada = Console.ReadLine().ToUpper();

                if (string.IsNullOrWhiteSpace(palavraDigitada))
                {
                    Console.WriteLine("Digite algo válido!");
                    continue;
                }
                else if (palavraDigitada == "SAIR")
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Obrigado por jogar!");
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.ReadLine();
                    break;
                }
                else if (ultimasPalavras.Contains(palavraDigitada))
                {
                    Console.WriteLine("Você já digitou essa palavra!");
                    continue;
                }
                else if (palavraDigitada.Length != palavraParaJogar.Length)
                {
                    Console.WriteLine("A palavra deve ter o tamanho correto!");
                    continue;
                }

                ultimasPalavras = ultimasPalavras.Append(palavraDigitada).ToArray();

                Console.WriteLine(" ");

                //foreach (esquema de laço para loop com string, array e etc), ele funciona aqui para imprimir os acertos/erros e imprimir atras as letras anteriores
                foreach (string palavra in ultimasPalavras)
                {
                    for (int contador = 0; contador < palavraParaJogar.Length; contador++)
                    {
                        if (palavra[contador] == palavraParaJogar[contador])
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(palavra[contador]);
                        }
                        else if (palavraParaJogar.Contains(palavra[contador]))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(palavra[contador]);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(palavra[contador]);
                        }
                    }

                    Console.WriteLine("");
                }

                // verificação de tentativas
                if (palavraDigitada == palavraParaJogar)
                {
                    Console.WriteLine($"Parabéns você ganhou! A palavra era: {palavraParaJogar}");
                    Console.ReadLine();
                    break;
                }

                tentativas--;

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Tentativas restantes: {tentativas}");
                Console.ForegroundColor = ConsoleColor.White;

                // perdeu
                if (tentativas == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Você perdeu! A palavra era: {palavraParaJogar}");
                    Console.ReadLine();
                    break;
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
        int dicionario = random.Next(Lista.Length);
        return Lista[dicionario];
    }
}