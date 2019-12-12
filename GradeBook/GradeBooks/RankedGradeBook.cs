using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{

    public class RankedGradeBook : BaseGradeBook

    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
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
        
    }
}
