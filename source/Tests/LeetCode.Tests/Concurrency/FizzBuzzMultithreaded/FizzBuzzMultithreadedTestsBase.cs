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

using LeetCode.Concurrency.FizzBuzzMultithreaded;

namespace LeetCode.Tests.Concurrency.FizzBuzzMultithreaded;

public abstract class FizzBuzzMultithreadedTestsBase
{
    public TestContext TestContext { get; set; } = null!;

    [TestMethod]
    [DynamicData(nameof(GetTestCases))]
    public async Task FizzBuzzMultithreaded_WithGivenLength_ProducesCorrectSequence(int length, string[] expectedResult)
    {
        // Arrange
        var solution = GetSolution(length);

        // Act
        List<string> actualResult = [];

        List<Task> tasks =
        [
            Task.Run(() => solution.Fizz(() => actualResult.Add("fizz")), TestContext.CancellationToken),
            Task.Run(() => solution.Buzz(() => actualResult.Add("buzz")), TestContext.CancellationToken),
            Task.Run(() => solution.Fizzbuzz(() => actualResult.Add("fizzbuzz")), TestContext.CancellationToken),
            Task.Run(() => solution.Number(n => actualResult.Add(n.ToString())), TestContext.CancellationToken)
        ];

        await Task.WhenAll(tasks);

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    protected abstract IFizzBuzzMultithreaded GetSolution(int n);

    private static IEnumerable<object[]> GetTestCases()
    {
        yield return [1, new[] { "1" }];
        yield return [2, new[] { "1", "2" }];
        yield return [3, new[] { "1", "2", "fizz" }];
        yield return [5, new[] { "1", "2", "fizz", "4", "buzz" }];
        yield return [15, new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14", "fizzbuzz" }];
    }
}