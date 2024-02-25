using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparble_Practice_Hongfei
{
    internal class StudentSortFistNameDsc : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x.FirstName.CompareTo(y.FirstName);

        }
    }
}
