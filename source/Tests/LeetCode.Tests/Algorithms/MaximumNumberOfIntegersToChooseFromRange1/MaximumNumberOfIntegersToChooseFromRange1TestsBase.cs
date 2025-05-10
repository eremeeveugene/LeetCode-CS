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

using LeetCode.Algorithms.MaximumNumberOfIntegersToChooseFromRange1;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumNumberOfIntegersToChooseFromRange1;

public abstract class MaximumNumberOfIntegersToChooseFromRange1TestsBase<T>
    where T : IMaximumNumberOfIntegersToChooseFromRange1, new()
{
    [TestMethod]
    [DataRow("[1,6,5]", 5, 6, 2)]
    [DataRow("[1,2,3,4,5,6,7]", 8, 1, 0)]
    [DataRow("[11]", 7, 50, 7)]
    public void MaxCount_WithBannedArrayNAndMaxSum_ReturnsMaximumCount(string bannedJson, int n, int maxSum,
        int expectedResult)
    {
        // Arrange
        var banned = JsonHelper<int>.DeserializeToArray(bannedJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaxCount(banned, n, maxSum);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}