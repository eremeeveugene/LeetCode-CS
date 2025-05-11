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

using LeetCode.Algorithms.RangeSumQueryImmutable;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.RangeSumQueryImmutable;

public abstract class RangeSumQueryImmutableTestsBase<T> where T : IRangeSumQueryImmutableFactory, new()
{
    [TestMethod]
    [DataRow("[-2,0,3,-5,2,-1]", "[0,2,0]", "[2,5,5]", "[1,-1,-3]")]
    public void SumRange_WithGivenArrayAndRangeQueries_ReturnsSumForEachQuery(string numsJson, string leftsJson,
        string rightsJson, string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var lefts = JsonHelper<int[]>.Parse(leftsJson);
        var rights = JsonHelper<int[]>.Parse(rightsJson);
        var expectedResult = JsonHelper<int[]>.Parse(expectedResultJson);

        var rangeSumQueryImmutableFactory = new T();
        var rangeSumQueryImmutable = rangeSumQueryImmutableFactory.Create(nums);

        // Act
        var actualResult = new int[expectedResult.Length];

        for (var i = 0; i < actualResult.Length; i++)
        {
            actualResult[i] = rangeSumQueryImmutable.SumRange(lefts[i], rights[i]);
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }
}