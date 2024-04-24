using ExemplosExplorando.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Bruno"; // "Bruno" vira o valor de value
// p1.Sobrenome = "Camara";
// p1.Idade = 28; // 28 vira valor de value
// p1.Apresentar();




// =====================================================================================================================================



// Trabalhando com a class de curso
Pessoa p1 = new Pessoa("Bruno", "Camara", 28);
Pessoa p2 = new Pessoa("Ricardo", "Noberto", 29);

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles DIO";
cursoDeIngles.Alunos = new List<Pessoa>(); // quando vc tem uma propriedade que tem como tipo uma lista, vc precisa instanciar essa lista
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();