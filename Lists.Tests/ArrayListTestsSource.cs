using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lists.Tests
{
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

    public class DeleteLastTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new ArrayList(new int[] { 0, 3,1 }), new ArrayList(new int[] { 0, 3 }) };
            yield return new object[] { new ArrayList(new int[] { 1 }), new ArrayList(new int[] {}) };
            yield return new object[] { new ArrayList(new int[] { 1, 1 }), new ArrayList(1) };
            
        }
    }

    public class DeleteByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] {0, new ArrayList(new int[] { 0, 3, 1 }), new ArrayList(new int[] { 3,1 }) };
            yield return new object[] {2, new ArrayList(new int[] { 0, 3, 1 }), new ArrayList(new int[] {0, 3 }) };
            yield return new object[] {1, new ArrayList(new int[] { 0, 3, 1 }), new ArrayList(new int[] { 0,1 }) };
            yield return new object[] {0, new ArrayList(new int[] { 1 }), new ArrayList(new int[] { }) };
            yield return new object[] {1, new ArrayList(new int[] { 0,1 }), new ArrayList(0) };

        }
    }

    public class DeleteElementsAtTneEndTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new ArrayList(new int[] { 0, 3, 1 }), new ArrayList(new int[] { 0}) };
            yield return new object[] { 2, new ArrayList(new int[] { 0, 3}), new ArrayList(new int[] {}) };
            yield return new object[] { 1, new ArrayList(new int[] { 0, 3, 1 }), new ArrayList(new int[] { 0, 3 }) };
            yield return new object[] { 1, new ArrayList(new int[] { 1 }), new ArrayList(new int[] { }) };

        }
    }

    public class DeleteElementsFromTheBeginningTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 2, new ArrayList(new int[] { 0, 3, 1 }), new ArrayList(new int[] { 1 }) };
            yield return new object[] { 2, new ArrayList(new int[] { 0, 3 }), new ArrayList(new int[] { }) };
            yield return new object[] { 1, new ArrayList(new int[] { 0, 3, 1 }), new ArrayList(new int[] {  3,1 }) };
            yield return new object[] { 1, new ArrayList(new int[] { 1 }), new ArrayList(new int[] { }) };

        }
    }

    public class DeleteElementsByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1,1, new ArrayList(new int[] { 9,8 }), new ArrayList(new int[] {9 }) };
            yield return new object[] { 1,2, new ArrayList(new int[] { 1,9,9 }), new ArrayList(new int[] {1 }) };
            yield return new object[] { 2,2, new ArrayList(new int[] { 1,0,8,5,6,3,4 }), new ArrayList(new int[] {1,0,6,3,4 }) };
            yield return new object[] { 0,1, new ArrayList(new int[] { 9 }), new ArrayList(new int[] { }) };
            yield return new object[] { 0,1, new ArrayList(new int[] { 9,9,9 }), new ArrayList(new int[] {9,9 }) };

        }
    }

    public class SearchFirstIndexByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 1, 1, new ArrayList(new int[] { 9,1, 8 })};
            yield return new object[] { 8, 2, new ArrayList(new int[] { 1, 9, 8 }) };
            yield return new object[] { 9, -1, new ArrayList(new int[] { 1, 0, 8, 5, 6, 3, 4 })};
            yield return new object[] { 9, 0, new ArrayList(new int[] { 9 })};
            yield return new object[] { 3, 0, new ArrayList(new int[] { 3, 9, 3 })};

        }
    }

    public class ReverseTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new ArrayList(3), new ArrayList(3) };
            yield return new object[] { new ArrayList(), new ArrayList() };
            yield return new object[] { new ArrayList(new int[] { 3, 3, 3, 3 }), new ArrayList(new int[] { 3, 3, 3, 3 }) };
            yield return new object[] { new ArrayList(new int[] { 1, 2 }), new ArrayList(new int[] { 2,1 }) };
            yield return new object[] { new ArrayList(new int[] { 1, 2 ,3,4}), new ArrayList(new int[] {4,3, 2,1 }) };

        }
    }

    public class GetMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new ArrayList(new int[] { 3}), 3 };
            yield return new object[] { new ArrayList(new int[] { -4, -12, -23,-9 }), -4 };
            yield return new object[] { new ArrayList(new int[] { 1, 2, 3, 4 }), 4 };
            yield return new object[] { new ArrayList(new int[] { 1, 4,0,2,1,0,2 }), 4 };
            yield return new object[] { new ArrayList(new int[] { 1, 2, -3, 78 }), 78 };

        }
    }

    public class GetMinTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new ArrayList(new int[] { 3 }), 3 };
            yield return new object[] { new ArrayList(new int[] { -4, -12, -23, -9 }), -23 };
            yield return new object[] { new ArrayList(new int[] { 1, 2, 3, 4 }), 1};
            yield return new object[] { new ArrayList(new int[] { 1, 4, 0, 2, 1, 0, 2 }), 0 };
            yield return new object[] { new ArrayList(new int[] { 1, 2, -3, -78 }), -78 };

        }
    }

    public class GetIndexOfMaxTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new ArrayList(new int[] { 3 }), 0 };
            yield return new object[] { new ArrayList(new int[] { -4, -12, -23, -9 }), 0 };
            yield return new object[] { new ArrayList(new int[] { 1, 2, 3, 4 }), 3 };
            yield return new object[] { new ArrayList(new int[] { 4, 2, 3, 4 }), 0 };
            yield return new object[] { new ArrayList(new int[] { 1, 4, 0, 2, 1, 0, 2 }), 1 };
            yield return new object[] { new ArrayList(new int[] { 1, 2, -3, 78 }), 3 };

        }
    }

    public class GetIndexOfMinTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new ArrayList(new int[] { 3 }), 0 };
            yield return new object[] { new ArrayList(new int[] { -4, -12, -23, -9 }), 2 };
            yield return new object[] { new ArrayList(new int[] { 1, 2, 3, 4 }), 0 };
            yield return new object[] { new ArrayList(new int[] { 1, 4, 0, 2, 1, 0, 2 }), 2 };
            yield return new object[] { new ArrayList(new int[] { 1, 2, -3, -78 }), 3 };

        }
    }

    public class SortAscendingTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new ArrayList(3), new ArrayList(3) };
            yield return new object[] { new ArrayList(), new ArrayList() };
            yield return new object[] { new ArrayList(new int[] { 3, 3, 3, 3 }), new ArrayList(new int[] { 3, 3, 3, 3 }) };
            yield return new object[] { new ArrayList(new int[] { 1, 2 }), new ArrayList(new int[] {  1,2 }) };
            yield return new object[] { new ArrayList(new int[] { 1, -2 }), new ArrayList(new int[] {-2,1 }) };
            yield return new object[] { new ArrayList(new int[] { 1, 12, 33, 24 }), new ArrayList(new int[] { 1, 12, 24, 33 }) };

        }
    }

    public class SortDescendingTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new ArrayList(3), new ArrayList(3) };
            yield return new object[] { new ArrayList(), new ArrayList() };
            yield return new object[] { new ArrayList(new int[] { 3, 3, 3, 3 }), new ArrayList(new int[] { 3, 3, 3, 3 }) };
            yield return new object[] { new ArrayList(new int[] { 1, 2 }), new ArrayList(new int[] { 2,1 }) };
            yield return new object[] { new ArrayList(new int[] { -5,-8,-3,5}), new ArrayList(new int[] { 5,-3,-5,-8}) };
            yield return new object[] { new ArrayList(new int[] { 1, -2 }), new ArrayList(new int[] {  1,-2 }) };
            yield return new object[] { new ArrayList(new int[] { 1, 12, 33, 24 }), new ArrayList(new int[] { 33,24,12,1 }) };

        }
    }

    public class DeleteFirstByValueTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            int value = 3;
            int expected_result = 2;
            ArrayList list = new ArrayList(new int[] { 1, 2, 3, 4, 3, 5 });
            ArrayList expected_list = new ArrayList(new int[] { 1, 2, 4, 3, 5 });
            yield return new object[] { value, expected_result, list, expected_list };
            yield return new object[] { 1, -1, new ArrayList(3), new ArrayList(3) };
            yield return new object[] { 1, 0, new ArrayList(1), new ArrayList() };
            yield return new object[] { 3, 0, new ArrayList(new int[] { 3, 3, 3, 3 }), new ArrayList(new int[] { 3, 3, 3 }) };
            yield return new object[] { 2, 1, new ArrayList(new int[] { 1, 2 }), new ArrayList(1) };
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

    public class AddListTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { new ArrayList(3), new ArrayList(3), new ArrayList(new int[] {3,3}) };
            yield return new object[] { new ArrayList(), new ArrayList(3), new ArrayList(new int[] {3}) };
            yield return new object[] { new ArrayList(), new ArrayList(), new ArrayList() };
            yield return new object[] { new ArrayList(3), new ArrayList(), new ArrayList(new int[] {3}) };
            yield return new object[] { new ArrayList(new int[] { 3, 3 }), new ArrayList(3), new ArrayList(new int[] {3,3,3}) };
            yield return new object[] { new ArrayList(3), new ArrayList(new int[] { 3, 3 }), new ArrayList(new int[] {3,3,3}) };
            yield return new object[] { new ArrayList(new int[] { 3, 3 }), new ArrayList(new int[] { 3, 3 }), new ArrayList(new int[] {3,3,3,3}) };
            yield return new object[] { new ArrayList(new int[] { 3, 3 }), new ArrayList(new int[] { 8, 8 }), new ArrayList(new int[] {3,3,8,8}) };
            yield return new object[] { new ArrayList(new int[] { 0, 2 }), new ArrayList(new int[] { 5, 3 }), new ArrayList(new int[] {0,2,5,3}) };

        }
    }

    public class AddListByIndexTestSource : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            yield return new object[] { 0, new ArrayList(3), new ArrayList(3), new ArrayList(new int[] { 3, 3 }) };
            yield return new object[] { 0, new ArrayList(), new ArrayList(3), new ArrayList(new int[] { 3 }) };
            yield return new object[] { 0, new ArrayList(), new ArrayList(), new ArrayList() };
            yield return new object[] { 1, new ArrayList(3), new ArrayList(), new ArrayList(new int[] { 3 }) };
            yield return new object[] { 2, new ArrayList(new int[] { 3, 3 }), new ArrayList(3), new ArrayList(new int[] { 3, 3, 3 }) };
            yield return new object[] { 1, new ArrayList(3), new ArrayList(new int[] { 3, 3 }), new ArrayList(new int[] { 3, 3, 3 }) };
            yield return new object[] { 2, new ArrayList(new int[] { 3, 3 }), new ArrayList(new int[] { 3, 3 }), new ArrayList(new int[] { 3, 3, 3, 3 }) };
            yield return new object[] { 1, new ArrayList(new int[] { 3, 3 }), new ArrayList(new int[] { 8, 8 }), new ArrayList(new int[] { 3, 8, 8, 3 }) };
            yield return new object[] { 2, new ArrayList(new int[] { 0, 2, 7, 5 }), new ArrayList(new int[] { 5, 3 }), new ArrayList(new int[] { 0, 2, 5, 3,7,5 }) };
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
