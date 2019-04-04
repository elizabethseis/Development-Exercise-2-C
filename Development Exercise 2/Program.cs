using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Development_Exercise_2
{
    class Program
    {

        static void Main(string[] args)
        {
            // Constructor that will initialize a class variable
            Students obj1 = new Students("Elizabeth", "History", 6.7);
            Console.WriteLine("Materia: " + obj1.materia);
            Console.WriteLine("Nombre: " + obj1.name);
            Console.WriteLine("Grado: " + obj1.Grade);

            //Apply constructor overloading.
            Students obj2 = new Students("Eduardo", "Matematicas", 8.9, 23);
            Console.WriteLine("Materia: " + obj2.materia);
            Console.WriteLine("Nombre: " + obj2.name);
            Console.WriteLine("Grado: " + obj2.Grade);
            Console.WriteLine("Edad: " + obj2.age);

            //Apply method overloading.
            Methods obj3 = new Methods();
            obj3.AddMateria("Biologia");
            obj3.AddMateria("Quimica", 45);

            //Create a property that returns a string.
            Methods obj4 = new Methods();
            obj4.SetSex("Femenino");
            Console.WriteLine("Sexo: " + obj4.GetSex());

            //Create a method to verify if a string is a palindrome (Use the created property).
            Console.WriteLine("Enter the first word:");
            string word1 = Console.ReadLine();
            Console.WriteLine("Enter the second word:");
            string word2 = Console.ReadLine();

            Methods obj5 = new Methods();
            obj5.CheckForPalindrome(word1, word2);
           

            Console.Write("How many numbers do you want to print? ");
            int numbers = Convert.ToInt32(Console.ReadLine());
            Methods obj6 = new Methods();
            obj6.DiagonalPrint(numbers);
            Console.ReadLine();


        }
    }
}
