using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UA.Algorithm;

public class UpperBoundTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void TestUpperBoundSorted()
    {
        var list = new List<int>() {1, 2, 3};
        var index = list.UpperBound(0, Comparer<int>.Default);
        Assert.AreEqual(0, index);
    }

    [Test]
    public void TestUpperBound()
    {
        var list = new List<int>() {1, 1, 2, 2, 4, 5};
        var index = list.UpperBound(3, Comparer<int>.Default);
        Assert.AreEqual(4, index);
    }
}
