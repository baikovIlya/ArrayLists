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

    public class EmptyListTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new ArrayList()};
            yield return new object[] { new ArrayList(new int[] { })};

        }
    }

    public class WhenIndexIsWrongTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new ArrayList(new int[] { 0,1}) };
            yield return new object[] { -2, new ArrayList(new int[] {8,7,4,1 }) };

        }
    }

    public class WhenCountIsWrongTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 3, new ArrayList(new int[] { 0, 1 }) };
            yield return new object[] { 0, new ArrayList(new int[] { 0, 1 }) };
            yield return new object[] { -2, new ArrayList(new int[] { 8, 7, 4, 1 }) };

        }
    }

    public class WhenListIsEmptyTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new ArrayList(new int[] {}) };
            yield return new object[] { 0, new ArrayList(new int[] {}) };
            yield return new object[] { -2, new ArrayList(new int[] {}) };

        }
    }

    public class DeleteElementsByIndexWhenIndexIsWrongTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, 1, new ArrayList(new int[] { 0, 1 }) };
            yield return new object[] { -2, 1, new ArrayList(new int[] { 8, 7, 4, 1 }) };

        }
    }

    public class DeleteElementsByIndexWhenCountIsWrongTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {1, 3, new ArrayList(new int[] { 0, 1 }) };
            yield return new object[] {1, 0, new ArrayList(new int[] { 0, 1 }) };
            yield return new object[] {1, -2, new ArrayList(new int[] { 8, 7, 4, 1 }) };

        }
    }

    public class DeleteElementsByIndexWhenListIsEmptyTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {1, 1, new ArrayList(new int[] { }) };
        }
    }

    public class AddAnotherListByIndexWhenIndexIsWrongTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 3, new ArrayList(new int[] {1,1 }), new ArrayList(new int[] {1,1 }) };
            yield return new object[] { -1, new ArrayList(new int[] {2,3,4 }), new ArrayList(new int[] {5,1,6 }) };
            yield return new object[] { 1, new ArrayList(new int[] { }), new ArrayList(new int[] {5,3 }) };

        }
    }
}
