using System;

namespace Exercicio_calculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double imc, massa, altura;
            double  massa_elevada;
            
            Console.WriteLine("\nEsse programa tem por finalidade calcular o IMC do usuário:");
            Console.WriteLine("Para iniciá-lo digite: ........ ");

            Console.Write("\nSeu peso:.... ");
            massa = Convert.ToDouble(Console.ReadLine());

            Console.Write("Sua altura:.. ");
            altura = Convert.ToDouble(Console.ReadLine());

            massa_elevada = Math.Pow(altura,2);
            imc = massa/massa_elevada;

            Console.WriteLine($"Seu IMC corresponde à:.. {imc:N2}\n");
            
        
            if(imc< 17)
            {
                 Console.WriteLine("Portanto sua situação é:...Muito abaixo do peso");
            }
            if(imc>=17 && imc<=18.49 )
            {
                 Console.WriteLine("Portanto sua situação é:...Abaixo do Peso");
            }
            if(imc>=18.50 && imc<=24.99)
            {
               Console.WriteLine("Portanto sua situação é:...Peso normal");
            }
            if(imc>=25 && imc<=29.99)
            {
                 Console.WriteLine("Portanto sua situação é:...Acima do peso");
            }
            if(imc>=30 && imc<=34.99)
            {
                Console.WriteLine("Portanto sua situação é:...Obesidade I");
        
            }
            if (imc>=35 && imc<=39.99)
            {
                 Console.WriteLine("Portanto sua situação é:...Obesidade II (severa)");    
            }
            if(imc>=40)
             {
                 Console.WriteLine("Obesidade III (mórbida)");
             }
            Console.WriteLine("");
              
             



        }
    }
}
