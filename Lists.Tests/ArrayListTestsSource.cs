using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Tests
{
    public class AddFirstTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new ArrayList(new int[] { 1, 2 }), new ArrayList(new int[] {  2,1, 2 }) };
            yield return new object[] { 2, new ArrayList(new int[] { 1}), new ArrayList(new int[] {2, 1 }) };
            yield return new object[] { 2, new ArrayList(), new ArrayList(new int[] {2 }) };
            yield return new object[] { 2, new ArrayList(2), new ArrayList(new int[] {2, 2 }) };
        }
    }

    public class AddByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2,1, new ArrayList(new int[] { 0, 3 }), new ArrayList(new int[] {0, 2, 3}) };
            yield return new object[] { 2,0, new ArrayList(new int[] { 1 }), new ArrayList(new int[] { 2, 1 }) };
            yield return new object[] { 2,2, new ArrayList(new int[] {1,1}), new ArrayList(new int[] {1,1, 2 }) };
            yield return new object[] { 2,0, new ArrayList(), new ArrayList(new int[] { 2 }) };
        }
    }




    public class AddLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new ArrayList(new int[] { 1, 2 }), new ArrayList(new int[]{ 1, 2, 2}) };
            yield return new object[] { 2, new ArrayList(new int[] { 1}), new ArrayList(new int[]{ 1, 2}) };
            yield return new object[] { 2, new ArrayList(), new ArrayList(2) };
            yield return new object[] { 2, new ArrayList(), new ArrayList(new int[] { 2 }) };
            yield return new object[] { 2, new ArrayList(2), new ArrayList(new int[]{2, 2}) };
        }
    }
    public class DeleteAllByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            int expected_result = 2;
            ArrayList list = new ArrayList(new int[]{1,2,3,4,3,5});
            ArrayList expected_list = new ArrayList(new int[]{1,2,4,5});
            yield return new object[] {value, expected_result, list, expected_list};
            yield return new object[] {1, 0, new ArrayList(3), new ArrayList(3)};
            yield return new object[] {1, 1, new ArrayList(1), new ArrayList()};
            yield return new object[] {3, 4, new ArrayList(new int[] { 3, 3, 3, 3 }), new ArrayList()};
            yield return new object[] {2, 1, new ArrayList(new int[] { 1, 2}), new ArrayList(1)};
        }
    }









}



//public class AddLastTestSource : IEnumerable
//{
//    public IEnumerator GetEnumerator()
//    {
//        yield return new object[] { 2, new ArrayList(new int[] { 1, 2 }), new ArrayList(new int[] { 1, 2, 2 }) };
//    }
//}
