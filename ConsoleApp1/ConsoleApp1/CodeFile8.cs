using System;
using System.Reflection;
using System.Windows.Forms;
namespace Typesample

{
    class Program
{

    static void Main(string[] args)
    {

            Type myType = typeof(Form);
            PropertyInfo[] plnfos = myType.GetProperties();
            Console.WriteLine(myType.BaseType.FullName);

            foreach (var p in plnfos)
            {

                Console.WriteLine(p.Name);
            }


    }





}
    class Bguy
    {

        public void Badmethod()
        {


            int x = 100;
            this.Badmethod();

        }



    }











}



