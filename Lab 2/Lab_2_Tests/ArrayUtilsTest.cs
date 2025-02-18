using System;
using NUnit.Framework;
using STLab01;
using NUnit.Framework.Legacy;
namespace STLab01Test

{
    [TestFixture]
    public class ShellSortTests
    {
        [Test]
        public void Sort_EmptyArray_DoesNotChangeArray()
        {
            int[] arr = { };
            ShellSort.Sort(arr);
            ClassicAssert.AreEqual(0, arr.Length);
        }

        [Test]
        public void Sort_SingleElementArray_DoesNotChangeArray()
        {
            int[] arr = { 5 };
            ShellSort.Sort(arr);
            ClassicAssert.AreEqual(5, arr[0]);
        }

        [Test]
        public void Sort_AlreadySortedArray_StaysSorted()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            ShellSort.Sort(arr);
            ClassicAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, arr);
        }

        [Test]
        public void Sort_ReverseSortedArray_BecomesSorted()
        {
            int[] arr = { 5, 4, 3, 2, 1 };
            ShellSort.Sort(arr);
            ClassicAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, arr);
        }

        [Test]
        public void Sort_UnsortedArray_BecomesSorted()
        {
            int[] arr = { 5, 1, 4, 2, 8 };
            ShellSort.Sort(arr);
            ClassicAssert.AreEqual(new int[] { 1, 2, 4, 5, 8 }, arr);
        }

        [Test]
        public void Sort_ArrayWithDuplicateValues_BecomesSorted()
        {
            int[] arr = { 5, 1, 4, 2, 5, 1 };
            ShellSort.Sort(arr);
            ClassicAssert.AreEqual(new int[] { 1, 1, 2, 4, 5, 5 }, arr);
        }
    }
}