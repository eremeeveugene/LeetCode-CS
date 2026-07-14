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

using LeetCode.Algorithms.MyCalendar3;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.MyCalendar3;

public abstract class MyCalendar3TestsBase<T> where T : IMyCalendar3, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void MyCalendar3_WithMixedOperations_ProcessesOperationsAccordingToSpecification(IScenario<IMyCalendar3> scenario)
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

    private static IEnumerable<IScenario<IMyCalendar3>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IMyCalendar3>(
                [
                    new BookOperation(10, 20),
                    new BookOperation(50, 60),
                    new BookOperation(10, 40),
                    new BookOperation(5, 15),
                    new BookOperation(5, 10),
                    new BookOperation(25, 55)
                ],
                [
                    new BookOperation.Result(1),
                    new BookOperation.Result(1),
                    new BookOperation.Result(2),
                    new BookOperation.Result(3),
                    new BookOperation.Result(3),
                    new BookOperation.Result(3)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>([new BookOperation(1, 2)], [new BookOperation.Result(1)])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [new BookOperation(1, 2), new BookOperation(2, 3), new BookOperation(3, 4)],
                [new BookOperation.Result(1), new BookOperation.Result(1), new BookOperation.Result(1)])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [new BookOperation(5, 10), new BookOperation(5, 10), new BookOperation(5, 10)],
                [new BookOperation.Result(1), new BookOperation.Result(2), new BookOperation.Result(3)])
        ];

        yield return
        [
            new Scenario<IMyCalendar3>(
                [new BookOperation(1, 10), new BookOperation(2, 9), new BookOperation(3, 8)],
                [new BookOperation.Result(1), new BookOperation.Result(2), new BookOperation.Result(3)])
        ];
    }

    private sealed class BookOperation : IOperation<IMyCalendar3>
    {
        private readonly int _endTime;
        private readonly int _startTime;

        public BookOperation(int startTime, int endTime)
        {
            _startTime = startTime;
            _endTime = endTime;
        }

        public IOperationResult Execute(IMyCalendar3 myCalendar3)
        {
            var maxBooking = myCalendar3.Book(_startTime, _endTime);

            return new Result(maxBooking);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _maxBooking;

            public Result(int maxBooking)
            {
                _maxBooking = maxBooking;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _maxBooking == other._maxBooking;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_maxBooking);
            }
        }
    }
}