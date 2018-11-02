using System;
using System.Collections.Generic;






namespace ZhICanShu

{
    class Program
    {
        static void Main(string[] args)


        {

            Student stu = null;
            bool C = StudentMaker.Create("mmom", 20, out stu);


            if (C)
            {


                Console.WriteLine("Student{0}'s age is {1}", stu.Name, stu.Age);
            }
            /*
                        Console.WriteLine("Please input first number.");
                        string arg1 = Console.ReadLine();
                        double x = 0;
                       bool bo= double.TryParse(arg1,out x);
                        if (bo==false)
                        {
                            Console.WriteLine("nicuola");
                            return;

                        }




                        Console.WriteLine("Please input second number.");
                        string arg2 = Console.ReadLine();
                        double y = 0;
                        bool boo = double.TryParse(arg2, out y);
                        if (boo == false)
                        {
                            Console.WriteLine("nicuola");
                            return;

                        }

                        double z = x + y;
                        Console.WriteLine("{0}+{1}={2}",x,y,z);
                      */

            /*


            double f= 100;
            bool b = DoubleParser.TryParse("ABC", out f);

            if (b == true)
            {
                Console.WriteLine(f + 1);
            }

            else
            {

                Console.WriteLine(f);




            }





        }
      
    */

        }



        class Student
        {
            public string Name { get; set; }
            public int Age { get; set; }



        }



        class StudentMaker
        {
            public static bool Create(string stuName, int stuAge, out Student result)
            {
                result = null;
                if (string.IsNullOrEmpty(stuName))
                {
                    return false;
                }

                if (stuAge < 20 || stuAge > 80)
                {
                    return false;
                }
                result = new Student() { Name = stuName, Age = stuAge };


                return true;

            }
        }

        class DoubleParser
        {


            public static bool TryParse(string input, out double result)
            {
                try
                {

                    result = double.Parse(input);
                    return true;

                }



                catch
                {

                    result = 0;
                    return false;


                }


            }

        }


    }
}






