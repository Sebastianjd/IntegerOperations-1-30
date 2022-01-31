using System;

namespace IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int myVar;

            Console.Write("Please enter an integer: ");
            myVar = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nmyVar = " + myVar);

            Console.WriteLine("\n-1 + 4 * "+ myVar);
            Console.WriteLine("(35 + 5) % "+ myVar);
            Console.WriteLine("14 + -4 * 6 / 12");
            Console.WriteLine("2 + 12 / 6 * 1 - "+ myVar +" % 2\n");

            Console.WriteLine(-1 + 4 * myVar);
            Console.WriteLine((35 + 5) % myVar);
            Console.WriteLine(14 + -4 * 6 / 12);
            Console.WriteLine(2 + 12 / 6 * 1 - myVar % 2 +"\n");

            if ((myVar * myVar) < 10)
            {
                Console.WriteLine("myVar is less than 4");
            }
            else
            {
                Console.WriteLine("myVar is greater or equal than 4");
            }
        }
    }
}
