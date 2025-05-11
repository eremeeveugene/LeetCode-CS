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

using LeetCode.Algorithms.MaximumCountOfPositiveIntegerAndNegativeInteger;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.MaximumCountOfPositiveIntegerAndNegativeInteger;

public abstract class MaximumCountOfPositiveIntegerAndNegativeIntegerTestsBase<T>
    where T : IMaximumCountOfPositiveIntegerAndNegativeInteger, new()
{
    [TestMethod]
    [DataRow("[-2,-1,-1,1,2,3]", 3)]
    [DataRow("[-3,-2,-1,0,0,1,2]", 3)]
    [DataRow("[5,20,66,1314]", 4)]
    public void MaximumCount_GivenIntegerArray_ReturnsCountOfMaxPositiveOrNegativeNumbers(string numsJson,
        int expectedResult)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);

        var solution = new T();

        // Act
        var actualResult = solution.MaximumCount(nums);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}