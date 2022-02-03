using System;
namespace Colecoes
{
    public class Arrays
    {
        public void ArrayInteiros()
        {
            int [] arrayInteiros = new int [3];
                
                arrayInteiros[0] = 10;
                arrayInteiros[1] = 20;
                arrayInteiros[2] = 30;
            
                Console.WriteLine("Percorre array com For: ");
           
            for (int i = 0; i < arrayInteiros.Length; i++)
            {
                Console.WriteLine(arrayInteiros[i]);
            }
                Console.WriteLine("Percorre array com Foreach: ");
            
            foreach (int item in arrayInteiros)
            {
                System.Console.WriteLine(item);
            }

            
        }
        public void MatrizInteiros()
            {
                int [,] matriz = new int[4,2]
                {
                    {0,1},
                    {1,2},
                    {3,4},
                    {5,6}
                };
                for (int i = 0; i < matriz.GetLength(0); i++)
                {
                    for (int contador = 0; contador < matriz.GetLength(1); contador++)
                    {
                        System.Console.WriteLine( matriz[i, contador]);
                    }
                }
            }
        
    }
}