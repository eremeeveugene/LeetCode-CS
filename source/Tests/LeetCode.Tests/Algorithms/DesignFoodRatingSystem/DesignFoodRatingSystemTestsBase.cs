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

using LeetCode.Algorithms.DesignFoodRatingSystem;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.DesignFoodRatingSystem;

public abstract class DesignFoodRatingSystemTestsBase
{
    private const string HighestRated = "highestRated";
    private const string ChangeRating = "changeRating";

    [TestMethod]
    [DataRow("[\"kimchi\", \"miso\", \"sushi\", \"moussaka\", \"ramen\", \"bulgogi\"]",
        "[\"korean\", \"japanese\", \"japanese\", \"greek\", \"japanese\", \"korean\"]",
        "[9, 12, 8, 15, 14, 7]",
        "[\"highestRated\", \"highestRated\", \"changeRating\", \"highestRated\", \"changeRating\", \"highestRated\"]",
        "[[\"korean\"], [\"japanese\"], [\"sushi\", 16], [\"japanese\"], [\"ramen\", 16], [\"japanese\"]]",
        "[\"kimchi\", \"ramen\", \"sushi\", \"ramen\"]")]
    public void DesignFoodRatingSystem_WithMixedOperations_ProcessesOperationsAccordingToSpecification(string foodsJson,
        string cuisinesJson, string ratingsJson, string operationsJson, string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var foods = JsonHelper<string[]>.Parse(foodsJson);
        var cuisines = JsonHelper<string[]>.Parse(cuisinesJson);
        var ratings = JsonHelper<int[]>.Parse(ratingsJson);
        var operations = JsonHelper<string[]>.Parse(operationsJson);
        var arguments = JsonHelper<object[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper<string[]>.Parse(expectedResultJson);

        var solution = GetSolution(foods, cuisines, ratings);

        // Act
        var actualResult = new List<string>();

        for (var i = 0; i < operations.Length; i++)
        {
            switch (operations[i])
            {
                case HighestRated:
                    var cuisine = (string)arguments[i][0];

                    actualResult.Add(solution.HighestRated(cuisine));

                    break;
                case ChangeRating:
                    var food = (string)arguments[i][0];
                    var newRating = (int)arguments[i][1];

                    solution.ChangeRating(food, newRating);

                    break;
                default:
                    throw new ArgumentOutOfRangeException($"Unexpected operation '{operations[i]}' at index {i}.");
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IDesignFoodRatingSystem GetSolution(string[] foods, string[] cuisines, int[] ratings);
}