using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CA
{
    public class Functionality
    {
        static string fullFileName = @"C:\Users\fedor\Desktop\Math\";
        static string sample = "Dimensions:\nLength:\nWidth:";
        static string fileName;
        float length;
        float width;
        
        public static void CreateFile() 
        {
            Console.WriteLine("Entry filename: ");
            string fileName = Console.ReadLine();
            
            if (File.Exists(fullFileName + fileName))
            {
                Console.WriteLine("A file with this name already exists. Do you want to re-record it?");
                int choiceStatus = Int32.Parse(Console.ReadLine());
                switch (choiceStatus) 
                {
                    case 1: 
                        File.Delete(fullFileName + fileName);
                        break;

                    case 2:
                        Console.WriteLine("to be continue");
                        break;
                }
                
            }
            FileStream fileStream = File.Create(fullFileName + fileName);
            
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.Write(sample);
            streamWriter.Close();
            

        }

        public static void OpenFile()
        {
            Console.WriteLine("Entry file:");
            var fileList = Directory.EnumerateFiles(fullFileName, "*.txt", SearchOption.TopDirectoryOnly);
            foreach (var file in fileList)
            {
                Console.WriteLine(file);
            }

            Console.WriteLine("Select file:");
            fileName = Console.ReadLine();
            using(StreamReader sr =  new StreamReader(fullFileName + fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null) 
                {
                    Console.WriteLine(line);
                }
            }


        }

    }

}
