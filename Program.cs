using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programa{
public class Program{
    static void Main(String[] args){

    Console.WriteLine("===================Seja Bem Vindo===================");
    Console.WriteLine("===================1- Cadastro ====== 2-Login ===================");
    int num = int.Parse(Console.ReadLine());
    switch(num){
        case 1:
        
        Console.WriteLine("Digite seu nome: ");
        String nome = Console.ReadLine();
        Console.WriteLine("------------------------");
        Console.WriteLine("Digite seu Email: ");
        String email = Console.ReadLine();
        Console.WriteLine("------------------------");
        Console.WriteLine("Digite seu CPF: ");
        float  cpf = float.Parse(Console.ReadLine());
        Console.WriteLine("------------------------");
        Console.WriteLine("Digite um telefone de contato: ");
        int telefone = int.Parse(Console.ReadLine());
        Console.WriteLine("------------------------");
        
        break;   
        case 2:
        Console.WriteLine("Username: ");
        string user = Console.ReadLine();
        Console.WriteLine("------------------------");
        Console.WriteLine("Senha: ");
        int senha = int.Parse(Console.ReadLine());
     
           if(senha == 1234){
            inicio i = new inicio();
            i.iniciar();
            Console.ReadKey();
        }
        else{
            Console.WriteLine("Senha Incorreta");
        }

         break;

     
       

       




    }


    }

}
}
