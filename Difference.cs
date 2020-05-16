using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRedAlert
{
    class Difference
    {
        int[] Preform(char Operator, int[] Array1, int[] Array2)
        {
            int[] temp = new int[0];
            sort(ref Array1);
            sort(ref Array2);
            int LA1 = Array1.Length;
            int LA2 = Array2.Length;
            if (Operator == '⋃')
            {
                return (Union(Array1, Array2, LA1, LA2));

            }
            else if (Operator == '⋂')
            {
                return (Intersection(Array1, Array2, LA1, LA2));
            }
            else if (Operator == '`' || Operator == '-')
            {
                return (Difference(Array1, Array2, LA1, LA2));
            }
            else
            {
                return temp;
            }
        }
        int[] Difference(int[] Array1, int[] Array2, int LA1, int LA2)
        {
            int[] result = new int[LA1 + LA2];
            int i = 0, j = 0, index = 0;
            bool flag = true;
            while (i < LA1)
            {
                for (j = 0; j < LA2;)
                {
                    if (Array1[i] == Array2[j])
                    {
                        flag = false;
                        break;
                    }
                    j++;
                }
                if (flag == true)
                {
                    result[index] = Array1[i];
                    index++;
                }
                flag = true;
                i++;
            }
            return result;
        }
    }
}
