//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FileHanding
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            FileStream f = new FileStream("C:\\C#\\Demo.txt", FileMode.OpenOrCreate);
//            StreamReader s = new StreamReader(f);
//            f.WriteByte(65);
//            string l = "";
//            l = s.ReadLine();
//            Console.WriteLine(l);
//            for (int i = 65; i <= 90; i++)
//            {
//                f.WriteByte((byte)i);
//            }
//            s.Close();
//            f.Close();
//        }
//    }
//}
