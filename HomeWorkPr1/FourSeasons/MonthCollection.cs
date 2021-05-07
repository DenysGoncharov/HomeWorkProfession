using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourSeasons
{
    public class MonthCollection<T>
    {
        readonly T[] elements = new T[12];

        public T this[int index]
        {
            get { return elements[index]; }
            set { elements[index] = value; }
        }

        int position = -1;

        // Создаем метод Reset().
        public void Reset()
        {
            position = -1;
        }

        // Создаем метод GetEnumerator(), используем оператор yield.
        public IEnumerator GetEnumerator()
        {
            // ---------- 1-й вариант. ----------

          // while (true)
          // {
          //     if (position < elements.Length - 1)
          //     {
          //         position++;
          //         yield return elements[position];
          //     }
          //     else
          //     {
          //         Reset();
          //         yield break;
          //     }
          // }
          //
            // ---------- 2-й вариант. ----------

            //foreach (var element in elements)
            //{
            //    yield return element;
            //}

            // ---------- 3-й вариант. ----------

           return elements.GetEnumerator();
        }
       

    }
}
