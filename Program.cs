using PropriedadesMetodosConstrutores.Models;
using System.Globalization;



(int, string, string, decimal) tupla = (1, "Leonardo", "Aparicio", 1.80M);

ValueTuple<int, string, string, decimal> tupla2 = (1, "Leonardo", "Aparicio", 1.80M);

var tupla3 = Tuple.Create(1, "Leonardo", "Aparicio", 1.80M);



Console.WriteLine($"Id: {tupla.Item1}");
Console.WriteLine($"Nome: {tupla.Item2}");
Console.WriteLine($"Sobrenome: {tupla.Item3}");
Console.WriteLine($"Altura: {tupla.Item4}");






















// Dictionary<string, string> estados = new Dictionary<string, string>();
//
// estados.Add("SP", "Sao Paulo");//o primeiro valor eh um ID e o segundo o valor em si
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");
//
// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
//
// Console.WriteLine("--------------------------------");
//
// estados.Remove("BA");
// estados["SP"] = "Sao Paulo - Valor alterado";
//
// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
//
// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave} ");
//
//
// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor Existente: {chave} ");
// }
// else
// {
//     Console.WriteLine($"Valor nao existe. E seguro adicionar a chave: {chave} ");
// }
//




// Stack<int> pilha = new Stack<int>();
//
// pilha.Push(2);
// pilha.Push(4);
// pilha.Push(8);
// pilha.Push(16);
//
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);    
// }
//
// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");
//
// pilha.Push(32);
//
// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }
















// Queue<int> fila = new Queue<int>();
//
// fila.Enqueue(1);
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(8);
//
//
// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }
//
//
// Console.WriteLine($"Removendo Elementos: {fila.Dequeue()}");
// fila.Enqueue(16);
//
// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }
















// new ExemploExcecao().Metodo1();













// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");
//
//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
//
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo nao encontrado. {ex.Message}");
// }
// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. O caminho da Pasta nao foi encontrado. {ex.Message}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma excecao generica. {ex.Message}");
// }
// finally
// {
//     Console.WriteLine("Chegou ate aqui!");
// }









// DateTime date = DateTime.Now;
//
// Console.WriteLine(date.ToString("dd/MM/yyyy HH:mm"));



// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");//nao indicado se o sistema for usados em diferentes paises
//
// decimal valorMonetario = 82.40M;
//
// Console.WriteLine($"{valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))}");
//
// double porcentagem = .3412;
//
// Console.WriteLine(porcentagem.ToString("P"));
//
// int numero = 12345;
//
// Console.WriteLine(numero.ToString("##-##-##"));












// string numero1 = "10";
// int numero2 = 20;
//
// string resultado = numero1 + numero2;
//
// Console.WriteLine(resultado);






// Pessoa p1 = new Pessoa("Leo", "Aparicio");
// Pessoa p2 = new Pessoa("Maria", "Maio");
//
// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();
//
// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();
//





// p1.Nome = "Leo";
// p1.Sobrenome = "Aparicio";
// p1.Idade = 20;
//
// p1.Apresentar();