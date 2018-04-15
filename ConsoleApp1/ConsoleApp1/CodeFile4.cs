using System;
namespace LiainXi
{
    class Program

    {

        static void Main(string[] args)
        {



            
            Calculator c = new Calculator();
            int y = c.Add(2, 3);
            Console.WriteLine(y);
            string str = c.GetToday();
            Console.WriteLine(str);

        }







    }

    class Calculator
    {
        public int Add(int a, int b)

        {

            int result = a + b;
            return result;


        }



        public string GetToday()
        {
            
            {

                int day = DateTime.Now.Day;
                return day.ToString();

            }
        }
    }



}
