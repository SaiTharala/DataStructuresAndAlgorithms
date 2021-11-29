using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataStructuresAndAlgorithm
{
    class UnOrderedList
    {
        public static LinkedList<string> List = new LinkedList<string>();
        public static string filepath = @"E:\GIT BL\DataStructuresAndAlgorithms\DataStructuresAndAlgorithms\DataStructuresAndAlgorithm\DataStructuresAndAlgorithm\Utility\UnOrderedclass.txt";
        public static string data = File.ReadAllText(filepath);
        string[] words = data.Split(",");
        public void Read()
        {
            foreach (var result in words)
            {
                List.Add(result);
            }
        }
        public void Search(string value)
        {
            int i = 0;
            while (i < words.Length)
            {
                if (value == words[i])
                {
                    Console.WriteLine("Word Found");
                    List.Delete(words[i]);
                    this.Write();
                    return;
                }
                i++;
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