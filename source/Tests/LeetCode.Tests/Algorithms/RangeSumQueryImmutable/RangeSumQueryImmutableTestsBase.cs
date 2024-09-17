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

using LeetCode.Algorithms.RangeSumQueryImmutable;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.RangeSumQueryImmutable;

public abstract class RangeSumQueryImmutableTestsBase<T> where T : IRangeSumQueryImmutableFactory, new()
{
    [TestMethod]
    [DataRow("[-2,0,3,-5,2,-1]", "[0,2,0]", "[2,5,5]", "[1,-1,-3]")]
    public void SumRangeQuery_WithGivenArrays_ReturnsCorrectSumRange(string numsJsonArray, string leftsJsonArray,
        string rightsJsonArray, string expectedResultJsonArray)
    {
        // Arrange
        var nums = JsonHelper<int>.DeserializeToArray(numsJsonArray);
        var lefts = JsonHelper<int>.DeserializeToArray(leftsJsonArray);
        var rights = JsonHelper<int>.DeserializeToArray(rightsJsonArray);
        var expectedResult = JsonHelper<int>.DeserializeToArray(expectedResultJsonArray);

        var rangeSumQueryImmutableFactory = new T();
        var rangeSumQueryImmutable = rangeSumQueryImmutableFactory.Create(nums);

        // Act
        var actualResult = new int[expectedResult.Length];

        for (var i = 0; i < actualResult.Length; i++)
        {
            actualResult[i] = rangeSumQueryImmutable.SumRange(lefts[i], rights[i]);
        }

        // Assert
        CollectionAssert.AreEqual(actualResult, expectedResult);
    }
}