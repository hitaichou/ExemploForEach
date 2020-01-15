using System;

namespace ExemploForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet = new string[] { "Maria", "Alex", "Bob" };

            //for tradicional.
            //Ele percorre o tamanho do vetor e até terminar irá mostrar o conteúdo
            for(int i = 0; i < vet.Length; i++)
            {
                Console.WriteLine(vet[i]);
            }

            Console.WriteLine("---------------------------------------");
            
            //neste exemplo abaixo, é criado de uma forma diferente
            //o foreach necessita do tipo do vetor e no exemplo é o string
            //da-se um alias a este string, neste exemplo é dado o nome obj
            //aponta para o vetor no qual ele irá percorrer
            foreach(string obj in vet)
            {
                //quando for imprimir, coloca o alias criado acima
                Console.WriteLine(obj);
            }
        }
    }
}
