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

using LeetCode.Algorithms.CanMakeArithmeticProgressionFromSequence;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.CanMakeArithmeticProgressionFromSequence;

public abstract class CanMakeArithmeticProgressionFromSequenceTestsBase<T>
    where T : ICanMakeArithmeticProgressionFromSequence, new()
{
    [TestMethod]
    [DataRow("[3,5,1]", true)]
    [DataRow("[1,2,4]", false)]
    public void CanMakeArithmeticProgression_GivenArray_ReturnsWhetherArithmeticProgressionIsPossible(
        string arrJsonArray, bool expectedResult)
    {
        // Arrange
        var solution = new T();

        var arr = JsonHelper<int>.DeserializeToArray(arrJsonArray);

        // Act
        var actualResult = solution.CanMakeArithmeticProgression(arr);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}