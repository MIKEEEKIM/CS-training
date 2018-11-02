using System;
using System.Collections.Generic;

namespace DataMemberExample

{

    class Program


    {
        static void Main(string[] args)
        {
                Student stu = new Student();
            stu["Math"] = 99;
                var mathScore = stu["Math"];
                Console.WriteLine(mathScore);
        
        }

    }

    class Student
    {
        private Dictionary<string, int> scoreDictionary = new Dictionary<string, int>();
        public int? this[string subject]
        {
            get {
                if (this.scoreDictionary.ContainsKey(subject))
                {
                    return this.scoreDictionary[subject];
                }

                else
                {
                    return null;
                }

            }
            set {

                if (value.HasValue == false)
                {
                    throw new Exception("you know nothing");


                }




                if (this.scoreDictionary.ContainsKey(subject))

                {
                    this.scoreDictionary[subject]= value.Value;
                }
                else
                {
                    this.scoreDictionary.Add(subject, value.Value);
                }


            }



        }

        
    }
      

    }



