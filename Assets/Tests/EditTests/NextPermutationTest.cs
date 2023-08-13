using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UA.Algorithm;
using System.Linq;

public class NextPermutationTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void TestNextPermutation()
    {
        List<int> per = new List<int>() {1, 2, 3};
        per = per.NextPermutation().ToList();
        Assert.AreSame(new List<int>() {1, 3, 2}, per);
    }
}