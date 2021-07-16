using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> lista, params T[] itens)
        {
            foreach (T item in itens)
            {
                lista.Add(item);
            }
        }

        //Nesse método o usuário é obrigado a informar o tipo a ser utilizado pois string não é uma classe genérica
        public static void TesteGenerico<T>(this string texto)
        {

        }
        static void Teste()
        {
            List<int> idades = new List<int>();
            idades.Add(14);
            idades.Add(26);
            idades.Add(60);

            idades.AdicionarVarios(2, 3, 4);

            string guilherme = "Guilherme";
            guilherme.TesteGenerico<int>();

            List<string> nomes = new List<string>();

            nomes.Add("Guilherme");
            nomes.Add("Guilherme");
            nomes.Add("Guilherme");

 

            nomes.AdicionarVarios("Lucas", "Mariana");
        }
    }
}
