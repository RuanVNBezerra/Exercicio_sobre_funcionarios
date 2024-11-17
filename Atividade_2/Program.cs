namespace Atividade_2;

class Program
{
    static void Main()
    {
        GerenciamentoDeFuncinarios gerenciador = new();
        bool executando = true;
        while (executando)
        {
            Console.WriteLine("\nMenu De Opçoes: ");
            Console.WriteLine("1 - Adicionar Funcionário");
            Console.WriteLine("2 - Remover Funcionário");
            Console.WriteLine("3 - Buscar Funcionário");
            Console.WriteLine("4 - Listar Funcionários");
            Console.WriteLine("5 - Liberar Memória");
            Console.WriteLine("6 - Sair");
            Console.Write("Digite a opção desejada: ");
            string? input = Console.ReadLine();
            // usando if caso o usuário digite uma opção inválida
            if (int.TryParse(input, out int opcao))
            {
               
            }
            else
            {
                Console.WriteLine("Opção inválida, tente novamente!");
            }

            // usando switch para chamar as funções/metodos de acordo com a opção escolhida
            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o nome do funcionário: ");
                    string? nome = Console.ReadLine();
                    // usando if para verificar se o nome é nulo ou se tem espaços em branco
                    if (string.IsNullOrWhiteSpace(nome))
                    {
                        Console.WriteLine("Nome invalido");
                        break;
                    }
                    Console.Write("Digite o salário do funcionário: ");
                    string? salarioInput = Console.ReadLine();
                    // usando if para verificar se o salário é nulo ou se é um número válido
                    if (salarioInput != null && float.TryParse(salarioInput, out float salario))
                    {
                        gerenciador.AdicionarFuncionario(nome, Guid.NewGuid(), salario);   
                    }
                    else
                    {
                        Console.WriteLine("Salário inválido, tente novamente!");
                    }

                    break;
                case 2:
                    Console.Write("Digite o ID do funcionário que deseja remover: ");
                    string? idRemoverInput = Console.ReadLine();
                    if (Guid.TryParse(idRemoverInput, out Guid id))
                    {
                        gerenciador.RemoverFuncionario(id);
                    }
                    else
                    {
                        Console.WriteLine("ID não encontrado");
                    }
                    break;
                case 3:
                    Console.Write("Digite o ID do funcionário que deseja buscar: ");
                    string? idBuscarUsuarioInput = Console.ReadLine();
                    if(Guid.TryParse(idBuscarUsuarioInput, out Guid idBuscar))
                    {
                        gerenciador.BuscarFuncionario(idBuscar);
                    }
                    else
                    {
                        Console.WriteLine("ID invalido. \n Usuario não achado");
                    }
                    break;
                case 4:
                    Console.WriteLine("Deseja ordenar por Nome ou ID? (N/I)");
                    string? ordenarPor = Console.ReadLine();
                    if (ordenarPor != null)
                    {
                        bool ordernarPorNome = ordenarPor.ToUpper() == "N";
                        gerenciador.ListarFuncionarios(ordernarPorNome);
                    }
                    break;
                case 5:
                    // GC.Collect() é usado para liberar a memória não utilizada pelo programa.
                    GC.Collect();
                    Console.WriteLine("Memória liberada com sucesso!");
                    break;
                case 6:
                    executando = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida, tente novamente!");
                    break;

            }
        }
    }
}
