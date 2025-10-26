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

using LeetCode.Algorithms.SimpleBankSystem;
using LeetCode.Core.Helpers;

namespace LeetCode.Tests.Algorithms.SimpleBankSystem;

public abstract class SimpleBankSystemTestsBase
{
    private const string Transfer = "transfer";
    private const string Deposit = "deposit";
    private const string Withdraw = "withdraw";

    [TestMethod]
    [DataRow("[10, 100, 20, 50, 30]",
        "[\"withdraw\", \"transfer\", \"deposit\", \"transfer\", \"withdraw\"]",
        "[[3, 10], [5, 1, 20], [5, 20], [3, 4, 15], [10, 50]]",
        "[true, true, true, false, false]")]
    public void Test(string balanceJson, string operationsJson, string argumentsJson, string expectedResultJson)
    {
        // Arrange
        var balance = JsonHelper<long[]>.Parse(balanceJson);
        var operations = JsonHelper<string[]>.Parse(operationsJson);
        var arguments = JsonHelper<object[][]>.Parse(argumentsJson);
        var expectedResult = JsonHelper<object[]>.Parse(expectedResultJson);

        var solution = GetSolution(balance);

        // Act
        var actualResult = new List<object>();

        for (var i = 0; i < operations.Length; i++)
        {
            switch (operations[i])
            {
                case Transfer:
                    var transferResult = solution.Transfer((int)arguments[i][0], (int)arguments[i][1],
                        (int)arguments[i][2]);

                    actualResult.Add(transferResult);

                    break;
                case Deposit:
                    var depositResult = solution.Deposit((int)arguments[i][0], (int)arguments[i][1]);

                    actualResult.Add(depositResult);

                    break;
                case Withdraw:
                    var withdrawResult = solution.Withdraw((int)arguments[i][0], (int)arguments[i][1]);

                    actualResult.Add(withdrawResult);

                    break;
                default:
                    throw new ArgumentOutOfRangeException($"Unexpected operation '{operations[i]}' at index {i}.");
            }
        }

        // Assert
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract ISimpleBankSystem GetSolution(long[] balance);
}