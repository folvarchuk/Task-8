using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_8_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Программно создайте текстовый файл и запишите в него 10 случайных чисел. Затем программно откройте созданный файл, рассчитайте сумму чисел в нем, ответ выведите на консоль.*/

            string path = "Task_8-2.txt";
            int[] array = new int[10];
            Random random = new Random();
            int S = 0;
            using (StreamWriter sw = new StreamWriter(path))
            {
                for (int i = 0; i < 10; i++)
                {
                    array[i] = random.Next(0, 10);
                    sw.WriteLine(array[i]);
                }
            }
            using (StreamReader sr = new StreamReader(path))
            {
                foreach (int i in array)
                {
                    int x = Convert.ToInt32(sr.ReadLine());
                    S += x;
                }
                Console.WriteLine(S);
            }
            Console.ReadKey();
        }
    }
}
