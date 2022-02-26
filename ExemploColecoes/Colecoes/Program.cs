using System;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] arrayNumeros = new int[10] {0, 1, 2, 4, 8, 16, 32, 32, 64, 100 };            ////Obtendo e Ordenando Valores com LINQ;

            // var minimo = arrayNumeros.Min();                         ////Obter valor Mínimo;
            // var maximo = arrayNumeros.Max();                         ////Obter valor Máximo;
            // var medio = arrayNumeros.Average();                      ////Obter valor Médio(que pode não ser exato);
            // var soma = arrayNumeros.Sum();                           ////Somar todos os valores e retornar o valor da soma;
            // var arrayUnico = arrayNumeros.Distinct().ToArray();      ////Retornar os valores Distintos entre si;

            // System.Console.WriteLine($"Mínimo: {minimo}");                                    ////Escreve o valor Mínimo;
            // System.Console.WriteLine($"Máximo: {maximo}");                                    ////Escreve o valor Máximo;
            // System.Console.WriteLine($"Médio: {medio}");                                      ////Escreve o valor Médio;
            // System.Console.WriteLine($"Soma: {soma}");                                        ////Escreve o valor da soma;
            // System.Console.WriteLine($"Array Original: {string.Join(", ", arrayNumeros)}");   ////Escreve o Array Original;
            // System.Console.WriteLine($"Array Distinto: {string.Join(", ", arrayUnico)}");     ////Escreve o Array com apenas Npumeros distintos entre si;
            
            
            // var numerosParesQuery =                                             ////Sintaxe mais próxima do SQL;
            //     from num in arrayNumeros
            //     where num % 2 == 0
            //     orderby num
            //     select num;
            
            // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 ==0).OrderBy(x => x).ToList();       ////Sintaxe mais simples por Método;

            // System.Console.WriteLine("Números Pares query: " + string.Join(", ", numerosParesQuery));     ////Escreve a Sintaxe proxima do SQL;
            // System.Console.WriteLine("Números Pares Método: " + string.Join(", ", numerosParesMetodo));    ////Escreve a Sintaxe por Método;



            // Dictionary<string, string> estados = new Dictionary<string, string>();      ////Dicionário: Mátodo para adição de Chaves(valores);

            // estados.Add("PB", "Paraiba");                 ////Adicionando valores que não podem repetir;
            // estados.Add("PE", "Pernambuco");
            // estados.Add("RN", "Rio Grande do Norte");

            // foreach (KeyValuePair<string, string> item in estados)       ////Para determinar a Impressão das Chaves e seus valores;
            // {
            //     //System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");     ////Escreve as chaves e seus valores;
            // }

            // string valorProcurado = "RJ";                                 ////Acessando um valor na Chave;    

            // if (estados.TryGetValue(valorProcurado, out string? estadoEncontrado))
            // {
            //     System.Console.WriteLine($"Chave: {estadoEncontrado} = existe no dicionário");               ////Escreve a Chave que existe no Dicionário;
            // }
            // else
            // {
            //     System.Console.WriteLine($"Chave: {valorProcurado} = não existe no dicionário");    ////Escreve caso não tenha a Chave no Dicionário;
            // }

            // System.Console.WriteLine($"Removendo o valor: {valorProcurado}");     ////Escreve a ação de Remoção da Chave especificada;

            // estados.Remove(valorProcurado);                                     ////Ação de Remoção da Chave especificada;

            // foreach (KeyValuePair<string, string> item in estados)       ////Para determinar a Impressão das Chaves e seus valores;
            // {
            //     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");     ////Escreve as chaves e seus valores após Remoção;
            // }

            // System.Console.WriteLine("Valor Original: ");             ////Escreve a ação de mostrar o valor Original da Chave;
            // System.Console.WriteLine(estados[valorProcurado]);        ////Escreve o Valor Original da Chave;

            // estados[valorProcurado] = "RN - Teste atualização";       ////Escreve o processo de atualização e teste;

            // System.Console.WriteLine("Valor Atualizado: ");           ////Escreve a ação de mostrar o valor Atualizado da Chave;
            // System.Console.WriteLine(estados[valorProcurado]);        ////Escreve o Valor Atualizado da Chave;


            // Stack<string> pilhaLivros = new Stack<string>();       ////Declarando a Stack(Pilha) - LIFO;

            // pilhaLivros.Push("Bíblia King James");                              ////Adicionando elementos na Pilha; Ex.: Livros;
            // pilhaLivros.Push("Bíblia Thompsom");
            // pilhaLivros.Push("Bíblia do Obreiro");
            // pilhaLivros.Push("Bíblia de Genebra");
            // pilhaLivros.Push("Bíblia Sagrada");

            // System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");   ////Escreve a Pilha total;
            // while (pilhaLivros.Count > 0)                                              ////Método para começar a Pilha do início e alocando o próximo da Pilha;
            // {
            //     System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");   ////Escreve o próximo da Pilha a ser processado(lido);
            //     System.Console.WriteLine($"{pilhaLivros.Pop()} Lido com sucesso");               ////Escreve o elemento(Livro) que foi processado (Lido;)
            // }
            // System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");    ////Escreve a Pilha zerada após todos os elementos(Livros) serem processados(Lidos);


            // Queue<string> fila = new Queue<string>();      ////Declarando a Fila - FIFO;

            // fila.Enqueue("Edinaldo");         ////Adicionado os elementos da Fila; Ex.: Pessoas numa fila de atendimento;
            // fila.Enqueue("Ferreira");
            // fila.Enqueue("Estefhane");
            // fila.Enqueue("Martins");

            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");  ////Escreve a Fila Total;
            // while (fila.Count > 0)                                       ////Método para começar a Fila do inicio e vai alocando o próximo da Fila;
            // {
            //     System.Console.WriteLine($"Vez de: {fila.Peek()}");      ////Escreve o próximo da fila a ser processado;
            //     System.Console.WriteLine($"{fila.Dequeue()} atendido");  ////Escreve o elemento da fila que foi processado;
            // }
            // System.Console.WriteLine($"Pessoas na fila: {fila.Count}");  ////Escreve e mostra a Fila zerada depois de todos serem processados;


            // OperacoesLista opLista = new OperacoesLista();   ////Chamando a Classe OperacoesLista;
            // //List<string> estados = new List<string>();    ////Declarando e acessando uma lista;
            // List<string> estados = new List<string>{ "PB", "PE", "RN" };  ////Se quiser posso instânciar já com os valores sem precisar do método Add;
            
            // string[] estadosArray = new string[2] { "CE", "AL"};   ////Valores para adicionar;

            // estados.Add("PB");
            // estados.Add("PE");
            // estados.Add("RN");

            // System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}"); ////Escreve quantidade de elementos da Lista;

            // opLista.ImprimirListaString(estados);     ////Imprimi a Lista original;

            // System.Console.WriteLine("Removendo o elemento");    ////Escreve a acão de remoção;
            // estados.Remove("RN");                                ////Declara o elemento a ser removido;

            // estados.AddRange(estadosArray);                       ////Vai manter os itens originais e vai adicionar os novos elementos no final da Lista;
            // System.Console.WriteLine("Coleção na lista após adição:");   ////Escreve a ação de adição;

            // estados.Insert(0, "PI");          ////Especifica o Índice e o elemento que vai ser adicionado nele;
            // System.Console.WriteLine("Lista atual após adição do novo elemento no índice especificado:");   ////Escreve a ação de adição por índice;
            // opLista.ImprimirListaString(estados);                ////Escreve a Lista após remoção realocando os elementos nos índices ordenados;

            
            // foreach (var item in estados)              ////A seguir tem 2 exemplos de acesso: pelo foreach e pelo for;
            // {
            //     System.Console.WriteLine(item);
            // }

            // for (int i = 0; i < estados.Count; i++)
            // {
            //     System.Console.WriteLine($"Índice: {i}, Valor: {estados[i]}");
            // }



            ////Array Ordenado via bubble sort;
            // OperacoesArray op = new OperacoesArray();
            
            // int[] array = new int[5] { 6, 3, 9, 1, 27 };
            // int[] arrayCopia = new int[10];          ////Copiando um array;
            // string[] arrayString = op.ConverterParaArrayString(array);     ////Converter um Array de int para string;
            
            //int valorProcurado = 6;             ////Determinar o valor para a operação desejada no array, seja copiar, verificar, encontrar, redimencionar, converter, etc; seja um ou todos;

            
            ////Redimencionando um Array;
            // System.Console.WriteLine($"Capacidade atual do array: {array.Length}");     ////Chamando o Array atual;

            // op.RedimensionarArray(ref array, array.Length * 2);     ////Redimensionando e Multiplicando por 2;

            // System.Console.WriteLine($"Capacidade atual do array após redimensionar: {array.Length}");     ////Chamando o Array atual após Redimensionado;


            // int indice = op.ObterIndice(array, valorProcurado);      ////Encontrar o Índice de um valor no Array;
            // if (indice > -1)
            // {
            //     System.Console.WriteLine($"O índice do elemento {valorProcurado} é: {indice}"); 
            // }
            // else
            // {
            //     System.Console.WriteLine("Valor não existente no array");
            // }


            // int valorAchado = op.ObterValor(array, valorProcurado);     ////Encontrar um valor no Array;
            // if (valorAchado > 0)
            // {
            //     System.Console.WriteLine("Encontrei o valor");
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor");
            // }

            
            // bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);     ////Verificar Todos os elementos do Array;
            // if (todosMaiorQue)
            // {
            //     System.Console.WriteLine("Todos os valores são maiores do que {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Existem valores que não são maiores do que {0}", valorProcurado);
            // }
            
            
            // bool existe = op.Existe(array, valorProcurado);      ////Verificando Um Array;

            // if (existe)
            // {
            //     System.Console.WriteLine("Encontrei o valor {0}", valorProcurado);
            // }
            // else
            // {
            //     System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
            // }

            // System.Console.WriteLine("Array Original");
            // op.ImprimirArray(array);

            //op.OrdenarDubbleSort(array);           
            //op.Ordenar(ref array);                 ////Usando a Classe Array que está no System;

            // System.Console.WriteLine("Array Ordenado");
            // op.ImprimirArray(array);

            // System.Console.WriteLine("Array antes da cópia:");        ////Exemplo copiando um Array;
            // op.ImprimirArray(arrayCopia);

            // op.Copiar(ref array, ref arrayCopia);
            // System.Console.WriteLine("Array após a cópia:");
            // op.ImprimirArray(arrayCopia);


            //// exemplo de array multidimencional:
            // int[,] matrix = new int[4, 2]
            // {
            //     { 8, 8 },
            //     { 10, 20 },
            //     { 50, 100 },
            //     { 90, 200 }
            // };

            // for (int i = 0; i < matrix.GetLength(0); i++)           //// for para a linha;
            // {
            //     for (int j = 0; j < matrix.GetLength(1); j++)       //// for para a coluna, o "j" é para diferenciar já que o for de linha já é "i";
            //     {
            //         System.Console.WriteLine(matrix[i, j]);
            //     }
            // }

            // int[] arrayInteiros = new int[3];          ////Exemplo de Array padrão ou Unidimencional;

            // arrayInteiros[0] = 10;
            // arrayInteiros[1] = 20;
            // arrayInteiros[2] = int.Parse("30");  //// Mostrar possibilidade de converter uma string em int;
            // arrayInteiros[3] = 40;               //// Teste de limite e como o array impede a adição além do estabelecido;

            // System.Console.WriteLine("Percorrendo o array pelo for");   ////Para mais controle dos indicadores;
            // for (int i = 0; i < arrayInteiros.Length; i++)
            // {
            //     System.Console.WriteLine(arrayInteiros[i]);
            // }

            // System.Console.WriteLine("Percorrendo o array pelo foreach");   ////Preferível quando não precisar ter tanto controle;
            // foreach (int item in arrayInteiros)
            // {
            //     System.Console.WriteLine(item);
            // }
        }
    }
}