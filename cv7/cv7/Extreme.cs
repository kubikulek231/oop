using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv7
{
    public class Extreme
    {
        public static T MinArea <T>(IEnumerable<T> objects) where T : IComparable
        {
            return objects.Min();
        }
        public static T MaxArea<T>(IEnumerable<T> objects) where T : IComparable
        {
            return objects.Max();
        }
    }
}
