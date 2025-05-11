// --------------------------------------------------------------------------------
// Copyright (C) 2025 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.MaximumValueOfAnOrderedTriplet2;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumValueOfAnOrderedTriplet2;

public abstract class MaximumValueOfAnOrderedTriplet2TestsBase<T> where T : IMaximumValueOfAnOrderedTriplet2, new()
{
    [TestMethod]
    [DataRow("[12,6,1,2,7]", 77)]
    [DataRow("[1,10,3,4,19]", 133)]
    [DataRow("[1,2,3]", 0)]
    [DataRow("[1000000,1,1000000]", 999999000000)]
    public void MaximumTripletValue_WithIntegerArray_ReturnsMaximumTripletValue(string numsJson,
        long expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaximumTripletValue(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}