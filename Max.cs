using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtusHome5
{
    public static class Max
    {
        public static T GetMax<T>(this IEnumerable<T> e, Func<T, int> getParameter) where T : class
        {
            T maxElement = null;
            var maxParameterValue = 0;

            foreach (T a in e)
            {
                var parameterValue = getParameter(a);
                if (parameterValue > maxParameterValue)
                {
                    maxParameterValue = parameterValue;
                    maxElement = a;
                }
            }

            return maxElement;
        }
    }
}
