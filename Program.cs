using System.Data.Common;
using System.Runtime.CompilerServices;
using ExemplosExplorando.Models;
using Newtonsoft.Json;

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
// Dictionary<string, string> estados = new Dictionary<string, string>();
// estados.Add("SP", "sao paulo"); // a chave (lado esquerdo) tem que ser unica se nao ele nao funciona
// estados.Add("RJ", "rio de janeiro"); // o valor (lado direito) pode aparecer mais vezes e pode ser alterado
// estados.Add("SC", "santa catarina");

// // pode substituir isso (KeyValuePair<string, string>) pela palavra - var
// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// estados.Remove("RJ"); // para remover item vc passa a chave
// Console.WriteLine("Removendo elemento:");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// estados["SC"] = "british";
// Console.WriteLine("Alterando valor da chave:");

// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }



// =====================================================================================================================================


// Tupla

// (int Id, string Nome, string Sobrenome) tupla = (1, "Bruno", "Ricardo"); // outra sintaxe ValueTuple<int, string, string> tuple = (1, "Bruno", "Ricardo"); ou var tuple = Tuple.Create(1, "Bruno", "Ricardo")
// Console.WriteLine("id: " + tupla.Item1);
// Console.WriteLine("Nome: " + tupla.Item2);
// Console.WriteLine("Sobrenome: " + tupla.Item3);


// LeituraArquivo arquivo = new LeituraArquivo();
// var (sucesso, linhas, qtdLinhas) = arquivo.LerArquivo("Arquivos/teste.txt"); 
// // Para fazer descarte de informacao nao utilizada na tupla se usa o _
// // Ex: Caso nao quisesse utilizar a quantidade de linhas, instaciar como var (sucesso, linhas, _) Assim nao tera problema de legibilidade

// if (sucesso)
// {
//     Console.WriteLine("Quantidade de linhas do arquivo: " + qtdLinhas);
//     foreach (string item in linhas)
//     {
//         Console.WriteLine(item);
//     }
// }
// else
// {
//     Console.WriteLine("Nao foi possivel ler o arquivo");
// }


// =====================================================================================================================================



// Desconstrutor
// Pessoa p1 = new Pessoa("Bruno", "Ricardo", 28);
// (string nome, string sobrenome, int idade) = p1; // chamando o deconstructor
// Console.WriteLine(nome + sobrenome);



// =====================================================================================================================================


// IF ternario
// escrevendo um programa que determina se o numero e par ou impar
// int numero = 15;
// bool ehPar = false;

// // if ternario
// ehPar = numero % 2 == 0;
// Console.WriteLine($"O {numero} e par ou impar:");
// Console.WriteLine(ehPar ? "par" : "impar"); // se a consdicao for verdadeira imprimi depois do sinal de ? se for falsa imprimi apos o sinal :



// =====================================================================================================================================



// Serializacao e Deserializacao
// using Newtonsoft.Json;

// DateTime dataAtual = DateTime.Now; // Usar DateTime em json - ISO 8601 -  Formato Ano-Mes-Dia T Horas-Minutos-Segundos ...

// ----> serializar 1 unico item
// Venda v1 = new Venda(1, "PS5", 400M, dataAtual); // temos um objeto no codigo que precisa ser enviado para o cliente para que ele possa armazenar
// string seria = JsonConvert.SerializeObject(v1, Formatting.Indented); // vai serializar o objeto em uma string json
// File.WriteAllText("Arquivos/vendas.json", seria); // apos serializar, sera criado um arquivo (vendas.json) no formato para exportar para o cliente usar em outra aplicacao ou banco de dados
// Console.WriteLine(seria);

// // serializar 1 lista de objetos
// Venda v2 = new Venda(2, "XBOX X", 300M, dataAtual);
// Venda v3 = new Venda(3, "Switch", 350M, dataAtual);
// List<Venda> listaDeVendas = new List<Venda>();
// listaDeVendas.Add(v1);
// listaDeVendas.Add(v2);
// listaDeVendas.Add(v3);
// string serializarLista = JsonConvert.SerializeObject(listaDeVendas, Formatting.Indented);
// File.WriteAllText("Arquivos/listVendas.json", serializarLista);
// Console.WriteLine(serializarLista);


