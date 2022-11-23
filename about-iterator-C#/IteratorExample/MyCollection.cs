using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample
{
    internal class MyCollection : IEnumerable<int>
    {
        private List<int> elements = new List<int> { 1, 2, 3, 4, 5, 6 };

        // since we implement IEnumerable

        public IEnumerator<int> GetEnumerator()
        // method 1
        //=> new MyCollectionEnumerator(this); // it works

        // method 2
        { 
            foreach (int n in elements)
            {
                yield return n;
                // this yield syntax continues where it yeilds off the prev time
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        => (this as IEnumerable<int>).GetEnumerator();
        //=> this.GetEnumerator(); THIS IS NOT POSSIBLE !!!
        // is like an infinite loop, ?

        // helper class
        class MyCollectionEnumerator : IEnumerator<int>
        {
            public MyCollectionEnumerator(MyCollection coll)
            {
                _coll = coll;
            }

            int current = -1; // it has to be init to -1 !
            private readonly MyCollection _coll;

            public int Current => _coll.elements[current];

            object IEnumerator.Current => (this as IEnumerator<int>).Current;

            public void Dispose()
            {//not used
            }

            public bool MoveNext()
            {
                current += 1;
                return _coll.elements.Count > current;
            }

            public void Reset()
            {
                throw new NotImplementedException();
            }
        }
    }
}
