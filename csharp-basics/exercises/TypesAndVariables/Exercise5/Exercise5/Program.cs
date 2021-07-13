using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teachers = {"Ms.Lapan", "Mrs.Gideon", "Mr.Davis", "Ms.Palmer", "Ms. Garcia", "Mrs. Barnett", "Ms. Johannessen", "Mr. James"};
            string[] classes = {"English III", "Precalculus", "Music Theory", "Biotechnology", "Principles of Technology I", "Latin II", "AP US History", "Business Computer Infomation Systems"};
            int teacherFreeSpaceLineLength = 16;
            int classesFreeSpaceLineLength = 37;

            Console.WriteLine("+------------------------------------------------------------+");
            
            for(int i = 0; i < teachers.Length; i++)
            {
                string freeSpaceClasses = "";
                string freeSpaceTeachers = "";

                for(int j = 0; j < classesFreeSpaceLineLength - classes[i].Length; j++)
                {
                    freeSpaceClasses += " ";
                }

                for(int k = 0; k < teacherFreeSpaceLineLength - teachers[i].Length; k++)
                {
                    freeSpaceTeachers += " ";
                }

                Console.WriteLine($"| {i + 1} |{freeSpaceClasses}{classes[i]} |{freeSpaceTeachers}{teachers[i]} |");
            }

            Console.WriteLine("+------------------------------------------------------------+");
            Console.ReadKey();
        }
    }
}
