namespace programa{
    class Transacao{

        internal void trabalhar(){

        Console.WriteLine("===================Transacoes===================");

        Console.WriteLine("1-Simular Financiamento | 2-Simular Empréstimo | 3-Previdência Privada | 4-Seguros");
        int num =int.Parse(Console.ReadLine());

        switch(num){
            case 1:
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("CPF: ");
            float cpf = float.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("Renda Mensal: ");
            float renda = float.Parse(Console.ReadLine());

            if(renda > 7000){
                Console.WriteLine("Financiamento Aprovado");
            }
            else{
            Console.WriteLine("Financiamento Reprovado");

            }
            break;

            case 2:
            Console.WriteLine("Nome:");
            string nomes = Console.ReadLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("CPF: ");
            float cpfs = float.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("Renda Mensal: ");
            float rendas = float.Parse(Console.ReadLine());
            if(rendas > 5000){
                Console.WriteLine("Financiamento Aprovado");
            }
            else{
            Console.WriteLine("Financiamento Reprovado");

            }
           break;

           case 3:
             Console.WriteLine("Nome:");
            string nom = Console.ReadLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("CPF: ");
            float cp = float.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("Renda Mensal: ");
            float rend = float.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("Quanto deseja pagar por mês ?");
            float nums = float.Parse(Console.ReadLine());
           break;
           case 4:

           Console.WriteLine("Nome:");
            string n = Console.ReadLine();
            Console.WriteLine("------------------------");
            Console.WriteLine("CPF: ");
            float c = float.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("Idade:");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("Renda Mensal: ");
            float ren = float.Parse(Console.ReadLine());
            Console.WriteLine("------------------------");
            Console.WriteLine("Que tipo de seguro deseja ? ");
            string obj = Console.ReadLine();
            if(idade > 24){
                Console.WriteLine("Seguro Aprovado ");
                
            }else{
                
                Console.WriteLine("Seguro Aprovado, mas o valor irá dobrar  ");
            }
           break;

            
                    }

        }

    }
}