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

using LeetCode.Algorithms.HowManyNumbersAreSmallerThanTheCurrentNumber;

namespace LeetCode.Tests.Algorithms.HowManyNumbersAreSmallerThanTheCurrentNumber;

public abstract class HowManyNumbersAreSmallerThanTheCurrentNumberTestsBase
{
    [TestMethod]
    [DataRow(new[] { 8, 1, 2, 2, 3 }, new[] { 4, 0, 1, 1, 3 })]
    [DataRow(new[] { 6, 5, 4, 8 }, new[] { 2, 1, 0, 3 })]
    [DataRow(new[] { 7, 7, 7, 7 }, new[] { 0, 0, 0, 0 })]
    public void SmallerNumbersThanCurrent_WithIntArray_ReturnsCountsArray(int[] nums, int[] expectedResult)
    {
        // Arrange
        var solution = GetSolution();

        // Act
        var actualResult = solution.SmallerNumbersThanCurrent(nums);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IHowManyNumbersAreSmallerThanTheCurrentNumber GetSolution();
}