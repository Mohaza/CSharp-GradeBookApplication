using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{

    public class RankedGradeBook : BaseGradeBook

    {
        public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
        {
            Type = Enums.GradeBookType.Ranked;
            IsWeighted = isWeighted;
        }

        public override char GetLetterGrade(double averageGrade)
        {
           

            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }
           
            switch (averageGrade)
            {
                case var d when d >= 80:
                    return 'A';
                case var d when d < 80 && d >= 60:
                    return 'B';
                case var d when d < 60 && d >= 40:
                    return 'C';
                case var d when d < 40 && d >= 20:
                    return 'D';
                default:
                    return 'F';
            }
        }

        public override void CalculateStatistics()
        {
            var available = Students.FindAll(student => student.Grades.Count != 0);
            
            if (available.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
           
            base.CalculateStatistics();
            
            
           
        }
        public override void CalculateStudentStatistics(string name)
        {
            var available = Students.FindAll(student => student.Grades.Count != 0);
            if(available.Count< 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students with grades in order to properly calculate a student's overall grade.");
                return;
            }
            base.CalculateStudentStatistics(name);
            
            
        }

        

    }
}
