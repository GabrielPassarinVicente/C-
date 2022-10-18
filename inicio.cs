using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa{

     class inicio{

    

        internal void iniciar()
        {
           Console.WriteLine("=================Coisas a se fazer no dia =================");
           Console.WriteLine("1-Organizar tabela de empresas |"+
           "2-Fazer orçamento para clientes|" +
           "3 - Fazer fechamento no final do dia" );

         Console.WriteLine("===========Transações===========");
         Console.WriteLine("Digite 1");
         int num = int.Parse(Console.ReadLine());

         if(num == 1){

            Transacao T = new Transacao();
            T.trabalhar();
            Console.ReadKey();

             }            
          }
    }
}