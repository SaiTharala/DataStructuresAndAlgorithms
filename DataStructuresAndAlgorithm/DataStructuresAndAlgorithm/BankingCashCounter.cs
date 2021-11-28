using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructuresAndAlgorithm
{
    class BankingCashCounter
    {
        Queue<string> List = new Queue<string>();
        public void Counter()
        {
            int amount = 20000;
            Console.WriteLine("Enter the number of people in Queue\n");
            int number = Convert.ToInt32(Console.ReadLine());
            string[] names = new string[number];
            Console.WriteLine("Enter Names Of People\n");
            for (int i = 0; i < number; i++)
            {
                names[i] = Console.ReadLine();
                List.Enqueue(names[i]);
            }
            for (int j = 0; j < names.Length; j++)
            {
                Console.WriteLine("Customer: {0}", names[j]);
                Console.WriteLine("Select Opption\n 1.Deposit\n 2.Withdrawl\n");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter The Amount To Deposit\n");
                        int deposit = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Amount Deposited is " + deposit);
                        amount = amount + deposit;
                        Console.WriteLine("Total Balance = " + amount);
                        List.Dequeue();
                        break;
                    case 2:
                        Console.WriteLine("Enter The Amount To Withdrawn\n");
                        int withdrawl = Convert.ToInt32(Console.ReadLine());
                        if (withdrawl <= amount && amount > 0)
                        {
                            Console.WriteLine("Amount Withdrawn is " + withdrawl);
                            amount = amount - withdrawl;
                            Console.WriteLine("Total Balance = " + amount);
                            List.Dequeue();
                        }
                        else
                        {
                            Console.WriteLine("Insufficient Funds!!\n");
                        }
                        break;
                    default:
                        Console.WriteLine("Enter Correct Option\n");
                        break;
                }
            }
        }
    }
}