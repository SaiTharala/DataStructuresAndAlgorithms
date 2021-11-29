using System;

namespace DataStructuresAndAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structures And Alogorithm Programs...");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nChoose an Option : \n 1.Unordered List\n 2.Exit\n");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        UnOrderedList unordered = new UnOrderedList();
                        unordered.Read();
                        unordered.Search("R");
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}