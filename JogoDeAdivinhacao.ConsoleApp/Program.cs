namespace JogoDeAdivinhacao.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Menu();  

                Console.Write("Digite sua escolha: ");
                JogoAdivinhacao.SelecionarDificuldade(Console.ReadLine());

                Random geradorNumeros = new Random();
                int numeroSecreto = geradorNumeros.Next(1, 20);
                JogoAdivinhacao.JogoDeAdivinhacao(numeroSecreto);               
        
                Console.WriteLine("Deseja continuar? (s/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Jogo de Adivinhação");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("Escolha um nível de dificuldade:");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("1 - Fácil (10 tentativas)");
            Console.WriteLine("2 - Normal (5 tentativas)");
            Console.WriteLine("3 - Difícil (3 tentativas)");
            Console.WriteLine("----------------------------------------");
        }
    }
}
