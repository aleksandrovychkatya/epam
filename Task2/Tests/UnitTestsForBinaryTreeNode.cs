using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using BinaryTreeProject;

namespace Tests
{
    public class UnitTestsForBinaryTreeNode
    {
        [Fact]
        public void Constructor_CorrectData_CreateNewBinaryTreeNode()
        {
            BinaryTreeNode<string> node = new BinaryTreeNode<string>("apple");
            Assert.Equal("apple", node.Value);
        }

        [Fact]
        public void Constructor_NullableValue_ArgumentNullException()
        {
            Assert.Throws<ArgumentNullException>(() => { BinaryTreeNode<string> node = new BinaryTreeNode<string>(null); });
        }


    }
}
