using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Project_CA
{
   
    public class Functionality
    {
        public static string fullFileName = @"C:\Users\fedor\Desktop\Math\";
        public static string fileName;
        public static List<string> parametrs = new List<string>();
        public static void CreateFile()
        {
            Console.WriteLine("Entry filename: ");
            string fileName = Console.ReadLine();
            
            if (File.Exists(fullFileName + fileName))
            {
                Console.WriteLine("A file with this name already exists. Do you want to re-record it?" +
                    "\n1.Yes" +
                    "\n2.No");
                int choiceStatus = Int32.Parse(Console.ReadLine());
                switch (choiceStatus) 
                {
                    case 1: 
                        File.Delete(fullFileName + fileName);
                        break;

                    case 2:
                        CreateFile();
                        break;
                        
                }
                
            }
            FileStream fileStream = File.Create(fullFileName + fileName);

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
            Console.Clear();
            using(StreamReader sr = new StreamReader(fullFileName + fileName))
            {
                string info;
                string[] parametr = { };
                while ((info = sr.ReadLine()) != null) 
                {
                    parametr = info.Split('\n');
                    parametrs.AddRange(parametr);
                }
                GetFile(parametrs);
            }

            
        }

        public static void SaveFile(List<string> value) 
        {
            using (StreamWriter sw = new StreamWriter(fullFileName + fileName, false)) 
            {
                foreach (string par in value) 
                {
                    sw.WriteLine(par);
                }
            }
        }

        public static void GetFile(List<string> value) 
        {
            foreach(string par in value)
            {
                Console.WriteLine(par);
            }
        }
    }

}
