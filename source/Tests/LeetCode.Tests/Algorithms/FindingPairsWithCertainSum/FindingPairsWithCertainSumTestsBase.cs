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

using LeetCode.Algorithms.FindingPairsWithCertainSum;
using LeetCode.Core.Helpers;
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.FindingPairsWithCertainSum;

public abstract class FindingPairsWithCertainSumTestsBase
{
    private const string Count = "count";
    private const string Add = "add";

    [TestMethod]
    [DataRow("[1, 1, 2, 2, 2, 3]", "[1, 4, 5, 2, 5, 4]",
        "[\"count\",\"add\",\"count\",\"count\",\"add\",\"add\",\"count\"]",
        "[[7], [3, 2], [8], [4], [0, 1], [1, 1], [7]]", "[8, 2, 1, 11]")]
    public void DesignNeighborSumService_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        string nums1Json, string nums2Json, string methodsJson, string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var nums1 = JsonHelper.Parse<int[]>(nums1Json);
        var nums2 = JsonHelper.Parse<int[]>(nums2Json);
        var methods = JsonHelper<string[]>.Parse(methodsJson);
        var arguments = JsonHelper<int[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper.Parse<int[]>(expectedResultJson);

        var solution = GetSolution(nums1, nums2);

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < methods.Length; i++)
        {
            switch (methods[i])
            {
                case Add:
                    solution.Add(arguments[i][0], arguments[i][1]);
                    break;
                case Count:
                    actualResult.Add(solution.Count(arguments[i][0]));
                    break;
                default:
                    throw new UnexpectedMethodException(methods[i]);
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IFindingPairsWithCertainSum GetSolution(int[] nums1, int[] nums2);
}