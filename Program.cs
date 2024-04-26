using ExemplosExplorando.Models;

// Pessoa p1 = new Pessoa();
// p1.Nome = "Bruno"; // "Bruno" vira o valor de value
// p1.Sobrenome = "Camara";
// p1.Idade = 28; // 28 vira valor de value
// p1.Apresentar();




// =====================================================================================================================================



// Trabalhando com a class de curso
// Pessoa p1 = new Pessoa("Bruno", "Camara", 28);
// Pessoa p2 = new Pessoa("Ricardo", "Noberto", 29);

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles DIO";
// cursoDeIngles.Alunos = new List<Pessoa>(); // quando vc tem uma propriedade que tem como tipo uma lista, vc precisa instanciar essa lista
// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();




// =====================================================================================================================================




// Formatando valores

// using System.Globalization;

// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); // aqui ira trocar a cultura e ira mostrar sempre com a cultura especificada aqui

// decimal valorMonetario = 82.40M;
// Console.WriteLine($"{valorMonetario:C}"); // esse C significa moeda. Vai apresentar o valor monetario de acordo com a localizacao do sistema do computador(sistema) da pessoa

// decimal valorMonetarioDois = 100.40M;
// Console.WriteLine(valorMonetarioDois.ToString("C", CultureInfo.CreateSpecificCulture("pt-BR"))); // esse ira ficar na cultura especificada aqui
// Console.WriteLine(valorMonetarioDois.ToString("C5")); // esse numero representa as casas decimais 

// double porcentagem = .21;
// Console.WriteLine(porcentagem.ToString("P"));
// Console.WriteLine(porcentagem.ToString("P1"));

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-#-#"));

// DateTime data = DateTime.Now; // pega a data e hora no tempo de execucao do sistema
// Console.WriteLine(data);
// Console.WriteLine(data.ToString("dd-MM-yyyy"));
// Console.WriteLine(data.ToString("HH:mm"));
// Console.WriteLine(data.ToString("dd-MM-yyyy HH:mm"));

// DateTime dataF = DateTime.Parse("2022-04-17 18:00"); // convert uma string em dateTime. A data apenas precisa ser valida. Caso nao seja ele quebra
// Console.WriteLine(dataF);

// string dataString = "2022-04-17 18:00";
// // 1 a string que vc quer converter, 2 vai ser o formato que ela esta, 3 a cultura da data, 4 o estilo da data, out parametro de saida
// // se o valor for invalido ele ira imprimir 01/01/0001 00:00
// // tudo isso pra validar a data e transformar ela de string para DateTime
// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dataFormt);
// if(sucesso)
// {
//     Console.WriteLine($"Data formatada com sucesso. {dataFormt}");
// }
// else
// {
//     Console.WriteLine($"Data nao formatada. {dataFormt}");
// }



// =====================================================================================================================================



// Ler arquivo e jogar excessao
// no bloco try catch podemos ter quantos blocos catchs quisermos
// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/teste.txt"); // se colocar o mouse em cima de ReadAllLine ira apresentar um popup com as excessoes especificas que podem acontecer
//     foreach(string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }    
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Excessao especifica de arquivo nao encontrado: {ex.Message}");
// }
// catch (Exception ex)
// {

//     Console.WriteLine($"Excessao generica: {ex.Message}"); // excessao generica pois pode ocorrer qualquer uma do popup do ReadAllLine
// }
// finally // ele executa sempre que acaba o try catch caindo em qualquer bloco de codigo (tanto no try quanto no catch) muito utilizado para encerrar conexao com banco de dados
// {
//     Console.WriteLine("Chegou ate aqui");
// }


// =====================================================================================================================================


// Fila
// Queue<int> fila = new Queue<int>();
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     Console.WriteLine(item); // vai imprimir na ordem adicionada. 2, 4, 6, 8
// }

// fila.Dequeue(); // nao passa parametro pq vai adicionar na ordem adicionada. No caso o primeiro vai ser o 2. FIFO
// Console.WriteLine("Removendo elemento:");

// foreach (int item in fila)
// {
//     Console.WriteLine(item); // vai imprimir na ordem adicionada. 2, 4, 6, 8
// }

// Pilha
// Stack<int> pilha = new Stack<int>();
// pilha.Push(3);
// pilha.Push(6);
// pilha.Push(9);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item); // vai imprimir do ultimo adicionado ao primeiro. 9, 6, 2
// }

// pilha.Pop(); // ele tambem retorna o elemento removido caso queira imprimir no console
// Console.WriteLine("Removendo elemento:");

// foreach (int item in pilha)
// {
//     Console.WriteLine(item); // vai apagar o ultimo adicionado. 9. pois esta no topo
// }

// Dictionary
Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "sao paulo"); // a chave (lado esquerdo) tem que ser unica se nao ele nao funciona
estados.Add("RJ", "rio de janeiro"); // o valor (lado direito) pode aparecer mais vezes e pode ser alterado
estados.Add("SC", "santa catarina");

// pode substituir isso (KeyValuePair<string, string>) pela palavra - var
foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados.Remove("RJ"); // para remover item vc passa a chave
Console.WriteLine("Removendo elemento:");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}

estados["SC"] = "british";
Console.WriteLine("Alterando valor da chave:");

foreach (var item in estados)
{
    Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
}