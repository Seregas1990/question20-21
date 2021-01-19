using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace question20_21
{
    public class Q20 <T> where T : struct
    {
        private List<T> list = new List<T>();
            public void Add (T newValue)
        {
            list.Add(newValue);
        }
        public T Return(int searchIdex)
        {
            return list[searchIdex];
        }
        public List<T> ReturnSortedCollection()
        {
            var ret = list;
            return ret.OrderByDescending(l=>l).ToList();
        }
    }
}
