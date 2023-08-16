using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UA.Algorithm;
using System.Linq;

public class NextPermutationTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void TestNextPermutation1()
    {
        List<int> per = new List<int>() {1, 2, 3};
        IEnumerable<int> ints;
        if(per.NextPermutation(out ints))
        {
            Assert.AreEqual(new List<int>() {1, 3, 2}, ints.ToList());
        }
        else
        {
            Assert.Fail();
        }
    }

    // A Test behaves as an ordinary method
    [Test]
    public void TestNextPermutation2()
    {
        List<int> per = new List<int>() {1, 3, 2};
        IEnumerable<int> ints;
        if(per.NextPermutation(out ints))
        {
            Assert.AreEqual(new List<int>() {2, 1, 3}, ints.ToList());
        }
        else
        {
            Assert.Fail();
        }
    }

    // A Test behaves as an ordinary method
    [Test]
    public void TestNextPermutation3()
    {
        List<int> per = new List<int>() {2, 1, 3};
        IEnumerable<int> ints;
        if(per.NextPermutation(out ints))
        {
            Assert.AreEqual(new List<int>() {2, 3, 1}, ints.ToList());
        }
        else
        {
            Assert.Fail();
        }
    }

    // A Test behaves as an ordinary method
    [Test]
    public void TestNextPermutation4()
    {
        List<int> per = new List<int>() {2, 3, 1};
        IEnumerable<int> ints;
        if(per.NextPermutation(out ints))
        {
            Assert.AreEqual(new List<int>() {3, 1, 2}, ints.ToList());
        }
        else
        {
            Assert.Fail();
        }
    }

    // A Test behaves as an ordinary method
    [Test]
    public void TestNextPermutation5()
    {
        List<int> per = new List<int>() {3, 1, 2};
        IEnumerable<int> ints;
        if(per.NextPermutation(out ints))
        {
            Assert.AreEqual(new List<int>() {3, 2, 1}, ints.ToList());
        }
        else
        {
            Assert.Fail();
        }
    }

    // A Test behaves as an ordinary method
    [Test]
    public void TestNextPermutation6()
    {
        List<int> per = new List<int>() {3, 2, 1};
        IEnumerable<int> ints;
        if(per.NextPermutation(out ints))
        {
            Assert.Fail();
        }
    }

    [Test]
    public void TestNextPermutation7()
    {
        List<int> per = new List<int>() {1, 2, 3, 4};
        IEnumerable<int> ints;
        if(per.NextPermutation(out ints))
        {
            Assert.AreEqual(new List<int>() {1, 2, 4, 3}, ints.ToList());
        }
        else
        {
            Assert.Fail();
        }
    }
}