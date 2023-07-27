using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayssss
{
    internal class Program
    {
        const int MaxStudents = 5; 
        static void Main(string[] args)
        {
            runApp();
            Console.ReadKey();
        }
        static void runApp()
        {
            // Arrays to store student names and their corresponding marks
            string[] studentNames = new string[MaxStudents];
            int[] studentMarks = new int[MaxStudents];

            // Input loop to get student names and marks
            for (int i = 0; i < MaxStudents; ++i)
            {
                Console.Write("Enter name for student " + (i + 1) + ": ");
                studentNames[i] = Console.ReadLine();

                Console.Write("Enter marks for student " + (i + 1) + ": ");
                studentMarks[i] = int.Parse(Console.ReadLine());
            }

            // Displaying the stored student names and marks
            Console.WriteLine("\nStudent list with their marks:");
            for (int i = 0; i < MaxStudents; ++i)
            {
                Console.WriteLine(studentNames[i] + ": " + studentMarks[i]);
            }
        }
    }
}
