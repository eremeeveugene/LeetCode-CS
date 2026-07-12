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

using LeetCode.Algorithms.DesignHashSet;

namespace LeetCode.Tests.Algorithms.DesignHashSet;

public abstract class DesignHashSetTestsBase<T> where T : IDesignHashSet, new()
{
    private const string Add = "add";
    private const string Remove = "remove";
    private const string Contains = "contains";

    [TestMethod]
    [DynamicData(nameof(GetTestData))]
    public void DesignHashSet_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        string[] operations,
        int[][] arguments,
        bool[] expectedResult)
    {
        // Arrange
        var solution = new T();

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < operations.Length; i++)
        {
            switch (operations[i])
            {
                case Add:
                    solution.Add(arguments[i][0]);

                    break;
                case Remove:
                    solution.Remove(arguments[i][0]);

                    break;
                case Contains:
                    actualResult.Add(solution.Contains(arguments[i][0]));

                    break;
                default:
                    throw new ArgumentOutOfRangeException($"Unexpected operation '{operations[i]}' at index {i}.");
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static IEnumerable<object[]> GetTestData()
    {
        yield return
        [
            new[] { "add", "add", "contains", "contains", "add", "contains", "remove", "contains" },
            new[] { new[] { 1 }, new[] { 2 }, new[] { 1 }, new[] { 3 }, new[] { 2 }, new[] { 2 }, new[] { 2 }, new[] { 2 } },
            new[] { true, false, true, false }
        ];
    }
}