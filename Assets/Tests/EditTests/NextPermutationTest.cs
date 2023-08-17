using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UA.Algorithm;
using System.Linq;

public class NextPermutationTest
{
    [Test]
    public void TestNextPermutation_NormalCase()
    {
        int[] array = { 1, 2, 3 };
        int[] nextPermutation = { 1, 3, 2 };

        IEnumerable<int> result;
        if(array.NextPermutation(out result))
        {
            Assert.AreEqual(result.ToArray(), nextPermutation);
        }
    }

    [Test]
    public void TestNextPermutation_ReverseOrder()
    {
        int[] array = { 3, 2, 1 };
        int[] nextPermutation = { 1, 2, 3 };

        IEnumerable<int> result;
        if(array.NextPermutation(out result))
        {
            Assert.AreEqual(result.ToArray(), nextPermutation);
        }
    }

    [Test]
    public void TestNextPermutation_SameValues()
    {
        int[] array = { 1, 1, 1 };
        int[] nextPermutation = { 1, 1, 1 };

        IEnumerable<int> result;
        if(array.NextPermutation(out result))
        {
            Assert.AreEqual(result.ToArray(), nextPermutation);
        }
    }

    [Test]
    public void TestNextPermutation_EmptyArray()
    {
        int[] array = { };
        int[] nextPermutation = { };

        IEnumerable<int> result;
        if(array.NextPermutation(out result))
        {
            Assert.AreEqual(result.ToArray(), nextPermutation);
        }
    }

    [Test]
    public void TestNextPermutation_SingleValue()
    {
        int[] array = { 42 };
        int[] nextPermutation = { 42 };

        IEnumerable<int> result;
        if(array.NextPermutation(out result))
        {
            Assert.AreEqual(result.ToArray(), nextPermutation);
        }
        else
        {
            Assert.AreEqual(result.ToArray(), nextPermutation);
        }
    }

    [Test]
    public void TestNextPermutation_LargeArray()
    {
        int[] array = Enumerable.Range(1, 10).ToArray();
        int[] nextPermutation = new int[]{1,2,3,4,5,6,7,8,10,9};

        IEnumerable<int> result;
        if(array.NextPermutation(out result))
        {
            Assert.AreEqual(result.ToArray(), nextPermutation);
        }
    }

    [Test]
    public void TestNextPermutation_NegativeValues()
    {
        int[] array = { -3, -1, -2 };
        int[] nextPermutation = { -2, -3, -1 };

        IEnumerable<int> result;
        if(array.NextPermutation(out result))
        {
            Assert.AreEqual(result.ToArray(), nextPermutation);
        }
    }

    [Test]
    public void TestNextPermutation_Characters()
    {
        char[] array = { 'a', 'b', 'c' };
        char[] nextPermutation = { 'a', 'c', 'b' };

        IEnumerable<char> result;
        if(array.NextPermutation(out result))
        {
            Assert.AreEqual(result.ToArray(), nextPermutation);
        }
    }
}