using System;


namespace ConversionExample
{





    class Program
    {
        static void Main(string[] args)
        {


            XiaoXuan X = new XiaoXuan();
            Asmr A = X;
            X.FaSao();
            Console.WriteLine(ushort.MaxValue);
            var v = 3* 4;
           

                }
    }

    class Chibo
    {
        public void Eat()
        {
            Console.WriteLine("喽就完事了");
        }
    }


    class Asmr : Chibo
    {

        public void Rub()
        {
            Console.WriteLine("shahshahsahshsah");
        }

    }

    class XiaoXuan : Asmr
    {
        public void FaSao()
        {
            Console.WriteLine("How you doing?");


        }



    }
}




 
    