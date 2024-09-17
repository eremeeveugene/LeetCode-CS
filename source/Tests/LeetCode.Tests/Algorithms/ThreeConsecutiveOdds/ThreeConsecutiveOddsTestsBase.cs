// --------------------------------------------------------------------------------
// Copyright (C) 2024 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
// All Rights Reserved.
// --------------------------------------------------------------------------------
// This software is the confidential and proprietary information of Eugene Eremeev
// (also known as Yevhenii Yeriemeieiv) ("Confidential Information"). You shall not
// disclose such Confidential Information and shall use it only in accordance with
// the terms of the license agreement you entered into with Eugene Eremeev (also
// known as Yevhenii Yeriemeieiv).
// --------------------------------------------------------------------------------

using LeetCode.Algorithms.ThreeConsecutiveOdds;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ThreeConsecutiveOdds;

public abstract class ThreeConsecutiveOddsTestsBase<T> where T : IThreeConsecutiveOdds, new()
{
    [TestMethod]
    [DataRow("[2, 6, 4, 1]", false)]
    [DataRow("[1, 2, 34, 3, 4, 5, 7, 23, 12]", true)]
    public void ThreeConsecutiveOdds_WithVariousArrays_ReturnsExpectedResult(string arrJsonArray, bool expectedResult)
    {
        // Arrange
        var arr = JsonHelper<int>.DeserializeToArray(arrJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.ThreeConsecutiveOdds(arr);

        Assert.AreEqual(expectedResult, actualResult);
    }
}