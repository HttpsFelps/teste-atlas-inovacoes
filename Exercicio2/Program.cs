class Program
{
    static void Main()
    {
        List<string> nomes = new List<string>();
            
        bool sair = false;
        while (!sair)
        {
            
            Console.Clear();
            Console.WriteLine("1 - Listar todos os nomes cadastrados");
            Console.WriteLine("2 - Adicionar nome");
            Console.WriteLine("3 - Excluir nome");
            Console.WriteLine("4 - Sair");

            Console.Write("Escolha uma opção: ");
            String opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    ListarNomes(nomes, true);
                    break;
                case "2":
                    AdicionarNome(nomes);
                    break;
                case "3":
                    ExcluirNome(nomes);
                    break;
                case "4":
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }
    }

    static void ListarNomes(List<string> nomes, bool pausar)
    {
        Console.Clear();
        if (nomes.Count == 0)
        {
            Console.WriteLine("Nenhum nome adicionado!");
        }
        else
        {
            int count = 1;
            foreach (var item in nomes)
            {
                Console.WriteLine($"{count++}º nome: {item}");
            }
        }
        if (pausar)
        {
            Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
            Console.ReadKey();
        }
    }

    static void AdicionarNome(List<string> nomes)
    {
        bool sair = false;
        while (!sair)
        {
            Console.Clear();
            Console.Write("Digite o nome: ");
            String nomeAdicionado = Console.ReadLine();
            if (!String.IsNullOrWhiteSpace(nomeAdicionado))
            {
                nomes.Add(nomeAdicionado);
                Console.WriteLine("Nome adicionado com sucesso!");
                while (true)
                {
                    Console.Write("Deseja adicionar outro nome? (s/n): ");
                    String resposta = Console.ReadLine().ToLower();
                    if (resposta == "n")
                    {
                        sair = true;
                        break;
                    }
                    else if (resposta == "s")
                    {
                        break;
                    }
                        
                    else {Console.WriteLine("Por favor, digite uma resposta válida");}
                }
            }
            else
            {
                Console.WriteLine("Por favor, digite um nome!");
            }
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }

    static void ExcluirNome(List<string> nomes)
    {
        bool sair = false;
        while (!sair)
        {
            ListarNomes(nomes, false);
            if (nomes.Count != 0)
            {
                Console.Write("Digite o número (ordinal) do nome a ser deletado: ");
                String input = Console.ReadLine();
                if (int.TryParse(input, out int ordinal))
                {
                    if (ordinal > 0 && ordinal <= nomes.Count)
                    {
                        String nome = nomes[ordinal - 1]; 
                        Console.WriteLine($"Nome {nome} removido com sucesso");
                        nomes.RemoveAt(ordinal - 1);
                        while (true)
                        {
                            Console.Write("Deseja excluir outro nome? (s/n): ");
                            String resposta = Console.ReadLine().ToLower();
                            if (resposta == "n")
                            {
                                sair = true;
                                break;
                            }
                            else if (resposta == "s")
                            {
                                break;
                            }

                            else { Console.WriteLine("Por favor, digite uma resposta válida"); }
                        }
                    }
                    else { Console.WriteLine("Número fora do intervalo da lista"); }
                }
                else { Console.WriteLine("Digite um numero válido!"); }
            }
            else
            {
                sair = true;
            }
        }
        Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
        Console.ReadKey();
    }
}