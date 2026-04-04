namespace Termo.ConsoleApp1;

using System.ComponentModel;

public static class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirCabecalho();

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("Digite sua escolha: ");
            string? menu = Console.ReadLine();

            switch (menu)
            {
                case "1":
                    Jogo.IniciarJogo();
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

            if (!Continuacao())
            {
                break;
            }

            Console.ResetColor();
        }
    }

    public static void Regras()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("╔════════════════════════════════════╗");
        Console.WriteLine("║   _____ _____ ____  __  __  ___    ║");
        Console.WriteLine(@"║  |_   _| ____|  _ \|  \/  |/ _ \   ║");
        Console.WriteLine(@"║    | | |  _| | |_) | |\/| | | | |  ║");
        Console.WriteLine(@"║    | | | |___|  _ <| |  | | |_| |  ║");
        Console.WriteLine(@"║    |_| |_____|_| \_\_|  |_|\___/   ║");
        Console.WriteLine("╚════════════════════════════════════╝");

        Console.WriteLine(" ");

        Console.WriteLine("Se a letra estiver na posição correta, ela ficará verde.");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Se a letra estiver na palavra, mas na posição errada, ela ficará amarela.");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Se a letra não estiver na palavra, ela ficará vermelha.");
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine(" ");

        Console.Write("Aperte Qualquer TECLA para voltar");
        Console.ReadKey();

    }
    public static void ExibirCabecalho()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("╔════════════════════════════════════╗");
        Console.WriteLine("║   _____ _____ ____  __  __  ___    ║");
        Console.WriteLine(@"║  |_   _| ____|  _ \|  \/  |/ _ \   ║");
        Console.WriteLine(@"║    | | |  _| | |_) | |\/| | | | |  ║");
        Console.WriteLine(@"║    | | | |___|  _ <| |  | | |_| |  ║");
        Console.WriteLine(@"║    |_| |_____|_| \_\_|  |_|\___/   ║");
        Console.WriteLine("╚════════════════════════════════════╝");

        Console.WriteLine(" ");

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[1] - Jogar");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("[2] - Regras do Jogo");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("[3] - Sair");
        Console.ForegroundColor = ConsoleColor.White;
    }
    static bool Continuacao()
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("\nDeseja continuar? (s/N): ");
        Console.ForegroundColor = ConsoleColor.White;
        string? opcao = Console.ReadLine()?.Trim().ToUpper();
        return opcao == "S";
    }
}