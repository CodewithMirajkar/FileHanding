//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FileHanding
//{
//    internal class _06DeleteFile
//    {
//        public static void Main(string[] args)
//        {
            
//            string filePath = "C:\\CSharp\\sample_Copy.txt";

//            try
//            {
                
//                if (File.Exists(filePath))                
//                {
                    
//                    File.Delete(filePath);

                    
//                    Console.WriteLine("File 'sample_copy.txt' deleted successfully.");
//                }
//                else
//                {
                    
//                    Console.WriteLine("File 'sample_copy.txt' does not exist.");
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
