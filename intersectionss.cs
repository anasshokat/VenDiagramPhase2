using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRedAlert
{
    class intersectionss
    {
        static void sort(ref int[] Arr)
        {
            int n = Arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (Arr[j] < Arr[min])
                    {
                        min = j;
                    }
                    int temp = Arr[min];
                    Arr[min] = Arr[i];
                    Arr[i] = temp;
                }
            }
        }
        int[] Intersection(int[] Array1, int[] Array2, int LA1, int LA2)
        {
            int[] result = new int[LA1 + LA2];
            int index = 0, i = 0, j = 0;

            while (i < LA1 && j < LA2)
            {
                if (Array1[i] < Array2[j])
                {
                    i++;
                }
                else if (Array2[j] < Array1[i])
                {
                    j++;
                }
                else
                {
                    result[index++] = Array2[j++];
                    i++;
                }
            }
            return result;
        }
    }
}
