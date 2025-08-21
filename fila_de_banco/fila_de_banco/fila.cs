using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fila_de_banco
{
    internal class fila
    {


        Queue<string> filaNormal = new Queue<string>();
        Queue<string> filaPrioridade = new Queue<string>();


        string[] vetorFila = ["2;2;1;2;1"];



        public void AdicionarNormal(string nome)
        {

            filaNormal.Enqueue(nome);

            Console.WriteLine($"Cliente {nome}  tipo: normal  adicionado à fila.");
        }
        public void AdicionarPrioridade(string nome)
        {
            filaPrioridade.Enqueue(nome);
            Console.WriteLine($"Cliente prioritário {nome} adicionado à fila.");
        }



        public void ChamarCliente()
        {
            int i = 0;
            if (vetorFila[i] == "1")
            {



                if (filaNormal.Count != 0)
                {
                    Console.WriteLine($"\nCliente fila normal {filaNormal.Dequeue()}");






                }
                else if (filaPrioridade.Count != 0)
                {
                    Console.WriteLine($"\nCliente fila prioritário {filaPrioridade.Dequeue()}");


                }
                else
                {
                    Console.WriteLine("\nNenhum cliente na fila.");

                }
                i++;




            }
            else
            {
                if (filaPrioridade.Count != 0)
                {
                    Console.WriteLine($"\nCliente fila prioritário {filaPrioridade.Dequeue()}");

                }
                else if (filaNormal.Count != 0)
                {
                    Console.WriteLine($"\nCliente fila normal {filaNormal.Dequeue()}");

                }
                else
                {
                    Console.WriteLine("\nNenhum cliente na fila.\n");



                }
                i++;

            }




        }






    }
}

        



    

