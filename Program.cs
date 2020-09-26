using System;

namespace console_thingy
{
    class Program
    {
        static void Main(string[] args)
        {
            int pb1;
            int pb2;
            int pb3;

            

            Console.WriteLine("1*10= ");
            pb1 = Convert.ToInt32(Console.ReadLine() );
            if (pb1 != 10)
            {
                Console.WriteLine("Wrong");
            }
            else
            {
                Console.WriteLine("Correct");
            }

            Console.WriteLine("10*2= ");
            pb2 = Convert.ToInt32(Console.ReadLine());
            if (pb2 != 20)
            {
                Console.WriteLine("Wrong");
            }
            else
            {
                Console.WriteLine("Correct");
            }
            Console.WriteLine("10*3");
            pb3 = Convert.ToInt32(Console.ReadLine());
            if (pb3 != 30)
            {
                Console.WriteLine("Wrong");
            }
            else
            {
                Console.WriteLine("Correct");
            }




            Console.ReadKey();
        }
    }
}