// ----> Deserializar - Aqui vai receber um json e criar um objeto para usar no sistema
// Para deserializar, precisa criar uma class para ler o arquivo json onde os nomes das propriedades da class tem que ser os mesmos que os das chaves do json
// string conteudoArquivoJson = File.ReadAllText("Arquivos/listVendas.json"); // ler o conteudo do arquivo e armazenar em uma variavel

// List<Venda> listaVendaDese = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivoJson);// pegar o arquivo e deserializar para objeto
// foreach (Venda item in listaVendaDese)
// {
//     Console.WriteLine($"Id: {item.Id}, Produto: {item.Produto}, Preco: {item.Preco}, Data: {item.DataVenda}, Desconto: {item.Desconto}");
// }



// =====================================================================================================================================



// tipos nulos
// o ? indica que pode aceitar valor null
// bool? desejaReceberEmail = null;
// if(desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("Usuario pode receber email");
// }
// else
// {
//     Console.WriteLine("Usuario nao pode receber email");
// }

// using Newtonsoft.Json;
// string conteudoArquivoJson = File.ReadAllText("Arquivos/listVendas.json");
// List<Venda> listaVendaDese = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivoJson);// pegar o arquivo e deserializar para objeto
// foreach (Venda item in listaVendaDese)
// {
//     Console.WriteLine($"Id: {item.Id}, Produto: {item.Produto}, Preco: {item.Preco}, Data: {item.DataVenda}, Desconto: {item.Desconto}");
// }

// Anonimo - tem mais de um tipo associado
// var tipoAnonimo = new { Nome = "Bruno", Sobrenome = "Camara", Altura = 1.80 }; // funciona quase igual uma tupla
// Console.WriteLine(tipoAnonimo.Nome);
// Console.WriteLine(tipoAnonimo.Sobrenome);
// Console.WriteLine(tipoAnonimo.Altura);

// string conteudoArquivoJson = File.ReadAllText("Arquivos/listVendas.json");
// List<Venda> listaVendaDese = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivoJson);

// // [var listaAnonima] para instaciar uma variavel que vai pegar a lista deserializada e criar um tipo anonimo [new { x.Produto, x.Preco }] onde [x] representa um item como no foreach e assim vc consegue selecionar um item especifico
// var listaAnonima = listaVendaDese.Select(x => new { x.Produto, x.Preco });
// foreach (var item in listaAnonima) // agora a variavel listaAnonima contem os valores de produto e preco armazenados
// {
//     Console.WriteLine(item.Produto);
//     Console.WriteLine(item.Preco);
// }

// variavel dinamica
// Pode ter seu tipo alterado
// dynamic variavelDinamica = 4;
// Console.WriteLine($"1 - Tipo da variavel dinamica: {variavelDinamica.GetType()}");

// variavelDinamica = "Texto";
// Console.WriteLine($"2 - Tipo da variavel dinamica: {variavelDinamica.GetType()}");



// =====================================================================================================================================



// Classes genericas
//agora pode ser escolhido o tipo da classe
// MeuArray<int> arrayInteiro = new MeuArray<int>();
// arrayInteiro.AdicionarElementoArray(30);
// Console.WriteLine(arrayInteiro[0]);

// MeuArray<string> arrayTexto = new MeuArray<string>();
// arrayTexto.AdicionarElementoArray("Texto");
// Console.WriteLine(arrayTexto[0]);

// metodo de extensao
int numero = 15;
bool ehPar;

// if ternario
ehPar = numero.EhPar(); // adicionando o metodo static
Console.WriteLine($"O {numero} e par ou impar:");
Console.WriteLine(ehPar ? "par" : "impar"); // se a consdicao for verdadeira imprimi depois do sinal de ? se for falsa imprimi apos o sinal :