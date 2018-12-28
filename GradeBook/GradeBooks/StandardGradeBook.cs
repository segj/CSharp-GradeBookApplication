using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(String name, bool IsWeighted) : base(name, IsWeighted)
        {
            Type = GradeBookType.Standard;
        }
    }
}
