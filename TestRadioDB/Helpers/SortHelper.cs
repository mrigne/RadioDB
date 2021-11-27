using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRadioDB.Helpers
{
    class SortHelper
    {
        public static int SortByName<T>(T el1, T el2)
        {
            return ((string)el1.GetType().GetProperty("Name").GetValue(el1, null)).CompareTo((string)el2.GetType().GetProperty("Name").GetValue(el2, null));
        }
    }
}
