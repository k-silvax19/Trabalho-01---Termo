using Termo.ConsoleApp1;

static class Jogo
{
    public static string palavraParaJogar = "";

    public static void IniciarJogo() // metodo para gerar as palavras aleatorias já que nas versões anteriores ele continuava com a mesma palavra mesmo apos reniciar o loop
    {
        palavraParaJogar = GerarPalavra.ListaAleatorio(); // atribuição a variavel para gerar a palavra aleatoria
        LogicaDoJogo();
    }

    public static string LogicaDoJogo()
    {
        string[] ultimasPalavras = new string[0]; //array para salvar o "historico" de palavras anteriores
        int tentativas = 5;
        do
        {
            string palavraDigitada;

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Digite uma palavra: ");
            palavraDigitada = Console.ReadLine().ToUpper();

            Console.Clear();

            if (string.IsNullOrWhiteSpace(palavraDigitada))
            {
                Console.WriteLine("Digite algo válido!");
                continue;
            }

            else if (ultimasPalavras.Contains(palavraDigitada)) // o uso da ferramenta contains aqui e para ver se ultimas palavras contém a palavra digita e poder imprimir a verificação
            {
                Console.WriteLine("Você já digitou essa palavra!");
                continue;
            }
            else if (palavraDigitada.Length != palavraParaJogar.Length)
            {
                Console.WriteLine("A palavra deve ter o tamanho correto!");
                continue;
            }

            ultimasPalavras = ultimasPalavras.Append(palavraDigitada).ToArray(); //aqui usei uma nova ferramenta chamada "Append" ela serve para pegar tudo que existe na array "Ultimas Palavras" e adiciona a "PalavraDigitada" no final criando um novo array (serve para salvar as ultimas palavras digitadas e mostrar para o usuario)

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
}