namespace JogoDeAdivinhacao.ConsoleApp
{
    public static class JogoAdivinhacao
    {
        static int TotalDeTentativas = 0;

        public static void SelecionarDificuldade(string opcaoDificuldade)
        {
            if (opcaoDificuldade == "1")
                TotalDeTentativas = 10;
            else if (opcaoDificuldade == "2")
                TotalDeTentativas = 5;
            else if (opcaoDificuldade == "3")
                TotalDeTentativas = 3;
        }

        public static void JogoDeAdivinhacao(int numeroSecreto)
        {
            for (int tentativa = 1; tentativa <= TotalDeTentativas; tentativa++)
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Tentativa {tentativa} de {TotalDeTentativas}");
                Console.WriteLine("----------------------------------------");

                // Lógica do jogo
                Console.Write("Digite um número entre 1 e 20: ");
                int numeroDigitado = Convert.ToInt32(Console.ReadLine());

                if (numeroDigitado == numeroSecreto)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("Você acertou o número secreto!");
                    Console.WriteLine("----------------------------------------");

                    break;
                }
                if (tentativa == TotalDeTentativas)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"Que pena! Você usou todas as tentativas. O número era {numeroSecreto}.");
                    Console.WriteLine("----------------------------------------");

                    break;
                }
                else if (numeroDigitado > numeroSecreto)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("O número informado é maior que o número secreto!");
                    Console.WriteLine("----------------------------------------");
                }
                else if (numeroDigitado < numeroSecreto)
                {
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine("O número informado é menor que o número secreto!");
                    Console.WriteLine("----------------------------------------");
                }
                Console.WriteLine("Aperte ENTER para continuar...");
                Console.ReadKey();
            }
        }
    }
}
