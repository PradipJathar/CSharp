using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            // File Class
            if (File.Exists(@"D:\Other\Learning\CSharp\Basic\WorkingWithFiles\MyInfo.txt"))
            {
                string content = File.ReadAllText(@"D:\Other\Learning\CSharp\Basic\WorkingWithFiles\MyInfo.txt");
                Console.WriteLine(content);
            }

            string path = @"d:\somefile.jpg";
            File.Copy(path, @"d:\New Folder\somefile.jpg");
            File.Delete(path);


            // FileInfo Class
            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo(@"d:\New Folder\somefile.jpg");
            fileInfo.Delete();
            if (fileInfo.Exists)
            {
                // Do Something
            }



            // Directory Class
            Directory.CreateDirectory(@"C:\Users\Admin\Desktop\Folder1");

            string[] directories = Directory.GetDirectories(@"D:\Other\Learning\CSharp\Basic\WorkingWithFiles", "*.*", SearchOption.AllDirectories);
            string[] files = Directory.GetFiles(@"D:\Other\Learning\CSharp\Basic\WorkingWithFiles", "*.cs*", SearchOption.AllDirectories);

            bool isExists = Directory.Exists(@"D:\Other\Learning\CSharp\Basic\WorkingWithFiles");


            // DirectoryInfo Class
            DirectoryInfo directoryInfo = new DirectoryInfo((@"C:\Users\Admin\Desktop\Folder1"));
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();
            directoryInfo.Create();



            // File Class
            string path1 = @"D:\Other\Learning\CSharp\Basic\WorkingWithFiles\MyInfo.txt";

            Console.WriteLine($"Get Extension: {Path.GetExtension(path1)}");
            Console.WriteLine($"Get File Name: {Path.GetFileName(path1)}");
            Console.WriteLine($"Get File Name Without Extension: {Path.GetFileNameWithoutExtension(path1)}");
            Console.WriteLine($"Get Directory Name: {Path.GetDirectoryName(path1)}");
        }
    }
}
