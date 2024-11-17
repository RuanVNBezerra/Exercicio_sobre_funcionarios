# Exercicio sobre Funcionários

## Descrição
Este projeto é uma aplicação de console desenvolvida em C# que permite gerenciar informações de funcionários. Ele foi criado como um exercício para treinar habilidades na linguagem C#. O programa permite adicionar, remover, buscar, listar funcionários e liberar memória.

## Funcionalidades
- **Adicionar Funcionário**: Permite adicionar um novo funcionário com nome, ID único (guid) e salário.
- **Remover Funcionário**: Permite remover um funcionário existente pelo ID.
- **Buscar Funcionário**: Permite buscar um funcionário pelo ID e exibir seus dados.
- **Listar Funcionários**: Permite listar todos os funcionários ordenados por nome ou ID.
- **Liberar Memória**: Permite liberar a memória não utilizada pelo programa.
- **Sair**: Encerra a aplicação.

## Estrutura do Código
O projeto está organizado da seguinte maneira:

### Program.cs
Este arquivo contém o método `Main` que é o ponto de entrada da aplicação. Ele exibe um menu de opções para o usuário e chama os métodos apropriados da classe `GerenciamentoDeFuncinarios` com base na escolha do usuário.

### GerenciamentoDeFuncinarios.cs
Esta classe gerencia a lista de funcionários e contém métodos para adicionar, remover, buscar, listar e limpar funcionários.

### Funcionarios.cs
Esta classe representa um funcionário e contém as propriedades `Nome`, `ID` e `Salario`, além de um método para exibir os dados do funcionário.

## Requisitos
Para executar este projeto, você precisará ter instalado:
- [.NET SDK](https://dotnet.microsoft.com/download)

## Como Executar
1. Clone o repositório para o seu ambiente local:
   ```bash
   git clone https://github.com/RuanVNBezerra/Exercicio_sobre_funcionarios.git
   ```
2. Navegue até o diretório do projeto:
   ```bash
   cd Exercicio_sobre_funcionarios/Atividade_2
   ```
3. Restaure as dependências do projeto (se houver):
   ```bash
   dotnet restore
   ```
4. Execute o projeto:
   ```bash
   dotnet run
   ```

## Uso
Ao executar o programa, você verá um menu de opções. Digite o número da opção desejada e siga as instruções exibidas no console.

## Contribuições
Contribuições são bem-vindas! Sinta-se à vontade para abrir issues e pull requests para melhorias.

## Autor
[RuanVNBezerra](https://github.com/RuanVNBezerra)

Este projeto foi feito como uma atividade para treinar habilidades na linguagem C#.