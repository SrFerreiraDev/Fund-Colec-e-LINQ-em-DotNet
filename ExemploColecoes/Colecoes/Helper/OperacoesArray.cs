using System;

namespace Colecoes.Helper
{
    public class OperacoesArray
    {
        public void OrdenarDubbleSort(int[] array)           //Array Ordenado via bubble sort;
        {
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j + 1];
                        array[j +1] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
        public void ImprimirArray(int[] array)
        {
            var linha = string.Join(", ", array);   //Variável para imprimir em linha para facilitar a leitura;
                System.Console.WriteLine(linha);
        }

        public void Ordenar(ref int[] array)         //Método para Ordenar pela Classe Array;
        {
            Array.Sort(array);
        }

        public void Copiar(ref int[] array, ref int[] arrayDestino)      //Método para copiar pela Classe Array;
        {
            Array.Copy(array, arrayDestino, array.Length);
        }

        public bool Existe(int[] array, int valor)               //Método para Verificar em elemento existente;
        {
            return Array.Exists(array, elemento => elemento == valor);   //Posso mudar a operação dependendo do que quero: ex.: =>, =<, !=, etc;
        }

        public bool TodosMaiorQue(int[] array, int valor)     //Método para verificar Todos os elementos do Array;
        {
            return Array.TrueForAll(array, elemento => elemento > valor);
        }

        public int ObterValor(int[] array, int valor)         //Método para encontrar um elemento no Array;
        {
            return Array.Find(array, element => element == valor);
        }

        public int ObterIndice(int[] array, int valor)       //Método para Obter o Índice de um valor no Array;
        {
            return Array.IndexOf(array, valor);
        }

        public void RedimensionarArray(ref int[] array, int novoTamanho)      //Método para Redimencionar um Array;
        {
            Array.Resize(ref array, novoTamanho);
        }

        public string[] ConverterParaArrayString(int[] array)            //Método para Converter o Array nesse caso, de int para string pelo método ToString;
        {
            return Array.ConvertAll(array, elemento => elemento.ToString());
        }
    }
}