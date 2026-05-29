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
using LeetCode.Tests.Base.Exceptions;

namespace LeetCode.Tests.Algorithms.FindingPairsWithCertainSum;

public abstract class FindingPairsWithCertainSumTestsBase
{
    private const string Count = "count";
    private const string Add = "add";

    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void DesignNeighborSumService_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        int[] nums1, int[] nums2, string[] methods, int[][] arguments, int[] expectedResult)
    {
        // Arrange
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

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[] { 1, 1, 2, 2, 2, 3 }, new[] { 1, 4, 5, 2, 5, 4 },
            new[] { "count", "add", "count", "count", "add", "add", "count" },
            new[]
            {
                new[] { 7 }, new[] { 3, 2 }, new[] { 8 }, new[] { 4 }, new[] { 0, 1 }, new[] { 1, 1 }, new[] { 7 }
            },
            new[] { 8, 2, 1, 11 }
        ];
    }

    protected abstract IFindingPairsWithCertainSum GetSolution(int[] nums1, int[] nums2);
}