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

using LeetCode.Algorithms.MinimumAbsoluteDifference;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Extensions;

namespace LeetCode.Tests.Algorithms.MinimumAbsoluteDifference;

public abstract class MinimumAbsoluteDifferenceTestsBase<T> where T : IMinimumAbsoluteDifference, new()
{
    [TestMethod]
    [DataRow("[4,2,1,3]", "[[1,2],[2,3],[3,4]]")]
    [DataRow("[1,3,6,10,15]", "[[1,3]]")]
    [DataRow("[3,8,-10,23,19,-4,-14,27]", "[[-14,-10],[19,23],[23,27]]")]
    public void MinimumAbsDifference_WithDistinctIntegersArray_ReturnsAllPairsWithMinimumAbsoluteDifference(
        string arrJson, string expectedResultJson)
    {
        // Arrange
        var arr = JsonHelper<int[]>.Parse(arrJson);
        var expectedResult = JsonHelper<IList<IList<int>>>.Parse(expectedResultJson);

        var solution = new T();

        // Act
        var actualResult = solution.MinimumAbsDifference(arr);

        // Assert
        NestedCollectionAssert.AreEqual(expectedResult, actualResult);
    }
}