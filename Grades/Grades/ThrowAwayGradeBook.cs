using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    class ThrowAwayGradeBook : GradeBook
    {
        public override GradeStatistics ComputeStatistics()
        {
            float lowest = float.MaxValue;
            foreach (float grade in grades)
            {
                Console.WriteLine("ThrowAwayGradeBook::ComputeStatistics");

                lowest = Math.Min(grade, lowest);
            }
            grades.Remove(lowest);
            return base.ComputeStatistics();
        }
    }
}
