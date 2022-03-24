using NUnit.Framework;
using System.Collections;
using System;

namespace Lists.Tests
{
    public class ArrayListTests
    {

        




        [TestCaseSource(typeof(AddLastTestSource))]
        public void AddLastTest(int element, ArrayList list, ArrayList expected_list)
        {
            list.AddLast(element);
            Assert.AreEqual(expected_list, list);
        }
        
        [TestCaseSource(typeof(AddFirstTestSource))]
        public void AddFirstTest(int element, ArrayList list, ArrayList expected_list)
        {
            list.AddFirst(element);
            Assert.AreEqual(expected_list, list);
        }

        [TestCaseSource(typeof(AddByIndexTestSource))]
        public void AddByIndexTest(int element,int index, ArrayList list, ArrayList expected_list)
        {
            list.AddByIndex(element, index);
            Assert.AreEqual(expected_list, list);
        }

        [TestCaseSource(typeof(AddByIndexNegativeTestSource))]
        public void AddByIndexTest_WhanIndexIsWrong_ShouldThrowArgumetException(int element, int index, ArrayList list)
        {
            Assert.Throws<ArgumentException>(() => list.AddByIndex(element, index));

        }










        [TestCaseSource(typeof(DeleteAllByValueTestSource))]
        public void DeleteAllByValueTest(int value, int result_expected, ArrayList list, ArrayList expected_list)
        {
            int result_actual = list.DeleteAllByValue(value);
            list.DeleteAllByValue(value);
            Assert.AreEqual(result_expected, result_actual);
            Assert.AreEqual(expected_list, list);
        }





    }
}