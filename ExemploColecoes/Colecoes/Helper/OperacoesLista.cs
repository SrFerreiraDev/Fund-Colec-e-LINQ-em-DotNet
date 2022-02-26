using System.Collections.Generic;

namespace Colecoes.Helper
{
    public class OperacoesLista       //Classe para operações, nesse exemplo, para remover, adicionar elementos e coleções na Lista;
    {
        public void ImprimirListaString(List<string> lista)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                System.Console.WriteLine($"Índice: {i}, Valor: {lista[i]}");
            }
        }
    }
}