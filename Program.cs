using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 26;
            int height = 61;

           //Max heartrate is equal to 220 - age

            int heartrate = 220 - age;

            // COnsole should write : I am ## years old, my max heartrate is ##
            // I am ## cms tall


            Console.WriteLine("I am " + age + " years old, my max heartrate is " + heartrate + " and I am " + height +
                "cms tall");
        }
    }
}
