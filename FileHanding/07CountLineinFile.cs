//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FileHanding
//{
//    internal class _07CountLineinFile
//    {
//        public static void Main(string[] args)
//        {
            
//            string filePath = "C:\\CSharp\\sample.txt";

//            try
//            {
                
//                if (File.Exists(filePath))
//                {
                    
//                    string[] lines = File.ReadAllLines(filePath);
//                    int lineCount = lines.Length;

                    
//                    Console.WriteLine($"The file contains {lineCount} lines.");
//                }
//                else
//                {
                    
//                    Console.WriteLine($"The file '{filePath}' does not exist.");
//                }
//            }
//            catch (Exception ex)
//            {
                
//                Console.WriteLine("An error occurred: " + ex.Message);
//            }
//            Console.ReadLine();
//        }
//    }
//}
