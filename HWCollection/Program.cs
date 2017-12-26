using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HWCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> list = new List<int>();

            int evenSum = 0;
            int maxValue = 0;

            for (int i = 0; i < 10; i++)
            {
                var randomNumber = random.Next(0, 100);

                list.Add(randomNumber);

                if (i % 2 == 0) evenSum += randomNumber;

                if (randomNumber > list[maxValue]) maxValue = i;
            }

            List<int> tempList = new List<int>(list);

            tempList.Remove(list[maxValue]);

            int secondMaxValue = tempList[0];
          

            tempList.Sort();
            


            foreach (var number in list)
                Console.Write(number + " ");

            Console.WriteLine("\n\nСумма элементов на четных позициях: {0}", evenSum);

            Console.WriteLine("\nВторое максимальное чилсо: {0} ", secondMaxValue);

            Console.ReadLine();
        }
    }
}
