using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Development_Exercise_2
{
    class Students
    {
        public string name, materia;
        private double grade;
        public int age;

        public Students(string pname, string pmateria, double pgrade)
        {
            name = pname;
            materia = pmateria;
            grade = pgrade;
        }

        public double Grade {
            get
            {
                return grade;
            }
            set
            {
                grade = value;
            }
        }

        public Students(string pname, string pmateria, double pgrade, int page)
        {
            name = pname;
            materia = pmateria;
            grade = pgrade;
            age = page;
        }
    }
}
