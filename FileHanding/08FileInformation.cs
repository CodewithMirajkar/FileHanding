//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FileHanding
//{
//    internal class _08FileInformation
//    {
//        public static void Main(string[] args)
//        {
//            // Define the file path for sample.txt
//            string filePath = "C:\\CSharp\\sample.txt";

//            try
//            {
                
//                if (File.Exists(filePath))
//                {
                    
//                    FileInfo fileInfo = new FileInfo(filePath);

                    
//                    Console.WriteLine($"File: {filePath}");
//                    Console.WriteLine($"Size: {fileInfo.Length / 1024.0:F} KB");  // Size in KB
//                    Console.WriteLine($"Created on: {fileInfo.CreationTime}");
//                    Console.WriteLine($"Last modified on: {fileInfo.LastWriteTime}");
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
