using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_24
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[30] {22,22,332,44,554,55,55,55,66,33,22,55,66,775,34,
                                          544,22,22,22,22,33,1,1,2,1,11,222,2,33,21};
            int maxСountDuplicate = 0;
            int countDuplicate = 0;
            int mostCommonNumber = 0;
            int precedingNumber = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == precedingNumber)
                {
                    countDuplicate++;

                    if (countDuplicate > maxСountDuplicate)
                    {
                        mostCommonNumber = numbers[i];
                        maxСountDuplicate = countDuplicate;
                    }
                }
                else
                {
                    countDuplicate = 0;
                    countDuplicate++;
                    precedingNumber = numbers[i];
                }

                Console.Write($"{numbers[i]} ");
            }

            Console.WriteLine($"\nЧисло, которое встречается чаще всего подряд: {mostCommonNumber} \n" +
                              $"Сколько раз число встречалось подряд: {maxСountDuplicate}");
            Console.ReadLine();
        }
    }
}
