using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHome5
{
    public class FileSearcher
    {
        public event EventHandler<string> FileFound;

        public void FilesSearch(string directoryPath)
        {
            foreach (string filePath in Directory.GetFiles(directoryPath))
            {
                FileFound.Invoke(this, filePath);
                Console.WriteLine("Продолжить поиск? y/n");
                var key = Console.ReadLine();

                while (key != "y" && key!= "n")
                {
                    Console.WriteLine("Неверное значение!");
                    Console.WriteLine("Продолжить поиск? y/n");
                    key = Console.ReadLine();
                }

                if (key == "n") 
                {
                    Console.WriteLine("Поиск файлов окончен.");
                    break;
                }
            }
        }
    }
}
