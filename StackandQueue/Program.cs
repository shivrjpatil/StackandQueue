using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackandQueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Stacks And Queues Operations");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("1.Create Stack\n2.Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Stacks create = new Stacks();
                        create.Push(70);
                        create.Push(30);
                        create.Push(56);
                        create.Display();
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
