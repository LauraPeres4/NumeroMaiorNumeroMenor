using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroMaiorNumeroMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.Write("Informe a quantidade de números: ");
            int quant = int.Parse(Console.ReadLine());

            int[] nums = new int[quant];
            int min;
            int max;

            Console.Write("Informe o número: ");
            nums[0] = int.Parse(Console.ReadLine());

            min = nums[0];
            max = nums[0];

            for (int i = 1; i < quant; i++)
            {
                Console.WriteLine("Digite o número: ");
                nums[i] = int.Parse(Console.ReadLine());

                if (nums[i] < min)
                {
                    min = nums[i];
                }
                else if (nums[i] > max) 
                {
                    max = nums[i];
                }
            }
            Console.WriteLine("Os números foram: ");

            for (int j = 1; j < quant; j++)
            {
                Console.WriteLine(nums[j]);
            }

            Console.WriteLine("O maximo foi: " + max);
            Console.WriteLine("o minimo foi: " + min);
            Console.ReadKey();

        }
        
    }
}
