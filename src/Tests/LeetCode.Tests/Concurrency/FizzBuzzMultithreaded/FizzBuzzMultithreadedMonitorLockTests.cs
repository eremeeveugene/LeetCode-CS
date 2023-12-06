﻿// --------------------------------------------------------------------------------
// Copyright (C) 2023 Eugene Eremeev (also known as Yevhenii Yeriemeieiv).
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

[TestClass]
public class FizzBuzzMultithreadedMonitorLockTests
{
    [TestMethod]
    [DataRow(1, "1")]
    [DataRow(2, "1, 2")]
    [DataRow(3, "1, 2, fizz")]
    [DataRow(5, "1, 2, fizz, 4, buzz")]
    [DataRow(15, "1, 2, fizz, 4, buzz, fizz, 7, 8, fizz, buzz, 11, fizz, 13, 14, fizzbuzz")]
    public async Task FizzBuzzMultithreadedMonitorLock_ExecutesTasks_GeneratesCorrectSequence(int length,
        string expectedResultJson)
    {
        // Arrange
        var expectedResult = DeserializeToList(expectedResultJson);
        var actualResult = new List<object>();

        // Act
        var fizzBuzzMultithreaded = new FizzBuzzMultithreadedMonitorLock(length);

        var tasks = new List<Task>
        {
            Task.Run(() => fizzBuzzMultithreaded.Fizz(() => actualResult.Add("fizz"))),
            Task.Run(() => fizzBuzzMultithreaded.Buzz(() => actualResult.Add("buzz"))),
            Task.Run(() => fizzBuzzMultithreaded.Fizzbuzz(() => actualResult.Add("fizzbuzz"))),
            Task.Run(() => fizzBuzzMultithreaded.Number(n => actualResult.Add(n)))
        };

        await Task.WhenAll(tasks);

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    private static List<object> DeserializeToList(string input)
    {
        var resultList = new List<object>();
        var elements = input.Split(',');

        foreach (var element in elements)
        {
            var trimmedElement = element.Trim();

            if (int.TryParse(trimmedElement, out var number))
                resultList.Add(number);
            else
                resultList.Add(trimmedElement);
        }

        return resultList;
    }
}