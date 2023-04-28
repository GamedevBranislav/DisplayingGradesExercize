using System;

namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //program which allow teacher to enter amount of students, name and their score
            //and then will be displayed their averagegrades and highest grade in class

            Console.WriteLine("Enter the amount of students in your class");
            int amountOfStudents = int.Parse(Console.ReadLine());

            double averageGrade = 0;
            double highestGrade = 0;
            string highestGradeName = "";

            string[] studentNames = new string[amountOfStudents];
            double[] grades = new double[amountOfStudents];

            for (int i = 0; i < amountOfStudents; i++)
            {
                Console.WriteLine("Enter student #{0} name", i + 1);
                string name = Console.ReadLine();
                studentNames[i] = name;
                Console.WriteLine("Enter student #{0} grade", i + 1);
                double grade = double.Parse(Console.ReadLine());
                grades[i] = grade;
                averageGrade += grade;
                if(grade > highestGrade)
                {
                    highestGrade = grade;
                    highestGradeName = name;
                }
            }

            // printing

            averageGrade /= amountOfStudents;
            Console.WriteLine("The average grade of the class is {0}", averageGrade );
            Console.WriteLine("The highest grade of the class is {0}" +
            " and their name was {1}", highestGrade, highestGradeName);



            //binarysearch works if numbers are in order 1 5 7 9 12... 
            //(skipping numbers because it knows, numbers are in order)
            //int[] myArray = { 10, 15, 20, 30, 35, 40, 45 };
            //Console.WriteLine("Enter number to check if it exists");
            //int number = int.Parse(Console.ReadLine());

            //int answer = Array.BinarySearch(myArray, number);
            //if (answer < 0)
            //{
            //    Console.WriteLine("Number does not exist");
            //}
            //else
            //{
            //    Console.WriteLine("The number position in array is {0}", answer);
            //}

            //int[] myArray = { 5, 12, 3, 7, 18, 1, 29 };
            //Array.Sort(myArray);
            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    //will sort all numbers 1,3,5,7...
            //    Console.WriteLine(myArray[i]);
            //}
        }
    }
}
