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

using LeetCode.Algorithms.FindTheStudentThatWillReplaceTheChalk;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.FindTheStudentThatWillReplaceTheChalk;

public abstract class FindTheStudentThatWillReplaceTheChalkTestsBase<T>
    where T : IFindTheStudentThatWillReplaceTheChalk, new()
{
    [TestMethod]
    [DataRow("[5,1,5]", 22, 0)]
    [DataRow("[3,4,1,2]", 25, 1)]
    [DataRow("[7,7,3,9,2]", 14, 2)]
    [DataRow("[1,2,3,4,5,6,7,8,9]", 45, 0)]
    [DataRow("[1]", 1000000000, 0)]
    [DataRow("[100000,1,100000,1,100000,1,100000,1,100000,1]", 500000, 8)]
    [DataRow("[1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1]", 10, 10)]
    [DataRow("[1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1]", 1000000000, 0)]
    public void ChalkReplacer_GivenChalkArrayAndKValue_ReturnsCorrectStudentIndex(string chalkJsonArray, int k,
        int expectedResult)
    {
        // Arrange
        var chalk = JsonHelper<int>.DeserializeToArray(chalkJsonArray);

        var solution = new T();

        // Act
        var actualResult = solution.ChalkReplacer(chalk, k);

        // Assert
        Assert.AreEqual(expectedResult, actualResult);
    }
}