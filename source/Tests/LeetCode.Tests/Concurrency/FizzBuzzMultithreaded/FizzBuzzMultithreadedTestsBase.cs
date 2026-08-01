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

        yield return [4, new[] { "1", "2", "fizz", "4" }];

        yield return [6, new[] { "1", "2", "fizz", "4", "buzz", "fizz" }];

        yield return [7, new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7" }];

        yield return [8, new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8" }];

        yield return [9, new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz" }];

        yield return [10, new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz" }];

        yield return [11, new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11" }];

        yield return [12, new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz" }];

        yield return [13, new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13" }];

        yield return [14, new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14" }];

        yield return [16, new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14", "fizzbuzz", "16" }];

        yield return
        [
            17, new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14", "fizzbuzz", "16", "17" }
        ];

        yield return
        [
            18,
            new[] { "1", "2", "fizz", "4", "buzz", "fizz", "7", "8", "fizz", "buzz", "11", "fizz", "13", "14", "fizzbuzz", "16", "17", "fizz" }
        ];

        yield return
        [
            19,
            new[]
            {
                "1",
                "2",
                "fizz",
                "4",
                "buzz",
                "fizz",
                "7",
                "8",
                "fizz",
                "buzz",
                "11",
                "fizz",
                "13",
                "14",
                "fizzbuzz",
                "16",
                "17",
                "fizz",
                "19"
            }
        ];

        yield return
        [
            20,
            new[]
            {
                "1",
                "2",
                "fizz",
                "4",
                "buzz",
                "fizz",
                "7",
                "8",
                "fizz",
                "buzz",
                "11",
                "fizz",
                "13",
                "14",
                "fizzbuzz",
                "16",
                "17",
                "fizz",
                "19",
                "buzz"
            }
        ];

        yield return
        [
            25,
            new[]
            {
                "1",
                "2",
                "fizz",
                "4",
                "buzz",
                "fizz",
                "7",
                "8",
                "fizz",
                "buzz",
                "11",
                "fizz",
                "13",
                "14",
                "fizzbuzz",
                "16",
                "17",
                "fizz",
                "19",
                "buzz",
                "fizz",
                "22",
                "23",
                "fizz",
                "buzz"
            }
        ];

        yield return
        [
            30,
            new[]
            {
                "1",
                "2",
                "fizz",
                "4",
                "buzz",
                "fizz",
                "7",
                "8",
                "fizz",
                "buzz",
                "11",
                "fizz",
                "13",
                "14",
                "fizzbuzz",
                "16",
                "17",
                "fizz",
                "19",
                "buzz",
                "fizz",
                "22",
                "23",
                "fizz",
                "buzz",
                "26",
                "fizz",
                "28",
                "29",
                "fizzbuzz"
            }
        ];

        yield return
        [
            45,
            new[]
            {
                "1",
                "2",
                "fizz",
                "4",
                "buzz",
                "fizz",
                "7",
                "8",
                "fizz",
                "buzz",
                "11",
                "fizz",
                "13",
                "14",
                "fizzbuzz",
                "16",
                "17",
                "fizz",
                "19",
                "buzz",
                "fizz",
                "22",
                "23",
                "fizz",
                "buzz",
                "26",
                "fizz",
                "28",
                "29",
                "fizzbuzz",
                "31",
                "32",
                "fizz",
                "34",
                "buzz",
                "fizz",
                "37",
                "38",
                "fizz",
                "buzz",
                "41",
                "fizz",
                "43",
                "44",
                "fizzbuzz"
            }
        ];

        yield return
        [
            50,
            new[]
            {
                "1",
                "2",
                "fizz",
                "4",
                "buzz",
                "fizz",
                "7",
                "8",
                "fizz",
                "buzz",
                "11",
                "fizz",
                "13",
                "14",
                "fizzbuzz",
                "16",
                "17",
                "fizz",
                "19",
                "buzz",
                "fizz",
                "22",
                "23",
                "fizz",
                "buzz",
                "26",
                "fizz",
                "28",
                "29",
                "fizzbuzz",
                "31",
                "32",
                "fizz",
                "34",
                "buzz",
                "fizz",
                "37",
                "38",
                "fizz",
                "buzz",
                "41",
                "fizz",
                "43",
                "44",
                "fizzbuzz",
                "46",
                "47",
                "fizz",
                "49",
                "buzz"
            }
        ];

        yield return
        [
            60,
            new[]
            {
                "1",
                "2",
                "fizz",
                "4",
                "buzz",
                "fizz",
                "7",
                "8",
                "fizz",
                "buzz",
                "11",
                "fizz",
                "13",
                "14",
                "fizzbuzz",
                "16",
                "17",
                "fizz",
                "19",
                "buzz",
                "fizz",
                "22",
                "23",
                "fizz",
                "buzz",
                "26",
                "fizz",
                "28",
                "29",
                "fizzbuzz",
                "31",
                "32",
                "fizz",
                "34",
                "buzz",
                "fizz",
                "37",
                "38",
                "fizz",
                "buzz",
                "41",
                "fizz",
                "43",
                "44",
                "fizzbuzz",
                "46",
                "47",
                "fizz",
                "49",
                "buzz",
                "fizz",
                "52",
                "53",
                "fizz",
                "buzz",
                "56",
                "fizz",
                "58",
                "59",
                "fizzbuzz"
            }
        ];

        yield return
        [
            100,
            new[]
            {
                "1",
                "2",
                "fizz",
                "4",
                "buzz",
                "fizz",
                "7",
                "8",
                "fizz",
                "buzz",
                "11",
                "fizz",
                "13",
                "14",
                "fizzbuzz",
                "16",
                "17",
                "fizz",
                "19",
                "buzz",
                "fizz",
                "22",
                "23",
                "fizz",
                "buzz",
                "26",
                "fizz",
                "28",
                "29",
                "fizzbuzz",
                "31",
                "32",
                "fizz",
                "34",
                "buzz",
                "fizz",
                "37",
                "38",
                "fizz",
                "buzz",
                "41",
                "fizz",
                "43",
                "44",
                "fizzbuzz",
                "46",
                "47",
                "fizz",
                "49",
                "buzz",
                "fizz",
                "52",
                "53",
                "fizz",
                "buzz",
                "56",
                "fizz",
                "58",
                "59",
                "fizzbuzz",
                "61",
                "62",
                "fizz",
                "64",
                "buzz",
                "fizz",
                "67",
                "68",
                "fizz",
                "buzz",
                "71",
                "fizz",
                "73",
                "74",
                "fizzbuzz",
                "76",
                "77",
                "fizz",
                "79",
                "buzz",
                "fizz",
                "82",
                "83",
                "fizz",
                "buzz",
                "86",
                "fizz",
                "88",
                "89",
                "fizzbuzz",
                "91",
                "92",
                "fizz",
                "94",
                "buzz",
                "fizz",
                "97",
                "98",
                "fizz",
                "buzz"
            }
        ];
    }
}