using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
<<<<<<< HEAD
    public class RankedGradeBook : BaseGradeBook
=======
    class RankedGradeBook : BaseGradeBook
>>>>>>> b1139f08c688b8b392a63018181923426afc3462
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }
    }
}
