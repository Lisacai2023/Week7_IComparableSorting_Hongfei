using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IComparble_Practice_Hongfei
{
    internal class StudentSortGenEdGrade : IComparer<Student>
    {
        public enum Order { Ascending, Descending };

        public Order SortingOrder = Order.Ascending;

        public StudentSortGenEdGrade()
        {
            SortingOrder = Order.Ascending ;
        }

        public StudentSortGenEdGrade(Order sortingOrder)
        {
            SortingOrder = sortingOrder ;
        }
        public int Compare(Student? x, Student? y)
        {
            if (SortingOrder == Order.Descending)
            {
                if (x.GenEdGrade < y.GenEdGrade)
                {
                    return 1;
                }
                else if (x.GenEdGrade > y.GenEdGrade)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }


            }
            else
            {
                if (x.GenEdGrade > y.GenEdGrade) return 1;
                else if (x.GenEdGrade < y.GenEdGrade) return -1;
                else return 0;
            }
                
            
        }








    }//class
}//namespace
