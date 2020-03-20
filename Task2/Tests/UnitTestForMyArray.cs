using System;
using Xunit;
using Array;
using System.Collections.Generic;

namespace Tests
{
    public class UnitTestForMyArray
    {
        [Fact]
        public void Constructor_FirstIndexBiggerThanLast_IndexOutOfRangeException()
        {
            MyArray<int> testArray;
            
            Assert.Throws<IndexOutOfRangeException>(() => { testArray = new MyArray<int>(11, 5); });
        }

        [Fact]
        public void Constructor_FirstIndexSmallerThanLast_CreateNewArray()
        {
            MyArray<int> testArray = new MyArray<int>(4, 9);

            Assert.Equal(4, testArray.startIndex);
        }

        [Fact]
        public void Add_ValueIs10_ReturnInputValue()
        {
            MyArray<int> testArray = new MyArray<int>(5, 8);

            testArray.Add(10);

            Assert.Equal(10, testArray[5]);
        }

        [Fact]
        public void Indexer_AddValueAdnChangeValueUsingCorrectIndex_ChangeValueInThisElement()
        {
            MyArray<int> testArray = new MyArray<int>(5, 8);

            testArray.Add(10);
            testArray[5] = 4;

            Assert.Equal(4, testArray[5]);
        }

        [Fact]
        public void Indexer_AddOneElementAndChangeValueInIndexWithoutAddingElement_ArgumentNullException()
        {
            MyArray<int> testArray = new MyArray<int>(-1, 5);
            testArray.Add(-355);

            Assert.Throws<ArgumentNullException>(() => { testArray[3] = 6; });
        }


        [Fact]
        public void Remove_ElementValueIs9_ReturnTrue()
        {
            MyArray<int> testArray = new MyArray<int>(5, 8);

            testArray.Add(10);
            testArray.Add(5);
            testArray.Add(9);
            testArray.Add(4);

            var result = testArray.Remove(9);

            Assert.True(result);
        }

        [Fact]
        public void Remove_NotCorrectData_ReturnFalse()
        {
            MyArray<int> testArray = new MyArray<int>(5, 8);

            testArray.Add(10);
            testArray.Add(5);
            testArray.Add(9);
            testArray.Add(4);

            var result = testArray.Remove(121);

            Assert.False(result);
        }

        [Fact]
        public void Clear_AddTwoElementAndClear_EmptyArray()
        {
            MyArray<int> testArray = new MyArray<int>(5, 8);

            testArray.Add(10);
            testArray.Add(5);

            testArray.Clear();

            Assert.Equal(0, testArray.count);
        }

        [Fact]
        public void Contains_AddFourElementsAndSearchOneOfThem_ReturnTrue()
        {
            MyArray<int> testArray = new MyArray<int>(5, 8);

            testArray.Add(10);
            testArray.Add(65);
            testArray.Add(9);
            testArray.Add(243);

            bool result = testArray.Contains(243);

            Assert.True(result);
        }

        [Fact]
        public void Contains_AddFourElementsAndSearchAnotherValue_ReturnFalse()
        {
            MyArray<int> testArray = new MyArray<int>(5, 8);

            testArray.Add(10);
            testArray.Add(65);
            testArray.Add(9);
            testArray.Add(243);

            bool result = testArray.Contains(11);

            Assert.False(result);
        }





    }
}
