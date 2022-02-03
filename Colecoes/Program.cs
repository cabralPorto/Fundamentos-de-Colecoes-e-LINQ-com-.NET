using System.Linq;
using System.Collections.Generic;
using Colecoes.Helper;

namespace Colecoes
{
    class Program 
    {
        static void Main(string[] args)
        {
            
            int[]arrayNumeros = new int[8]{2,8,18,21,36,21,2,8};

            var minimo = arrayNumeros.Min();
            var medio = arrayNumeros.Average();
            var maximo = arrayNumeros.Max();
            var soma = arrayNumeros.Sum();
            var arrayUnico = arrayNumeros.Distinct().ToArray();
           
            System.Console.WriteLine($"Minimo: {minimo}");
            System.Console.WriteLine($"Médio: {medio}");
            System.Console.WriteLine($"Máximo: {maximo}");
            System.Console.WriteLine($"Soma: {soma}");
            System.Console.WriteLine($"Array Original: {string.Join(", ", arrayNumeros)}");
            System.Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)}");

            // var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();
            // var numerosParesQuery = 
            //             from num in arrayNumeros
            //             where num % 2 == 0
            //             orderby num
            //             select num;
            // System.Console.WriteLine("Numeros Pares Metodos: " + string.Join(", ", numerosParesMetodo));
            // System.Console.WriteLine("Numeros Pares Query: " + string.Join(", ", numerosParesQuery));


            // System.Console.WriteLine($"Removendo valor: {estados[valorProcurado]}");
            // estados.Remove(valorProcurado);
            
            // foreach (KeyValuePair<string, string> item in estados)
            //  {
            //      System.Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
            //  }
           
           
            // System.Console.WriteLine($"Valor Procurado: {estados[valorProcurado]}");
            // estados[valorProcurado] = "BA - teste Atualização";
            // System.Console.WriteLine($"Valor Atualizado: {estados[valorProcurado]}");
            
            
            // Stack<string> pilhaLivro = new Stack<string>();

            // pilhaLivro.Push(".Net");
            // pilhaLivro.Push("DDD");
            // pilhaLivro.Push("Código Limpo");
            
            // Console.WriteLine($"Livros para leitura: {pilhaLivro.Count}"   );
               
            //     while (pilhaLivro.Count > 0)
            //     {
            //          Console.WriteLine($"Próximo livro para leitura: {pilhaLivro.Peek()}");
            //          Console.WriteLine($"{pilhaLivro.Pop()} lido com sucesso!");
            //     }
            // Console.WriteLine($"Livros para leitura: {pilhaLivro.Count}"   );

            
            // Queue<string> fila = new Queue<string>();

            //     fila.Enqueue("Ana");
            //     fila.Enqueue("Julia");
            //     fila.Enqueue("Ronaldo");

            //     Console.WriteLine($"Pessoa na fila: {fila.Count}");

            // while (fila.Count > 0 )
            // {
            //    Console.WriteLine($"Vez de : {fila.Peek()}");
            //    Console.WriteLine($"{fila.Dequeue()} Atendido");
            // }
            //    Console.WriteLine($"Pessoa na fila: {fila.Count}");
            
            // OperacoesLista opLista = new OperacoesLista();
        
            // List<string> estados = new List<string>{"BA","MG","SP"};
            // string[] estadosArray = new string[2]{"MT","SC"};
            
            // System.Console.WriteLine($"Lista de Estado: {estados.Count}");

            // //estados.AddRange(estadosArray);
            // estados.Insert(0, "RJ");
            // opLista.ImprimirListaString(estados);



        //      System.Console.WriteLine("Removendo o elemento");
        //      estados.Remove("SP");
        //      opLista.ImprimirListaString(estados);

    
            // int [] array = new int[5]{8,3,5,9,4};
            // int [] arrayCopia = new int[10];
            // OperacoesArray op = new OperacoesArray();
           
            // // int valorProcurado = 11;


            //        string[] arrayString = op.ConverteParaArrayString(array);


                    //Console.WriteLine($"Capacidade atual do array: {array.Length}");
                   
                    //op.RedimensionarArray(ref array, array.Length * 3);
                   
                    //Console.WriteLine($"Capacidade atual do array após redimencionar: {array.Length}");

                // int valorAchado = op.ObterValor(array, valorProcurado);
                // if (valorAchado > 0)
                // {
                //     Console.WriteLine("Encontrei o Valor");
                // }
                // else
                // {
                //     Console.WriteLine("Não encontrei o Valor");
                // }


           
           
        //    bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado);
                
        //         if (todosMaiorQue)
        //         {
        //             Console.WriteLine("Todos os valores procurados  são maior que: {0}", valorProcurado);
        //         }
        //         else
        //         {
        //             Console.WriteLine("Existe valores que não são maiores do que: {0}", valorProcurado);
        //         }


        // System.Console.WriteLine("Array não Ordenado: ");
        // op.ImprimirArray(array);

            
        //     System.Console.WriteLine("Array  Ordenado: ");
        //     op.OrdenarBubbleSort(ref array);
        //     op.Ordenar(ref array);
        //     op.ImprimirArray(array);

        //     Arrays array = new Arrays();
        //     array.ArrayInteiros();
        //     array.MatrizInteiros();

            // System.Console.WriteLine("Array antes da copia: ");
            // op.ImprimirArray(array);
            // System.Console.WriteLine("Array depois da cópia: ");
            // op.CopiarArray(ref array, ref arrayCopia);
            // op.ImprimirArray(arrayCopia);


        }
    }
}
