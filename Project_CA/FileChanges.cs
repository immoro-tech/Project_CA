using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_CA
{
    public class FileChanges : Functionality
    {
        static float squery;
        static float perimetr;
        static float length;
        static float width;
        
        static public void AddDimensions() 
        {
            Console.WriteLine("Add Dimensoins");
            string addRequest;
            Console.WriteLine("Entry Length:");
            length = float.Parse(Console.ReadLine());

            Console.WriteLine("Entry Heigth:");
            width = float.Parse(Console.ReadLine());

            perimetr = length + width;
            squery = length * width;

            addRequest = $"{length} {width} {perimetr} {squery}";

            parametrs.Add(addRequest);
            GetFile(parametrs);

            Console.WriteLine("Continue or Save & Exit?");
            int request = Int32.Parse(Console.ReadLine());

            switch (request)
            {
                case 1:
                    Console.WriteLine("Add or Change dimensions?");
                    int k = Int32.Parse(Console.ReadLine());
                    switch (k) 
                    {
                        case 1: AddDimensions(); break;
                        case 2: ChangesDimensions(); break;
                    }
                    break;
                case 2:
                    SaveFile(parametrs);
                    break;
            }
        }

        static public void ChangesDimensions()
        {
            string parametr = "";
            Console.WriteLine("Changes Dimensions");
           
            Console.WriteLine("Entry row:");
            int row = Int32.Parse(Console.ReadLine()) - 1;

            if (row <= parametrs.Count) {
                parametr = parametrs[row];
                Console.WriteLine(parametr);
            }
            else
            {
                Console.WriteLine("Incorrect row!");
            }
            string[] element = parametr.Split(' ');

            Console.WriteLine("Change length or width or all?");
            int i = Int32.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    Console.WriteLine("Change length:");
                    element[0] = Console.ReadLine();
                    break;
                
                case 2:
                    Console.WriteLine("Change width:");
                    element[1] = Console.ReadLine();
                    break;
                
                case 3:
                    Console.WriteLine("Change length and width:");
                    element[0] = Console.ReadLine();
                    element[1] = Console.ReadLine();
                    break;
            }

            length = float.Parse(element[0]);
            width = float.Parse(element[1]);

            perimetr = length + width;
            squery = length * width;

            parametrs[row] = $"{length} {width} {perimetr} {squery}";
            
            GetFile(parametrs);

            Console.WriteLine("Continue or Save & Exit?");
            int request = Int32.Parse(Console.ReadLine());
            
            switch (request) 
            {
                case 1:
                    Console.WriteLine("Add or Change dimensions?");
                    int k = Int32.Parse(Console.ReadLine());
                    switch (k) 
                    {
                        case 1 : AddDimensions(); break;
                        case 2 : ChangesDimensions(); break;
                    }
                    break;
                
                case 2:
                    SaveFile(parametrs);
                    break;
            }
        }

    }
}
