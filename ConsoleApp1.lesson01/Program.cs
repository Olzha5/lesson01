using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.lesson01
{
    internal class Program
    {
        static void Emp02()
        {
        
            Console.WriteLine("Введите ваше имя");
            string name = Console.ReadLine();
            Console.WriteLine("ты ПАКА не занаеш синтаксис C# "+name);
        }

        static void Main(string[] args)
        {
            Emp02();
            Emp01();

        }
        static void Emp01()
        {
            int a,b,c;

            Console.Write("Введите число 1 ");
            string strA = Console.ReadLine();
            a = Int32.Parse(strA);
           

            Console.Write("Введите число 2 ");
            string strB = Console.ReadLine();
            b = Int32.Parse(strA);

            Console.Write("Введите число 3 ");
            string strC = Console.ReadLine();
            c = Int32.Parse(strA);

            int result = a + b + c;
            Console.WriteLine(result);









            //a = Convert.ToInt32(strA);
            //b = Convert.ToInt32(strA);
            //c = Convert.ToInt32(strA);

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);
            //summ = a + b + c;

            //Console.WriteLine(summ);


           // Console.ReadKey();

        }
        //1
        //ear = Convert.ToInt32(trYea4;

        //2 
        //ear = Int32.Parse(trYear);

        //ool result = Int32.TryParse(Console.ReadLine(), out year);

        //f (result == false)
        //
        //   Console.WriteLine("hu");
        //}

    }
  
    // {
    //p01();
    //hort L = 5;//16
    //t i = 2;//32
    //ng j = 3;//64
    //uble d = 12.5;

    //    Console.ReadKey();
}
       




   

