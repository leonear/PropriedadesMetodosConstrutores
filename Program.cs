using PropriedadesMetodosConstrutores.Models;

Pessoa p1 = new Pessoa("Leo", "Aparicio");
Pessoa p2 = new Pessoa("Maria", "Maio");

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