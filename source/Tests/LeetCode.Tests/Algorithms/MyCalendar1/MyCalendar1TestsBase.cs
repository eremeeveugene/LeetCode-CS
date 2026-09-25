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

using LeetCode.Algorithms.MyCalendar1;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.MyCalendar1;

public abstract class MyCalendar1TestsBase<T> where T : IMyCalendar1, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void MyCalendar1_WithMixedOperations_ProcessesOperationsAccordingToSpecification(IScenario<IMyCalendar1> scenario)
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

    private static IEnumerable<IScenario<IMyCalendar1>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(10, 20), new BookOperation(15, 25), new BookOperation(20, 30)],
                [new BookOperation.Result(true), new BookOperation.Result(false), new BookOperation.Result(true)])
        ];

        yield return [new Scenario<IMyCalendar1>([new BookOperation(10, 20)], [new BookOperation.Result(true)])];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(10, 20), new BookOperation(10, 20)],
                [new BookOperation.Result(true), new BookOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(10, 20), new BookOperation(20, 30), new BookOperation(30, 40)],
                [new BookOperation.Result(true), new BookOperation.Result(true), new BookOperation.Result(true)])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(10, 20), new BookOperation(15, 25)],
                [new BookOperation.Result(true), new BookOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(10, 20), new BookOperation(12, 15)],
                [new BookOperation.Result(true), new BookOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(0, 5), new BookOperation(5, 10), new BookOperation(10, 15)],
                [new BookOperation.Result(true), new BookOperation.Result(true), new BookOperation.Result(true)])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(5, 10), new BookOperation(0, 6)],
                [new BookOperation.Result(true), new BookOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(1, 5), new BookOperation(2, 6), new BookOperation(3, 7), new BookOperation(4, 8)],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(1, 5), new BookOperation(5, 9), new BookOperation(9, 13), new BookOperation(13, 17)],
                [new BookOperation.Result(true), new BookOperation.Result(true), new BookOperation.Result(true), new BookOperation.Result(true)])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(1, 3), new BookOperation(3, 5), new BookOperation(5, 7), new BookOperation(7, 9)],
                [new BookOperation.Result(true), new BookOperation.Result(true), new BookOperation.Result(true), new BookOperation.Result(true)])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(1, 10), new BookOperation(2, 3)],
                [new BookOperation.Result(true), new BookOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(47, 50), new BookOperation(33, 48), new BookOperation(39, 44), new BookOperation(15, 20)],
                [new BookOperation.Result(true), new BookOperation.Result(false), new BookOperation.Result(true), new BookOperation.Result(true)])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [
                    new BookOperation(20, 30),
                    new BookOperation(50, 60),
                    new BookOperation(35, 45),
                    new BookOperation(5, 15),
                    new BookOperation(25, 55)
                ],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(true),
                    new BookOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(100, 200), new BookOperation(200, 300), new BookOperation(300, 400)],
                [new BookOperation.Result(true), new BookOperation.Result(true), new BookOperation.Result(true)])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(100, 200), new BookOperation(150, 160)],
                [new BookOperation.Result(true), new BookOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(0, 1000000000), new BookOperation(0, 1)],
                [new BookOperation.Result(true), new BookOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(5, 7), new BookOperation(6, 8)],
                [new BookOperation.Result(true), new BookOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(1, 2), new BookOperation(1, 2), new BookOperation(1, 2), new BookOperation(1, 2), new BookOperation(1, 2)],
                [
                    new BookOperation.Result(true),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false),
                    new BookOperation.Result(false)
                ])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(0, 1000000000), new BookOperation(999999999, 1000000000)],
                [new BookOperation.Result(true), new BookOperation.Result(false)])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(5, 8), new BookOperation(10, 12), new BookOperation(15, 18)],
                [new BookOperation.Result(true), new BookOperation.Result(true), new BookOperation.Result(true)])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(1, 2), new BookOperation(2, 3), new BookOperation(3, 4)],
                [new BookOperation.Result(true), new BookOperation.Result(true), new BookOperation.Result(true)])
        ];

        yield return
        [
            new Scenario<IMyCalendar1>(
                [new BookOperation(11, 13), new BookOperation(15, 20), new BookOperation(9, 14)],
                [new BookOperation.Result(true), new BookOperation.Result(true), new BookOperation.Result(false)])
        ];
    }

    private sealed class BookOperation : IOperation<IMyCalendar1>
    {
        private readonly int _end;
        private readonly int _start;

        public BookOperation(int start, int end)
        {
            _start = start;
            _end = end;
        }

        public IOperationResult Execute(IMyCalendar1 solution)
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