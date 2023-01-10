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
            Stacks stack = new Stacks();
            Console.WriteLine("Welcome to the Stacks And Queues Operations");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("1.Create Stack\n2.PeekAndPop\n3.Exit");
                Console.Write("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.Display();
                        break;
                    case 2:
                        stack.Push(70);
                        stack.Push(30);
                        stack.Push(56);
                        stack.IsEmpty();
                        break;
                    case 3:
                        flag = false;
                        break;
                }
            }
        }
    }
}
