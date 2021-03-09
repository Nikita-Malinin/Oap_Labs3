using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_4
{
    class Program
    {

        static void Fun0() {
            string path = @"C:\I-31\123.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                Console.WriteLine("имя файла:{0}", fileInf.Name);
                Console.WriteLine("время создания:{0}", fileInf.CreationTime);
                Console.WriteLine("размер:{0}", fileInf.Length);
            }
        }
        static void Main(string[] args)
        {
            //Fun0();

            Fun1();

            Fun2();

            Fun3();

            Console.ReadLine();
        }
     
        static void Fun1()
        {
            
            var path = @"C:\I-31\123.txt";
            string newPath = @"C:\git\123.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                

             
            }
           
        }
        static void Fun2()
        {
            string path = @"C:\git\123.txt";
            string newPath = @"C:\I-31\123.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.CopyTo(newPath, true);
                
            }
        }
        static void Fun3()
        {
            string path = @"C:\git\123.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.Delete();
               
            }

        }


    }
}
