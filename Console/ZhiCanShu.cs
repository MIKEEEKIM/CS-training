using System;
using System.Collections.Generic;



namespace ZhICanShu
{
    class Program
    {
        static void Main(string[] args)


        {
            Student newstu = new Student() { Name = "Tobby" };
            Console.WriteLine("Hash={0},Name={1}", newstu.GetHashCode(), newstu.Name);
            Console.WriteLine("---------------------------------------------");
            IWantSlideEffect(ref newstu);
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Hash={0},Name={1}", newstu.GetHashCode(), newstu.Name);
        }
        static void IWantSlideEffect(ref  Student stu)
      
        {


            stu = new Student() { Name = "Tony" };
            Console.WriteLine("Hash={0},Name={1}",stu.GetHashCode(),stu.Name);



        }



    }

    class Student
    {
        public string Name { get; set; }
        



    }









}



