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

using LeetCode.Algorithms.MyCalendar2;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.MyCalendar2;

public abstract class MyCalendar2TestsBase<T> where T : IMyCalendar2, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void MyCalendar2_WithMixedOperations_ProcessesOperationsAccordingToSpecification(IScenario<IMyCalendar2> scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = new T();

        // Act
        var operations = scenario.Operations;
        var operationsLength = operations.Length;

        var actualResult = new IOperationResult[operationsLength];

        for (var i = 0; i < operationsLength; i++)
        {
            var operation = operations[i];

            actualResult[i] = operation.Execute(solution);
        }

        // Assert
        Assert.AreSequenceEqual(expectedResult, actualResult);
    }

    private static IEnumerable<IScenario<IMyCalendar2>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IMyCalendar2>(
                [
                    new BookOperation(10, 20),
                    new BookOperation(50, 60),
                    new BookOperation(10, 40),
                    new BookOperation(5, 15),
                    new BookOperation(5, 10),
                    new BookOperation(25, 55)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true)
                ])
        ];
    }

    private sealed class BookOperation : IOperation<IMyCalendar2>
    {
        private readonly int _end;
        private readonly int _start;

        public BookOperation(int start, int end)
        {
            _start = start;
            _end = end;
        }

        public IOperationResult Execute(IMyCalendar2 solution)
        {
            var result = solution.Book(_start, _end);

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _value;

            public Result(bool value)
            {
                _value = value;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _value == other._value;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_value);
            }
        }
    }
}