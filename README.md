# Projeto Tuplas em C# - .NET 7.0
Neste repositório, você encontrará um projeto de console criado com C# no .NET 7.0, destacando o recurso das tuplas, uma novidade poderosa que torna a programação em C# ainda  mais eficiente e expressiva.

## 🚀 Começando
Para começar a usar este projeto, siga os passos abaixo:

1. Clone o repositório:

```bash
  git clone https://github.com/IGOR-MACEDO-DOS-ANJOS/tuplas.git
``` 

2. Navegue até a pasta do projeto:

```bash
  cd [NOME_DA_PASTA_DO_PROJETO]
```

3. Execute o projeto:
```bash
  dotnet run
```

## 🔍 O que são Tuplas?
As tuplas são uma forma de agrupar múltiplos valores em uma única variável. São úteis quando você precisa retornar mais de um valor de um método ou quando deseja agrupar informações sem criar uma classe ou estrutura específica para isso.

Exemplo básico:

```C#

  (int, string) minhaTupla = (5, "Hello");
  Console.WriteLine(minhaTupla.Item1); // Saída: 5
  Console.WriteLine(minhaTupla.Item2); // Saída: Hello

```

Além disso, no C# 7 e versões posteriores, você pode atribuir nomes personalizados aos membros da tupla:

```C#
  (var idade, var nome) = (29, "Ana");
  Console.WriteLine($"Nome: {nome}, Idade: {idade}"); // Saída: Nome: Ana, Idade: 29
```

## 📚 Referências
[Documentação Oficial da Microsoft sobre Tuplas](https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/builtin-types/value-tuples)
## 📝 Licença
Este projeto está sob a licença MIT. Consulte o arquivo LICENSE para obter detalhes.
