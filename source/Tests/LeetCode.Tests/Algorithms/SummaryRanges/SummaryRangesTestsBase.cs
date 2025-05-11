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

using LeetCode.Algorithms.SummaryRanges;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SummaryRanges;

public abstract class SummaryRangesTestsBase<T> where T : ISummaryRanges, new()
{
    [TestMethod]
    [DataRow("[0,1,2,4,5,7]", "[\"0->2\",\"4->5\",\"7\"]")]
    [DataRow("[0,2,3,4,6,8,9]", "[\"0\",\"2->4\",\"6\",\"8->9\"]")]
    public void SummaryRanges_WithSequencesOfIntegers_ReturnsCorrectStringRanges(string numsJson,
        string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var expectedResult = JsonHelper<string[]>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.SummaryRanges(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult.ToArray(), actualResult.ToArray());
    }
}