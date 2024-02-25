using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparble_Practice_Hongfei
{
    internal class StudentSortLastNameDsc : IComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x.LastName.CompareTo(y.LastName);
        }
    }
}
