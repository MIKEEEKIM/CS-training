using System;
using System.Collections.Generic;


namespace jumingcanshu

{

    class Programme


    {


        static void Main(string[] args) 


                                        
        {

            //  Printinfo(age: 99, name:"wongyan");


            double x = 3.1415926;

            double y = x.Round( 3);
            Console.WriteLine(y);


        }

       /* static  void Printinfo(string name="default",int age=1)
        {

            Console.WriteLine("hello{0},你今年应该{1}岁了",name,age);

        }

    */
       

        


    }



    static class DoubleExtension

    {

        public static double Round(this double input, int digits)
        {
            double result = Math.Round(input, digits);
            return result;



        }










    }

    }