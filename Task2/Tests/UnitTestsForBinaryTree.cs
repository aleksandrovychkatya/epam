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
    }
}
