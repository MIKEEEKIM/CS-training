using System;
namespace LiainXi
{
    class Program

    {

        static void Main(string[] args)
        {



            float x = 3.0F;
            Console.WriteLine(x.GetType().Name);
            Calculator c = new Calculator();
            int y = c.Add(2, 3);
            Console.WriteLine(y);
            c.PrintSum(4, 6);

        }







    }

    class Calculator
    {
        public int Add(int a, int b)

        {

            int result = a + b;
            return result;


        }







        public void PrintSum(int a, int b)
        {

            int reslit = a + b;
            Console.WriteLine(reslit);


        }

    }




    



}
