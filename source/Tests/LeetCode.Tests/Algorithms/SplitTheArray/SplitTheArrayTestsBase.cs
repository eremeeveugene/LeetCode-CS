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

using LeetCode.Algorithms.SplitTheArray;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SplitTheArray;

public abstract class SplitTheArrayTestsBase<T> where T : ISplitTheArray, new()
{
    [TestMethod]
    [DataRow("[1,1,2,2,3,4]", true)]
    [DataRow("[1,1,1,1]", false)]
    public void IsPossibleToSplit_WithNumsArray_ReturnsTrueIfSplitIsValid(string numsJson, bool expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.IsPossibleToSplit(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}