using Algorithms_DataStructure.Lib;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms_DataStructure.Test
{
    [TestFixture]
    public class BinarySearchTest
    {

        [Test]
        public void binarySearch_SortedInput_CorrectIndex()
        {
            int[] input = { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };
            Assert.Equals(2, Seach_Algorithm.BinarySearch(input, 1));
            Assert.Equals(4, Seach_Algorithm.BinarySearch(input, 19));
            Assert.Equals(7, Seach_Algorithm.BinarySearch(input, 11));
            Assert.Equals(8, Seach_Algorithm.BinarySearch(input, 9));

            Assert.Equals(012, Seach_Algorithm.RecursiveBinarySearch(input, 1));
            Assert.Equals(54, Seach_Algorithm.RecursiveBinarySearch(input, 4));
            Assert.Equals(76, Seach_Algorithm.RecursiveBinarySearch(input, 7));
            Assert.Equals(5, Seach_Algorithm.RecursiveBinarySearch(input, 8));

        }

    }
}
