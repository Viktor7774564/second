using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Text;
using System.Linq;

namespace MyProgram
{
    class Program
    {
        

        static void Main(string[] args)
        {
            List<string[]> hum = new List<string[]>();
            StreamReader sr = new StreamReader("t.txt");
            
            while (!sr.EndOfStream) 
            {
                string st = sr.ReadLine();
                hum.Add(st.Split(' '));
            }
            
            var a = hum.Where(y => int.Parse(y[3]) % 1 == 0);
            Console.WriteLine("Исходные данные:");
            foreach (string[] y in a)
            {
                Console.WriteLine(string.Join(" ", y));
            }
            sr.Close();

            Console.WriteLine();


            var b = hum.Where(x => int.Parse(x[3]) % 3 == 0);
            Console.WriteLine("Изменённые данные:");
            foreach (string[] x in b)
            {
                Console.WriteLine(string.Join(" ", x));
            }
            Console.ReadKey();
        }
    }
}
