using System;
using fila_de_banco;




namespace test {
      class Program {
        fila Fila = new fila();

        static void Main(string[] args) {
            
           
            new Program().loopfila();
           
        }
        

        public  void loopfila()
        {
            Console.WriteLine("Fila de Atendimento do Banco                                                 |");
            Console.WriteLine("-----------------------------------------------------------------------------|");
            Console.WriteLine("escolha a opção:                                                             |");
            Console.WriteLine("Gerar - Adicionar cliente na fila e o nome do cliente, separados por espaço: |");
            Console.WriteLine("-----------------------------------------------------------------------------|");
            Console.WriteLine("Chamar - Atender cliente da fila                                             |");
            Console.WriteLine("-----------------------------------------------------------------------------|");
            Console.WriteLine("Listar - Listar clientes na fila                                             |");
            Console.WriteLine("-----------------------------------------------------------------------------|");
            Console.WriteLine("Sair - Sair do programa                                                      |");
            Console.WriteLine("-----------------------------------------------------------------------------|");


            string escolha = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(escolha))
            {
                loopfila();
                return;
            }
            else
            {
                string[] filaOpcao = escolha.Split(' ', 3);
                string comando = filaOpcao[0];




                switch (comando.ToLower())
                {
                    case "gerar":


                        if (filaOpcao.Length >= 3)
                        {
                            
                                string tipo = filaOpcao[1].ToLower();
                                string nome = filaOpcao[2];
                                if (tipo == "prioridade")
                                {
                                    Fila.AdicionarPrioridade(nome);

                                    loopfila();
                                    return;
                                }
                                else
                                {
                                    Fila.AdicionarNormal(nome);
                                    loopfila();
                                    return;

                                } 
                            
                       

                        }
                        else
                        {
                            Console.WriteLine("\nPor favor, forneça o tipo de cliente (normal ou prioridade) e o nome do cliente.\n");
                            loopfila();

                        }
                        break;



                    case "chamar":
                        Fila.ChamarCliente();
                        loopfila();
                        

                        break;
                    case "listar":
                        Console.WriteLine("Listando clientes na fila.");

                        break;
                    case "sair":
                        Console.WriteLine("Saindo do programa.");
                        return;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }

        }

    }
    
}
