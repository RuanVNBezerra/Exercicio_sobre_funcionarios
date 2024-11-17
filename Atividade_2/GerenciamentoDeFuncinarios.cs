namespace Atividade_2;

class GerenciamentoDeFuncinarios
{
    private List<Funcionarios> funcionarios;

    // inicio do construtor
    public GerenciamentoDeFuncinarios()
    {
        funcionarios = new List<Funcionarios>();
    }
    // fim do construtor

    //função/metodo para adcionar um novo funcionário
    public void AdicionarFuncionario(string nome, Guid id, float salario)
    {
        Funcionarios novoFuncionario = new(nome, id, salario);
        funcionarios.Add(novoFuncionario);
        Console.WriteLine("Funcionário adicionado com sucesso!");
    }

    //função/metodo para remover um funcionário com base no id
    public void RemoverFuncionario(Guid id)
    {
        Funcionarios? funcionariosParaRemover = funcionarios.Find(funcionarios => funcionarios.ID == id);
        if (funcionariosParaRemover != null)
        {
            funcionarios.Remove(funcionariosParaRemover);
            Console.WriteLine("Funcionário removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Funcionário não encontrado!");
        }
    }
    // função/metodo para buscar um funcionário com base no id
    public Funcionarios? BuscarFuncionario(Guid id)
    {
         return funcionarios.Find(funcionariosID => funcionariosID.ID == id);
    }
    // função/metodo para exibir todos os funcionários por Nome ou ID
    public void ListarFuncionarios(bool ordenarPorNome)
    {
        if (funcionarios.Count == 0)
        {
            Console.WriteLine("Nenhum funcionário cadastrado!");
            return;
        }
        // usando IEnumerable para ordenar os funcionários por Nome ou ID
        IEnumerable<Funcionarios> listaOrdenada;
        if (ordenarPorNome)
        {
            listaOrdenada = funcionarios.OrderBy(funcionarios => funcionarios.Nome);
            Console.WriteLine("Listando funcionários por Nome:");
        }
        else
        {
            listaOrdenada = funcionarios.OrderBy(funcionarios => funcionarios.ID);
            Console.WriteLine("Listando funcionários por ID:");
        }
        // loop foreach para exibir os funcionários ordenados por Nome ou ID
        foreach (var funcionarios in listaOrdenada)
        {
            funcionarios.ExibirDados();
            Console.WriteLine();
        }
    }
    // função/metodo para limpar todos os funcionários (limpar a memoria)
    public void LimparFuncionarios()
    {
        funcionarios.Clear();
        Console.WriteLine("Todos os funcionários foram removidos com sucesso!");
    }
}
