using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MyCollection
    {
        public static IEnumerable<int> SomeMethod(int[] number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i]%2==0)
                {
                    yield return number[i] * number[i];
                }
               //else yield return break;
            }
        }
    }
}
