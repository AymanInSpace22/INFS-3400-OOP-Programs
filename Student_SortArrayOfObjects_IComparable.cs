using System;

namespace StudentArrayOfObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[8];
            int x;
            int id;
            string name;
            double gpa;

            for(x = 0; x < students.Length; ++x)
            {
                GetData(out id, out name, out gpa);
                students[x] = new Student(id, name, gpa);
            }

            Array.Sort(students);
            Console.WriteLine("Sorted List:");
            for (x = 0; x < students.Length; ++x)
                Display(students[x]);
        }

        static void Display(Student stu)
        {
            Console.WriteLine("{0, 5} {1, -10} {2, 6}", stu.IdNumber, stu.LastName, stu.GradePointAverage.ToString("F1"));
        }

        static void GetData(out int id, out string name, out double gpa)
        {
            string inString;
            Console.Write("Please enter student ID number >> ");
            inString = Console.ReadLine();
            int.TryParse(inString, out id);

            Console.Write("Please enter last name for student {0} >> ", id);
            name = Console.ReadLine();
            Console.Write("Please enter grade point average >> ");
            inString = Console.ReadLine();
            double.TryParse(inString, out gpa);
        }

    }

    // inheriting the IComparable to the student
    class Student : IComparable
    {
        // auto implemented properties
        public int IdNumber { get; set; }
        public string LastName { get; set; }

        // fields
        private double gradePointAverage;

        // constants
        public const double HIGHEST_GPA = 4.0;
        public const double LOWEST_GPA = 0.0;

        // properties
        public double GradePointAverage
        {
            get { return gradePointAverage; }
            set
            {
                if (value >= LOWEST_GPA && value <= HIGHEST_GPA)
                    gradePointAverage = value;
                else
                    gradePointAverage = LOWEST_GPA;
            }
        }


        // constructors
        public Student() : this(0, "XXX", 0.0)
        {

        }

        public Student(int id, string name, double gpa)
        {
            this.IdNumber = id;
            this.LastName = name;
            this.GradePointAverage = gpa;
        }



        // implementing the IComparable method
        int IComparable.CompareTo(Object o)
        {
            int returnVal;
            Student temp = (Student)o;
            if (this.IdNumber > temp.IdNumber)
                returnVal = 1;
            else if (this.IdNumber < temp.IdNumber)
                returnVal = -1;
            else
                returnVal = 0;

            return returnVal;
        }
    }
}
