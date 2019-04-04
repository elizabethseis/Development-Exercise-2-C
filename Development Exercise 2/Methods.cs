using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Development_Exercise_2
{
    class Methods
    {

        private string sex;
        public string word1, word2;
        int number;
        int i;
        public void AddMateria(string pname)
        {
            string name;

            name = pname;
            Console.WriteLine("Nombre de Materia: " + name);
        }


        public void AddMateria(string pname, int ptotalAlumnos)
        {
            string name;
            int totalAlumnos;

            name = pname;
            totalAlumnos = ptotalAlumnos;
            Console.WriteLine("Nombre de Materia: " + name);
            Console.WriteLine("Total de Alumnos; " + totalAlumnos);

        }

        
       public void SetSex(string pSex)
        {
            sex = pSex;
           
        }
        public string GetSex()
        {
            return sex;
        }

        public bool CheckForPalindrome(string pword1, string pword2)
        {
            word1 = pword1;
            word2 = pword2;
            bool result;
            char[] charWord1 = word1.ToCharArray();
            char[] charWord2 = word2.ToCharArray();
            Array.Reverse(charWord1);
            Array.Reverse(charWord2);
            string word1converted = new string(charWord1);
            string word2converted = new string(charWord2);
            if (word1 == word1converted)
            {
                Console.WriteLine("This word " + word1 + " is palindriome");
                result = true;
            }
            else
            {
                Console.WriteLine("This word " + word1converted + " is not a palindriome");
                result = false;
            }

            if (word2 == word2converted)
            {
                Console.WriteLine("This word " + word2 + " is palindriome");
                result = true;
            }
            else
            {
                Console.WriteLine("This word " + word2 + " is not a palindriome");
                result = false;
            }

            return result;
       
        }

        public void DiagonalPrint(int pnumber)
        {
            number = pnumber;
            int[] numbers = new int[number];
            
            for ( i = 0; i < number; i++)
            {
                Console.WriteLine("Enter the " + i + " number");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            string space = " ";
            StringBuilder builder = new StringBuilder();
            for (i = 0; i < number; i++)
            {

                space += " ";
                builder.Append('\n' + space + +numbers[i]);
                

            }
            Console.WriteLine(builder);
        }
    }
}
