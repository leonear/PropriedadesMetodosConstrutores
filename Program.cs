using PropriedadesMetodosConstrutores.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Leo";
p1.Sobrenome = "Aparicio";

Pessoa p2 = new Pessoa();
p2.Nome = "Maria";
p2.Sobrenome = "Maio";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();






// p1.Nome = "Leo";
// p1.Sobrenome = "Aparicio";
// p1.Idade = 20;
//
// p1.Apresentar();