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
            return;
        }
            Console.WriteLine("Funcionário não encontrado!");
    }
    // função/metodo para buscar um funcionário com base no id
    public Funcionarios? BuscarFuncionario(Guid id)
    {
         return funcionarios.Find(funcionariosID => funcionariosID.ID == id);
    }
    // função/metodo para exibir todos os funcionários por Nome ou ID
    public void ListarFuncionarios(bool ordenarNomeOuId)
    {
        if (funcionarios.Count == 0)
        {
            Console.WriteLine("Nenhum funcionário cadastrado!");
            return;
        }
        // usando IEnumerable para ordenar os funcionários por Nome ou ID
        IEnumerable<Funcionarios> listaOrdenada;
        if (ordenarNomeOuId)
        {
            Console.WriteLine("Ordenando por Nome...");
            listaOrdenada = funcionarios.OrderBy(funcionarios => funcionarios.Nome);
        }
        else
        {
            Console.WriteLine("Ordenando por ID...");
            listaOrdenada = funcionarios.OrderBy(funcionarios => funcionarios.ID);
        }


            int contadorParaOrdenar = 1;
            // loop foreach para exibir os funcionários ordenados por Nome e ID
            foreach (var funcionarios in listaOrdenada)
           {
            if(ordenarNomeOuId)
            {
                // ordenando por nome
                Console.WriteLine($"{contadorParaOrdenar}. Nome: {funcionarios.Nome}");
            }
            else
            {
                // ordenando por ID
                Console.WriteLine($"{contadorParaOrdenar}. ID: {funcionarios.ID}");
            }
           }
    }
    // função/metodo para limpar todos os funcionários (limpar a memoria)
    public void LimparFuncionarios()
    {
        funcionarios.Clear();
        Console.WriteLine("Todos os funcionários foram removidos com sucesso!");
    }
}
