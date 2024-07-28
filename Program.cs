using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Logic
    {
        public void add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine($"The Addition of {a} and {b} is: {c}");
        }

        public void sub(int a, int b)
        {
            int c = a - b;
            Console.WriteLine($"The Subtraction of {a} and {b} is: {c}");
        }

        public void mul(int a, int b)
        {
            int c = a * b;
            Console.WriteLine($"The Multiplication of {a} and {b} is: {c}");
        }

        public void div(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return;
            }

            int c = a / b;
            Console.WriteLine($"The Division of {a} and {b} is: {c}");
        }
    }

    class Program
    {
        public delegate void MyDelegate(int a, int b);

        static void Main(string[] args)
        {
            Logic l = new Logic();

            MyDelegate myDel = null;

            Console.WriteLine("Enter first number:");
            int A1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int B2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation: \n1. Addition\n2. Subtraction\n3. Multiplication\n4. Division\n5. All\n");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    myDel = new MyDelegate(l.add);
                    break;
                case 2:
                    myDel = new MyDelegate(l.sub);
                    break;
                case 3:
                    myDel = new MyDelegate(l.mul);
                    break;
                case 4:
                    myDel = new MyDelegate(l.div);
                    break;
                case 5:
                    myDel = new MyDelegate(l.add);
                    myDel += l.sub;
                    myDel += l.mul;
                    myDel += l.div;
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    return;
            }

            myDel?.Invoke(A1, B2);

            Console.ReadLine();
        }
    }
}
