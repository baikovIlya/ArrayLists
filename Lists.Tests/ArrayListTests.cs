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

        [TestCaseSource(typeof(DeleteLastTestSource))]
        public void DeleteLastTest(ArrayList list, ArrayList expected_list)
        {
            list.DeleteLast();
            Assert.AreEqual(expected_list, list);
        }

        [TestCaseSource(typeof(DeleteLastNegativeTestSource))]
        public void DeleteLastTest_WhanListIsEmpty_ShouldThrowException(ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteLast());

        }

        [TestCaseSource(typeof(DeleteByIndexTestSource))]
        public void DeleteByIndexTest(int index, ArrayList list, ArrayList expected_list)
        {
            list.DeleteByIndex(index);
            Assert.AreEqual(expected_list, list);
        }

        [TestCaseSource(typeof(WhenIndexIsWrongTestSource))]
        public void DeleteByIndexTest_WhanIndexIsWrong_ShouldThrowArgumentException(int index, ArrayList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteByIndex(index));
        }

        [TestCaseSource(typeof(WhenListIsEmptyTestSource))]
        public void DeleteByIndexTest_WhanListIsEmpty_ShouldThrowException(int index, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteByIndex(index));
        }

        [TestCaseSource(typeof(DeleteElementsAtTneEndTestSource))]
        public void DeleteElementsAtTneEndTest(int count, ArrayList list, ArrayList expected_list)
        {
            list.DeleteElementsAtTneEnd(count);
            Assert.AreEqual(expected_list, list);
        }

        [TestCaseSource(typeof(WhenCountIsWrongTestSource))]
        public void DeleteElementsAtTheEndTest_WhanCountIsWrong_ShouldThrowArgumentException(int count, ArrayList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsAtTneEnd(count));
        }

        [TestCaseSource(typeof(WhenListIsEmptyTestSource))]
        public void DeleteElementsAtTheEndTest_WhanListIsEmpty_ShouldThrowException(int count, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteElementsAtTneEnd(count));
        }

        [TestCaseSource(typeof(DeleteElementsFromTheBeginningTestSource))]
        public void DeleteElementsFromTheBeginningTest(int count, ArrayList list, ArrayList expected_list)
        {
            list.DeleteElementsFromTheBeginning(count);
            Assert.AreEqual(expected_list, list);
        }

        [TestCaseSource(typeof(WhenCountIsWrongTestSource))]
        public void DeleteElementsFromTheBeginningTest_WhanCountIsWrong_ShouldThrowArgumentException(int count, ArrayList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsFromTheBeginning(count));
        }

        [TestCaseSource(typeof(WhenListIsEmptyTestSource))]
        public void DeleteElementsFromTheBeginningTest_WhanListIsEmpty_ShouldThrowException(int count, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteElementsFromTheBeginning(count));
        }

        [TestCaseSource(typeof(DeleteElementsByIndexTestSource))]
        public void DeleteElementsByIndexTest(int index, int count, ArrayList list, ArrayList expected_list)
        {
            list.DeleteElementsByIndex(index, count);
            Assert.AreEqual(expected_list, list);
        }

        [TestCaseSource(typeof(DeleteElementsByIndexWhenCountIsWrongTestSource))]
        public void DeleteElementsByIndexTest_WhanCountIsWrong_ShouldThrowArgumentException(int index, int count, ArrayList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsByIndex(index, count));
        }

        [TestCaseSource(typeof(DeleteElementsByIndexWhenListIsEmptyTestSource))]
        public void DeleteElementsByIndexTest_WhanListIsEmpty_ShouldThrowException(int index, int count, ArrayList list)
        {
            Assert.Throws<Exception>(() => list.DeleteElementsByIndex(index, count));
        }

        [TestCaseSource(typeof(DeleteElementsByIndexWhenIndexIsWrongTestSource))]
        public void DeleteElementsByIndexTest_WhanIndexIsWrong_ShouldThrowArgumentException(int index,int count, ArrayList list)
        {
            Assert.Throws<ArgumentException>(() => list.DeleteElementsByIndex(index,count));
        }












        //[TestCaseSource(typeof(TestSource))]
        //public void Test(int element, int index, ArrayList list, ArrayList expected_list)
        //{
        //    list.AddByIndex(element, index);
        //    Assert.AreEqual(expected_list, list);
        //}









        [TestCaseSource(typeof(DeleteFirstByValueTestSource))]
        public void DeleteFirstByValueTest(int value, int result_expected, ArrayList list, ArrayList expected_list)
        {
            int result_actual = list.DeleteFirstByValue(value);
            Assert.AreEqual(result_expected, result_actual);
            Assert.AreEqual(expected_list, list);
        }


        [TestCaseSource(typeof(DeleteAllByValueTestSource))]
        public void DeleteAllByValueTest(int value, int result_expected, ArrayList list, ArrayList expected_list)
        {
            int result_actual = list.DeleteAllByValue(value);
            Assert.AreEqual(result_expected, result_actual);
            Assert.AreEqual(expected_list, list);
        }





    }
}