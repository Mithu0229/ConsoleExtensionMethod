using System;

namespace ConsoleExtensionMethod
{
    class Geek
    {

        // Method 1
        public void M1()
        {
            Console.WriteLine("Method Name: M1");
        }

        // Method 2
        public void M2()
        {
            Console.WriteLine("Method Name: M2");
        }

        // Method 3
        public void M3()
        {
            Console.WriteLine("Method Name: M3");
        }

    }


    static class NewMethodClass
    {

        // Method 4
        public static void M4(this Geek g)
        {
            Console.WriteLine("Method Name: M4");
        }

        // Method 5
        public static void M5(this Geek g, string str)
        {
            Console.WriteLine(str);
        }
    }
    public class Program
    {
       
        static void Main(string[] args)
        {
            //Geek g = new Geek();
            //g.M1();
            //g.M2();
            //g.M3();
            //g.M4();
            //g.M5("Method Name: M5");

            Person person = new Person { Name = "John", Age = 12 };
            Console.WriteLine(person);
        }
    }

    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return "Person: " + Name + " " + Age;
        }
    }
}
