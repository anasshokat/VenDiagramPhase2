using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRedAlert
{
    class Unions
    {
        // Union Method 
        int[] Union(int[] Array1, int[] Array2, int LA1, int LA2)
        {
            int[] result = new int[LA1 + LA2];
            int index = 0, i = 0, j = 0;
            while (i < LA1 && j < LA2)
            {
                if (Array1[i] < Array2[j])
                {
                    if (Array1[i] != 0)
                    {
                        result[index++] = Array1[i++];        
                    }
                    else
                    {
                        i++;
                    }
                }
                else if (Array2[j] < Array1[i])
                {
                    if (Array2[j] != 0)
                    {
                        result[index++] = Array2[j++];
                    }
                    else
                    {
                        j++;
                    }
                }
                else
                {
                    if (Array2[j] != 0)
                    {
                        result[index++] = Array2[j++];
                        i++;
                    }
                    else
                    {
                        j++; i++;
                    }
                }
                
            }
            while (i < LA1)
            {
                if (Array1[i] != 0)
                {
                    result[index++] = Array1[i++];     
                }
                else
                {
                    i++;
                }
            }
            while (j < LA2)
            {
                if (Array2[j] != 0)
                {
                    result[index++] = Array2[j++];
                }
                else
                {
                    j++;
                }
            }
            return result;
        }
    }
}
