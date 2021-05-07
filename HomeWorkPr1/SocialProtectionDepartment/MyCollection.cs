using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialProtectionDepartment
{
    public class MyCollection :ICollection
    {
        Citizen[] collection;
        Pensioner[] pensia;
        private int count;

        public MyCollection()
        {
            collection = new Citizen[0];
            count = 0;
            pensia = new Pensioner[0];
        }
        public int Count { get { return count; } }

        public bool IsSynchronized => throw new NotImplementedException();

        public object SyncRoot => throw new NotImplementedException();

       public void Add(Citizen item)
       {
           if (item is Citizen)
           {
                if (collection.Contains(item))
                {
                    throw new Exception();
                }
                else
                {

                    if (item is Pensioner)
                    {
                        Array.Resize<Pensioner>(ref pensia, pensia.Length + 1);
                        pensia[pensia.Length - 1] = (Pensioner)item;
                    }
                    else
                    {
                        Array.Resize<Citizen>(ref collection, collection.Length + 1);
                        collection[collection.Length - 1] = item;
                    }

                    Array.Resize<Citizen>(ref collection, collection.Length + pensia.Length);
                    pensia.CopyTo(collection, 0);
                }

           }
            else Console.WriteLine("citizen of another state or stateless person");
      
       }

      // public override bool Equals(object obj)
      // {
      //     var otherCitizen = obj as Citizen;
      // 
      //     return otherCitizen?.Passport == item.Passport ;
      // }
        public bool Contains(Citizen value)
       {
           for (int i = 0; i < collection.Length; i++)
           {
               if (collection[i].Passport == value.Passport)
                   return true;
           }
           return false;
       }
        public void Clear()
        {
            collection = new Citizen[0];
        }
        public IEnumerator GetEnumerator()
        {
            return collection.GetEnumerator();
        }
       
        public void RemoveAt(int index)
        {
            if ((index >= 0) && (index < Count))
            {
                for (int i = index; i < Count - 1; i++)
                    collection[i] = collection[i + 1];

                count--;
            }
        }
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }
    }
}
