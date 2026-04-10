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

using LeetCode.Algorithms.ToggleLightBulbs;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.ToggleLightBulbs;

public abstract class ToggleLightBulbsTestsBase<T> where T : IToggleLightBulbs, new()
{
    [TestMethod]
    [DataRow("[100,100]", "[]")]
    [DataRow("[10,30,20,10]", "[20,30]")]
    public void ToggleLightBulbs_WithGivenBulbSequence_ReturnsSwitchedOnBulbsSortedInAscendingOrder(string bulbsJson,
        string expectedResultJson)
    {
        // Arrange
        var bulbs = JsonHelper.Parse<IList<int>>(bulbsJson);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.ToggleLightBulbs(bulbs).ToArray();

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}