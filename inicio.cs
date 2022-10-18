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

           Console.WriteLine("Descreva as atividades do seu dia");
           String ativ = Console.ReadLine();

           Console.WriteLine("Deseja Salvar ? 1-Sim | 2-Não");
           int Salvar =int.Parse(Console.ReadLine());

           if(Salvar == 1){
            Console.WriteLine("Salvo com sucesso!");
           }
           else{
            Console.WriteLine("Tente Novamente!");
           }

        }
    }
}