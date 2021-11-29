using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructuresAndAlgorithm
{
        class OrderedList
    {
        public static LinkedList<int> List = new LinkedList<int>();
        public static string filepath = @"E:\GIT BL\DataStructuresAndAlgorithms\DataStructuresAndAlgorithms\DataStructuresAndAlgorithm\DataStructuresAndAlgorithm\Utility\OrderedList.txt";
        public static string text = File.ReadAllText(filepath);
        public string[] num = text.Split(",");
        List<int> numbers = new List<int>();
        public void Read()
        {
            for (int i = 0; i < num.Length; i++)
            {
                numbers.Add(int.Parse(num[i]));
            }
            numbers.Sort();
            foreach (var item in numbers)
            {
                List.Add(item);
            }
            List.Display();
            this.Write();
        }
        public void Search(int value)
        {
            int count = 0;
            while (count < num.Length)
            {
                if (value == numbers[count])
                {
                    Console.WriteLine("Number Found!!");
                    List.Delete(numbers[count]);
                    this.Write();
                    List.Display();
                    return;
                }
                count++;
            }
            Console.WriteLine("not found\n");
            List.Add(value);
            this.Write();
        }
        public void Write()
        {
            string text = List.Updated();
            File.WriteAllText(filepath, text);
        }
    }
}
