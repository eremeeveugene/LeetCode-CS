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

using LeetCode.Algorithms.RangeSumQueryImmutable;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.RangeSumQueryImmutable;

public abstract class RangeSumQueryImmutableTestsBase
{
    private const string SumRange = "sumRange";

    [TestMethod]
    [DataRow("[-2,0,3,-5,2,-1]", "[\"sumRange\", \"sumRange\", \"sumRange\"]", "[[0, 2], [2, 5], [0, 5]]", "[1,-1,-3]")]
    public void RangeSumQueryImmutable_WithGivenArrayAndRangeQueries_ProcessesOperationsAccordingToSpecification(
        string numsJson, string methodsJson, string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var methods = JsonHelper<string[]>.Parse(methodsJson);
        var arguments = JsonHelper<object[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper<object[]>.Parse(expectedResultJson);

        var solution = GetSolution(nums);

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case SumRange:
                    actualResult.Add(solution.SumRange((int)arguments[i][0], (int)arguments[i][1]));
                    break;
                default:
                    throw new UnexpectedMethodException(methods[i]);
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IRangeSumQueryImmutable GetSolution(int[] nums);
}