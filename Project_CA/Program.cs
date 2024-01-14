using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an action:" +
                "\n1.Create file" +
                "\n2.Open file");
            int actionStatus = Int32.Parse(Console.ReadLine());
            switch(actionStatus)
            {
                case 1:
                    Functionality.CreateFile();
                    break;
                
                case 2:

                    Functionality.OpenFile();
                    break;
            }

            float weigth;
            float heigth;

            Console.ReadKey();
        }
    }
}
