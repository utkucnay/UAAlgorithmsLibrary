using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UA.Algorithm;
using System.Linq;

public class MergeTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void TestMergeList()
    {
        List<int> per = new List<int>() {1, 2, 3};
        List<int> per2 = new List<int>() {3, 4, 5};
        var result = per.Merge(per2, Comparer<int>.Default).ToList();

        var expected = new List<int>() { 1, 2, 3, 3, 4, 5 };
        Assert.AreEqual(expected, result);
    }
}