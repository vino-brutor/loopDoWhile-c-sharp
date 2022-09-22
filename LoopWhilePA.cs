using System;

namespace revisão_de_c_sharpas
{
    class Program
    {
        static void Main(string[] args)
        {
            int num,num2,cont=0,razao;
            Console.WriteLine("Informe o primeiro número:");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número:");
            num2 = int.Parse(Console.ReadLine());
            razao = num2 - num;
            while(cont<10){ //while repetição pré-teste, vai ficar fazendo enquanto o cont for menor que 10

              Console.Write(" "+num);
              num = num + razao; //acumulador: variavelA = variavelA + variavelB, vai fazendo  a soma.
              cont++; //contador: variavel ++, conta quantas vezes o loop foi feito.
            }

        }
    }
}
