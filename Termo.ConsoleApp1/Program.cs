namespace Termo.ConsoleApp1;

using System.ComponentModel;

public static class Program
{
    static void Main(string[] args)
    {
        while (true == true)
        {
            ExibirCabecalho();

            Console.WriteLine(" ");

            Console.Write("Digite sua escolha: ");
            string? menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    Jogo();
                    break;
                case "2":
                    Regras();
                    continue;
                case "3":
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    Console.ReadLine();
                    break;
            }
        }
    }

    public static string Jogo()
    {
        string[] ultimasPalavras = new string[0];
        string palavraDigitada;
        string palavraParaJogar = "".SortWord();
        int tentativas = 5;
        do
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite uma palavra: ");
            palavraDigitada = Console.ReadLine().ToUpper();

            if (string.IsNullOrWhiteSpace(palavraDigitada))
            {
                Console.WriteLine("Digite algo válido!");
                continue;
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
        } while (true);
        return palavraParaJogar;
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

    public static void Regras()
    {
        Console.Clear();
        Console.WriteLine("Se a letra estiver na posição correta, ela ficará verde.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Se a letra estiver na palavra, mas na posição errada, ela ficará amarela.");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Se a letra não estiver na palavra, ela ficará vermelha.");
        Console.ForegroundColor = ConsoleColor.Black;

        Console.Write("Aperte Qualquer TECLA para voltar");
        Console.ReadKey();

    }
    public static void ExibirCabecalho()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("╔════════════════════════════════════╗");
        Console.WriteLine("║   _____ _____ ____  __  __  ___    ║");
        Console.WriteLine(@"║  |_   _| ____|  _ \|  \/  |/ _ \   ║");
        Console.WriteLine(@"║    | | |  _| | |_) | |\/| | | | |  ║");
        Console.WriteLine(@"║    | | | |___|  _ <| |  | | |_| |  ║");
        Console.WriteLine(@"║    |_| |_____|_| \_\_|  |_|\___/   ║");
        Console.WriteLine("╚════════════════════════════════════╝");

        Console.WriteLine(" ");

        Console.WriteLine("1 - Jogar");
        Console.WriteLine("2 - Regras do Jogo");
        Console.WriteLine("3 - Sair");

        Console.WriteLine(" ");
    }
}