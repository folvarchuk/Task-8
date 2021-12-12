using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Задание_8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Выберите любую папку на своем компьютере, имеющую вложенные директории. Выведите на консоль ее содержимое и содержимое всех подкаталогов.*/

            DirectoryInfo directory = new DirectoryInfo("Test_8_1");
            foreach(DirectoryInfo firstFolder in directory.GetDirectories())
            {
                Console.WriteLine(firstFolder.Name);
                foreach(DirectoryInfo otherFolders in firstFolder.GetDirectories())
                {
                    Console.WriteLine(otherFolders.Name);
                }
            }
            Console.ReadKey();
        }
    }
}
