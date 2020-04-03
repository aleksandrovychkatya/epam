using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BinaryTreeProject;

namespace Tests
{
    public class UnitTestsForBinaryTree
    {
        [Fact]
        public void Add_AddThreeElements_CountEqualNumberOfAddingElements()
        {
            BinaryTree<int> testTree = new BinaryTree<int>();
            testTree.Add(6);
            testTree.Add(37);
            testTree.Add(9547);

            Assert.Equal(3, testTree.Count);
        }

        [Fact]
        public void Contains_AddElementAndSearchThisElement_ReturnTrue()
        {
            BinaryTree<int> testTree = new BinaryTree<int>();
            testTree.Add(6);

            Assert.True(testTree.Contains(6));
        }

        [Fact]
        public void Contains_AddElementAndSearchAnotherElement_ReturnFalse()
        {
            BinaryTree<int> testTree = new BinaryTree<int>();
            testTree.Add(6);

            Assert.False(testTree.Contains(728));
        }

        [Fact]
        public void Clear_AddFourElementsAndClearTree_CountIs0()
        {
            BinaryTree<int> testTree = new BinaryTree<int>();
            testTree.Add(6);
            testTree.Add(8);
            testTree.Add(11);
            testTree.Add(26);

            testTree.Clear();

            Assert.Equal(0, testTree.Count);

        }

        [Fact]
        public void Remove_AddFourElementsAndRemoveOneOfThem_ReturnTrue()
        {
            BinaryTree<int> testTree = new BinaryTree<int>();
            testTree.Add(6);
            testTree.Add(8);
            testTree.Add(11);
            testTree.Add(26);


            Assert.True(testTree.Remove(11));
        }

        [Fact]
        public void Remove_AddFourElementsAndRemoveAnother_ReturnFalse()
        {
            BinaryTree<int> testTree = new BinaryTree<int>();
            testTree.Add(6);
            testTree.Add(8);
            testTree.Add(11);
            testTree.Add(26);


            Assert.False(testTree.Remove(111));
        }

        [Fact]

        public void Remove_Add10ElementsAndRemove4FromThese_CountIs6()
        {
            BinaryTree<int> testTree = new BinaryTree<int>();
            testTree.Add(6);
            testTree.Add(34);
            testTree.Add(24);
            testTree.Add(663);
            testTree.Add(766);
            testTree.Add(35);
            testTree.Add(68);
            testTree.Add(97);
            testTree.Add(-24);
            testTree.Add(-17);

            testTree.Remove(34);
            testTree.Remove(68);
            testTree.Remove(35);
            testTree.Remove(97);

            Assert.Equal(6, testTree.Count);
        }

        [Fact]

        public void GetEnumerator_AddThreeElementAnd()
        {
            BinaryTree<int> testTree = new BinaryTree<int>();
            testTree.Add(6);
            testTree.Add(34);
            testTree.Add(24);

            List<int> testList = new List<int>();

            foreach(var x in testTree)
            {
                testList.Add(x);
            }

            List<int> list = new List<int>();
            list.Add(6);
            list.Add(24);
            list.Add(34);


            Assert.Equal(testList, list);
        }
    }
}
