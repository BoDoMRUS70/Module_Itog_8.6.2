using System;
using System.IO;


namespace Module_8_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите путь к папке:");
            string path = Console.ReadLine();
            DirectoryInfo di = new DirectoryInfo(path);
            if (di.Exists)
            {
                Console.WriteLine("Размер: " + DirectoryExtension.CountSize(di) + " байт");
            }
            else
            {
                Console.WriteLine("Папки не существует");
            }
        }
    }
}
