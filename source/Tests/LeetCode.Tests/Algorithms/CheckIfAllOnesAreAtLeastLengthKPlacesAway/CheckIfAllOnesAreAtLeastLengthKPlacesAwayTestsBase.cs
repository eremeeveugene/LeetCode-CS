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

using LeetCode.Algorithms.CheckIfAllOnesAreAtLeastLengthKPlacesAway;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CheckIfAllOnesAreAtLeastLengthKPlacesAway;

public abstract class CheckIfAllOnesAreAtLeastLengthKPlacesAwayTestsBase<T>
    where T : ICheckIfAllOnesAreAtLeastLengthKPlacesAway, new()
{
    [TestMethod]
    [DataRow("[1,0,0,0,1,0,0,1]", 2, true)]
    [DataRow("[1,0,0,1,0,1]", 2, false)]
    public void KLengthApart_WithNumsArrayAndKDistance_ReturnsTrueIfOnesAreAtLeastKApart(string numsJson, int k,
        bool expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.KLengthApart(nums, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}