// --------------------------------------------------------------------------------
// Copyright (C) 2026 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.FourDivisors;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FourDivisors;

public abstract class FourDivisorsTestsBase<T> where T : IFourDivisors, new()
{
    [TestMethod]
    [DataRow("[21,4,7]", 32)]
    [DataRow("[21,21]", 64)]
    [DataRow("[1,2,3,4,5]", 0)]
    public void SumFourDivisors_WithInputNumsArray_ReturnsSumOfNumbersThatHaveFourDivisors(string numsJson,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.SumFourDivisors(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}