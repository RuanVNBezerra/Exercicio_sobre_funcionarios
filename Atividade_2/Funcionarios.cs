namespace Atividade_2;

public class Funcionarios
{
    //propriedades dos funcionários 
    public string Nome { get; set; } = string.Empty;
    public Guid ID { get; set; } = Guid.NewGuid();
    public float Salario { get; set; }

    //inicio do construtor
    public Funcionarios(string nome, Guid id, float salario)
    {
        Nome = nome;
        ID = id;
        Salario = salario;
    }
    //fim do construtor

    //exibindo os dados dos funcionários
    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Id: {ID}");
        Console.WriteLine($"Salário: {Salario:C}");
    }
}

