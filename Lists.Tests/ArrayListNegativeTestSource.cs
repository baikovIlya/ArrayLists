using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Tests
{
    public class AddByIndexNegativeTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, -1, new ArrayList(new int[] { 0, 3 })};
            yield return new object[] { 2, 3, new ArrayList(new int[] { 0, 3 })};
            yield return new object[] { 2, 1, new ArrayList(new int[] {  })};

        }
    }
}
