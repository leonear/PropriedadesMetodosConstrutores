using PropriedadesMetodosConstrutores.Models;
using System.Globalization;



DateTime date = DateTime.Now;

Console.WriteLine(date.ToString("dd/MM/yyyy HH:mm"));













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