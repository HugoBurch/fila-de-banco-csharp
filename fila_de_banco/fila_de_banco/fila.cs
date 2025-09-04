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


        public string[] vetorFila = { "1", "2", "2", "1", "2", "1" }; // 1 para normal e 2 para prioridade 


        public void AdicionarNormal(string nome)
        {

            filaNormal.Enqueue(nome); // Enqueue adiciona um item ao final da fila

            Console.WriteLine($"\nCliente {nome}  tipo: normal  adicionado à fila.");
        }
        public void AdicionarPrioridade(string nome)
        {
            filaPrioridade.Enqueue(nome);
            Console.WriteLine($"\nCliente prioritário {nome} adicionado à fila.");
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
                    Console.WriteLine($"\nCliente fila prioritário {filaPrioridade.Dequeue()}"); // Dequeue remove e retorna o próximo item na fila

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
        public void ListarClientes(int i = 0, int j = 0, int k = 0)
        {

            if (i >= vetorFila.Length)
                return;

            // Se vetorFila indica cliente normal
            if (vetorFila[i] == "1")
            {
                if (j < filaNormal.Count)
                {
                    Console.WriteLine("Normal: " + filaNormal.ToArray()[j]);
                    j++;


                }


                else if (k < filaPrioridade.Count)
                {
                    Console.WriteLine("Prioridade: " + filaPrioridade.ToArray()[k]);
                    k++;

                }
                else
                {
                    return;
                }

                i++;

            }
            
            // Se vetorFila indica cliente prioritário
            else if (vetorFila[i] == "2" )
                
            {

                if(k < filaPrioridade.Count) {
                    Console.WriteLine("Prioridade: " + filaPrioridade.ToArray()[k]);
                    k++;
                    

                }
                else if( j < filaNormal.Count)
                {
                    Console.WriteLine("Normal: " + filaNormal.ToArray()[j]);
                    j++;
                    
                    

                }
                else
                {
                    return;
                }

                i++;
            }
            ListarClientes(i,j,k);



        }




            







        


    }






}









