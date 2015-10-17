using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's demo formatting strings. Press Enter to begin....");
            Console.ReadLine();
            Console.Clear();

            DemoSubstituationStrings();
            Leftalign();
            Rightalign();
            FormatNumericalData();
            StringDotformat();
        }
        static void DemoSubstituationStrings()
        {
            Console.WriteLine("Substituation string are easier to read than concatination");
            Console.WriteLine("------------------------");

            Console.Write("What is our name: ");
            string UserName = Console.ReadLine();

            Console.Write("What is your favorite color: ");
            string FavoriteColor = Console.ReadLine();

            Console.WriteLine("Hello {0}! your favroite color is {1}.\nI am a Big fan of the name {0}.\n",UserName, FavoriteColor);
            Console.WriteLine("My favorite Number is {0}.", 7);
            Console.WriteLine("Press Enter to continue....");
            Console.ReadLine();
            Console.Clear();

        }
        static void Leftalign()
        {
            Console.WriteLine("Put a commma or negative number to left align. ex: {0, -15}");
            Console.WriteLine("--------------------------");
            string Lineoutputformat = "{0,-15} {1,-2} {2,-5}";
            Console.WriteLine(Lineoutputformat, "Binay Mishra", "KA", "560066");
            Console.WriteLine(Lineoutputformat, "Ayush Mishra", "TN", "780069");
            Console.WriteLine(Lineoutputformat, "Sonu Mishra", "JH", "827001");

            Console.WriteLine("\nPress Enter to continue....");
            Console.ReadLine();
            Console.Clear();
        }
        static void Rightalign()
        {
            Console.WriteLine("put a comma or a positive number to right align. ex {1, 9}");
            Console.WriteLine("--------------");

            string Lineoutputformat = "{0, -15} {1,9:C}";
            Console.WriteLine(Lineoutputformat, "SBI12345678", 5302.32);
            Console.WriteLine(Lineoutputformat, "HDFC1234567", 27.32);

            Console.WriteLine(Lineoutputformat, "ICICI123456", 1232706.00);
            Console.WriteLine("\n Press enter to continue.....");
            Console.ReadLine();
            Console.Clear();

        }
        static void FormatNumericalData()
        {
            Console.WriteLine("The value of 12345 in various formats:\n");
            Console.WriteLine("c format: {0:c}", 12345);
            Console.WriteLine("d9 format: {0:d9}", 12345);
            Console.WriteLine("f3 format: {0:f3}",12345);
            Console.WriteLine("n format: {0:n}",12345);
            
            Console.WriteLine("\n");

            Console.WriteLine("E format: {0:E}",12345);
            Console.WriteLine("e format: {0:e}",12345);

            Console.WriteLine("For hex we will use 99999 to get some letters.");
            Console.WriteLine("X format: {0:X}",12345);
            Console.WriteLine("x format: {0:x}",12345);

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        static void StringDotformat()
        {
            string totalLine = string.Format("Total: {0:c}",25.39);
            Console.WriteLine(totalLine);
            Console.WriteLine("\n Press enter to continue...");
            Console.ReadLine();
            Console.Clear();
        }
        }
    }

