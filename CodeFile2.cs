using System;
namespace fuckapplication
{

    class Suanmianji
    {

        double chang;
        double kuan;
        public void Acceptdetails()
        {
            chang = 4;

                kuan = 3;




        }

        public double GetArea()

        {

            return chang * kuan;


        }





        public void Display()
        {

            Console.WriteLine("chang:{0}", chang);
            Console.WriteLine("kuan:{0}", kuan);
            Console.WriteLine("mianji:{0}", GetArea());

        }


    }

    class ExecuteRectangle
    {
        static void Main(string[] args)
        {

            Suanmianji r = new Suanmianji ();
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();


        }



    }





}