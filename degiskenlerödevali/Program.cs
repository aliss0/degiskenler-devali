using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace degiskenlerödevali
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Word");
            Console.WriteLine("İsminizi Giriniz:");

            string name = Console.ReadLine();
            Console.WriteLine("Soyiminizi Giriniz:");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba" + name + "" + surname);

            byte b = 5;
            sbyte c = 5;

            short s = 5;
            ushort us = 5;

            Int16 i16 = 2;
            int i = 2;
            Int32 i32 = 2;
            Int64 i64 = 2;

            uint ui = 2;
            long l = 4;
            ulong ul = 4;

            float f = 5;
            double d = 5;
            decimal de = 5;

            char cr = '2';
            string str = "Ali";

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);


            object o1 = "s";
            object o2 = 's';
            object o3 = 4;
            object o4 = 4.3;


            string str1 = string.Empty;
            str1 = "Ali Uygun";
            string ad = "Ali";
            string sad = "Uygun";

            int i1 = 5;
            int i2 = 3;
            int carp = i1 * i2;

            string stry = "38";
            int i3 = 20;
            string yenidger = stry + i3.ToString();
            Console.WriteLine(yenidger);

            int int30 = i3 + Convert.ToInt32(stry);
            Console.WriteLine(int30);

            string date = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(date);



            Console.ReadLine();
        }
    }
}
