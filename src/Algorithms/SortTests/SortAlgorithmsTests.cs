using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort.Tests
{
    [TestClass()]
    public class SortAlgorithmsTests
    {
        [TestMethod()]
        public void MergeSortTest()
        {
            SortAlgorithms sort = new SortAlgorithms();
            int[] testdata = new int[] { 8, 3, 5, 9, 23, 5 };
            int [] rst = sort.MergeSort(testdata);
            Assert.AreEqual(rst[0], 3);
            Assert.AreEqual(rst[1], 5);
            Assert.AreEqual(rst[2], 5);
            Assert.AreEqual(rst[3], 8);
            Assert.AreEqual(rst[4], 9);
            Assert.AreEqual(rst[5], 23);
        }
    }
}