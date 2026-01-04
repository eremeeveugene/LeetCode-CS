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

using LeetCode.Algorithms.KthLargestElementInStream;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.KthLargestElementInStream;

public abstract class KthLargestElementInStreamTestsBase
{
    private const string Add = "add";

    [TestMethod]
    [DataRow(3, "[4, 5, 8, 2]", "[\"add\", \"add\", \"add\", \"add\", \"add\"]", "[[3], [5], [10], [9], [4]]",
        "[4, 5, 5, 8, 8]")]
    [DataRow(4, "[7, 7, 7, 7, 8, 3]", "[\"add\", \"add\", \"add\", \"add\"]", "[[2], [10], [9], [9]]", "[7, 7, 7, 8]")]
    public void DesignCircularDeque_WithMixedOperations_ProcessesOperationsAccordingToSpecification(int k,
        string numsJson, string methodsJson, string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var nums = JsonHelper<int[]>.Parse(numsJson);
        var methods = JsonHelper<string[]>.Parse(methodsJson);
        var arguments = JsonHelper<object[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper<object[]>.Parse(expectedResultJson);

        var solution = GetSolution(k, nums);

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case Add:
                    actualResult.Add(solution.Add((int)arguments[i][0]));
                    break;
                default:
                    throw new UnexpectedMethodException(methods[i]);
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IKthLargestElementInStream GetSolution(int k, int[] nums);
}