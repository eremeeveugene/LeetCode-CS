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

using LeetCode.Algorithms.DesignExamScoresTracker;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignExamScoresTracker;

public abstract class DesignExamScoresTrackerTestsBase<T> where T : IDesignExamScoresTracker, new()
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignExamScoresTracker_WithMixedOperations_ProcessesOperationsAccordingToSpecification(IScenario<IDesignExamScoresTracker> scenario)
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

    private static IEnumerable<IScenario<IDesignExamScoresTracker>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [
                    new RecordOperation(1, 98),
                    new TotalScoreOperation(1, 1),
                    new RecordOperation(5, 99),
                    new TotalScoreOperation(1, 3),
                    new TotalScoreOperation(1, 5),
                    new TotalScoreOperation(3, 4),
                    new TotalScoreOperation(2, 5)
                ],
                [
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(98L),
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(98L),
                    new TotalScoreOperation.Result(197L),
                    new TotalScoreOperation.Result(0L),
                    new TotalScoreOperation.Result(99L)
                ])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [new RecordOperation(1, 1), new TotalScoreOperation(1, 1)],
                [VoidOperationResult.Instance, new TotalScoreOperation.Result(1L)])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [new RecordOperation(10, 80), new TotalScoreOperation(1, 9), new TotalScoreOperation(10, 10), new TotalScoreOperation(1, 10)],
                [
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(0L),
                    new TotalScoreOperation.Result(80L),
                    new TotalScoreOperation.Result(80L)
                ])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [
                    new RecordOperation(1000000000, 1000000000),
                    new TotalScoreOperation(1, 999999999),
                    new TotalScoreOperation(1000000000, 1000000000)
                ],
                [VoidOperationResult.Instance, new TotalScoreOperation.Result(0L), new TotalScoreOperation.Result(1000000000L)])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [
                    new RecordOperation(1, 10),
                    new RecordOperation(2, 20),
                    new TotalScoreOperation(1, 2),
                    new TotalScoreOperation(1, 1),
                    new TotalScoreOperation(2, 2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(30L),
                    new TotalScoreOperation.Result(10L),
                    new TotalScoreOperation.Result(20L)
                ])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [new RecordOperation(1, 10), new RecordOperation(10, 20), new TotalScoreOperation(2, 9)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new TotalScoreOperation.Result(0L)])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [new RecordOperation(5, 10), new RecordOperation(10, 20), new RecordOperation(15, 30), new TotalScoreOperation(5, 10)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new TotalScoreOperation.Result(30L)])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [new RecordOperation(5, 10), new RecordOperation(10, 20), new RecordOperation(15, 30), new TotalScoreOperation(6, 15)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new TotalScoreOperation.Result(50L)])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [new RecordOperation(5, 10), new RecordOperation(10, 20), new RecordOperation(15, 30), new TotalScoreOperation(6, 14)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new TotalScoreOperation.Result(20L)])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [new RecordOperation(5, 10), new RecordOperation(10, 20), new RecordOperation(15, 30), new TotalScoreOperation(1, 4)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new TotalScoreOperation.Result(0L)])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [new RecordOperation(5, 10), new RecordOperation(10, 20), new RecordOperation(15, 30), new TotalScoreOperation(1, 15)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new TotalScoreOperation.Result(60L)])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [new RecordOperation(5, 10), new RecordOperation(10, 20), new RecordOperation(15, 30), new TotalScoreOperation(10, 10)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, VoidOperationResult.Instance, new TotalScoreOperation.Result(20L)])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [
                    new RecordOperation(5, 10),
                    new RecordOperation(10, 20),
                    new RecordOperation(15, 30),
                    new TotalScoreOperation(9, 9),
                    new TotalScoreOperation(11, 11)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(0L),
                    new TotalScoreOperation.Result(0L)
                ])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [
                    new RecordOperation(3, 7),
                    new RecordOperation(8, 11),
                    new TotalScoreOperation(3, 8),
                    new TotalScoreOperation(3, 8),
                    new TotalScoreOperation(3, 8)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(18L),
                    new TotalScoreOperation.Result(18L),
                    new TotalScoreOperation.Result(18L)
                ])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [
                    new RecordOperation(1, 10),
                    new TotalScoreOperation(1, 1),
                    new RecordOperation(2, 20),
                    new TotalScoreOperation(1, 1),
                    new TotalScoreOperation(1, 2),
                    new RecordOperation(3, 30),
                    new TotalScoreOperation(2, 3)
                ],
                [
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(10L),
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(10L),
                    new TotalScoreOperation.Result(30L),
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(50L)
                ])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [
                    new RecordOperation(2, 10),
                    new RecordOperation(4, 20),
                    new RecordOperation(6, 30),
                    new TotalScoreOperation(1, 6),
                    new TotalScoreOperation(1, 2),
                    new TotalScoreOperation(3, 4),
                    new TotalScoreOperation(2, 6)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(60L),
                    new TotalScoreOperation.Result(10L),
                    new TotalScoreOperation.Result(20L),
                    new TotalScoreOperation.Result(60L)
                ])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [
                    new RecordOperation(1, 1000000000),
                    new RecordOperation(2, 1000000000),
                    new RecordOperation(3, 1000000000),
                    new TotalScoreOperation(1, 3),
                    new TotalScoreOperation(2, 3)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(3000000000L),
                    new TotalScoreOperation.Result(2000000000L)
                ])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [
                    new RecordOperation(1, 1000000000),
                    new RecordOperation(2, 1000000000),
                    new RecordOperation(3, 1000000000),
                    new RecordOperation(4, 1),
                    new TotalScoreOperation(4, 4),
                    new TotalScoreOperation(3, 4)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(1L),
                    new TotalScoreOperation.Result(1000000001L)
                ])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [
                    new RecordOperation(1, 7),
                    new RecordOperation(1000000000, 9),
                    new TotalScoreOperation(1, 1000000000),
                    new TotalScoreOperation(2, 999999999),
                    new TotalScoreOperation(999999999, 1000000000)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(16L),
                    new TotalScoreOperation.Result(0L),
                    new TotalScoreOperation.Result(9L)
                ])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [
                    new RecordOperation(999999998, 10),
                    new RecordOperation(999999999, 20),
                    new RecordOperation(1000000000, 30),
                    new TotalScoreOperation(999999998, 999999999),
                    new TotalScoreOperation(999999999, 1000000000)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(30L),
                    new TotalScoreOperation.Result(50L)
                ])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [
                    new RecordOperation(1, 5),
                    new RecordOperation(2, 5),
                    new RecordOperation(3, 5),
                    new RecordOperation(4, 5),
                    new RecordOperation(5, 5),
                    new TotalScoreOperation(2, 4),
                    new TotalScoreOperation(1, 5)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(15L),
                    new TotalScoreOperation.Result(25L)
                ])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [
                    new RecordOperation(10, 1),
                    new RecordOperation(20, 1000000000),
                    new RecordOperation(30, 1),
                    new RecordOperation(40, 1000000000),
                    new TotalScoreOperation(10, 40),
                    new TotalScoreOperation(21, 39)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(2000000002L),
                    new TotalScoreOperation.Result(1L)
                ])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [
                    new RecordOperation(1, 1),
                    new RecordOperation(2, 2),
                    new RecordOperation(3, 3),
                    new RecordOperation(4, 4),
                    new RecordOperation(5, 5),
                    new RecordOperation(6, 6),
                    new RecordOperation(7, 7),
                    new RecordOperation(8, 8),
                    new TotalScoreOperation(1, 8),
                    new TotalScoreOperation(3, 6),
                    new TotalScoreOperation(8, 8)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(36L),
                    new TotalScoreOperation.Result(18L),
                    new TotalScoreOperation.Result(8L)
                ])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [
                    new RecordOperation(2, 4),
                    new RecordOperation(4, 8),
                    new RecordOperation(6, 12),
                    new RecordOperation(8, 16),
                    new RecordOperation(10, 20),
                    new RecordOperation(12, 24),
                    new RecordOperation(14, 28),
                    new TotalScoreOperation(3, 13),
                    new TotalScoreOperation(2, 14)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(80L),
                    new TotalScoreOperation.Result(112L)
                ])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [
                    new RecordOperation(7, 90),
                    new TotalScoreOperation(1, 6),
                    new RecordOperation(100, 10),
                    new TotalScoreOperation(8, 99),
                    new TotalScoreOperation(7, 99),
                    new TotalScoreOperation(8, 100)
                ],
                [
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(0L),
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(0L),
                    new TotalScoreOperation.Result(90L),
                    new TotalScoreOperation.Result(10L)
                ])
        ];

        yield return
        [
            new Scenario<IDesignExamScoresTracker>(
                [
                    new RecordOperation(1, 2),
                    new TotalScoreOperation(1, 1),
                    new RecordOperation(3, 4),
                    new TotalScoreOperation(2, 2),
                    new RecordOperation(5, 6),
                    new TotalScoreOperation(2, 4),
                    new RecordOperation(7, 8),
                    new TotalScoreOperation(4, 7)
                ],
                [
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(2L),
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(0L),
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(4L),
                    VoidOperationResult.Instance,
                    new TotalScoreOperation.Result(14L)
                ])
        ];

        const int recordCount = 99999;
        const int score = 1000000000;

        var operations = new IOperation<IDesignExamScoresTracker>[recordCount + 1];
        var operationResults = new IOperationResult[recordCount + 1];

        for (var i = 0; i < recordCount; i++)
        {
            operations[i] = new RecordOperation(i + 1, score);
            operationResults[i] = VoidOperationResult.Instance;
        }

        operations[recordCount] = new TotalScoreOperation(1, recordCount);
        operationResults[recordCount] = new TotalScoreOperation.Result((long)recordCount * score);

        yield return [new Scenario<IDesignExamScoresTracker>(operations, operationResults)];
    }

    private sealed class RecordOperation : IOperation<IDesignExamScoresTracker>
    {
        private readonly int _score;
        private readonly int _time;

        public RecordOperation(int time, int score)
        {
            _time = time;
            _score = score;
        }

        public IOperationResult Execute(IDesignExamScoresTracker solution)
        {
            solution.Record(_time, _score);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class TotalScoreOperation : IOperation<IDesignExamScoresTracker>
    {
        private readonly int _endTime;
        private readonly int _startTime;

        public TotalScoreOperation(int startTime, int endTime)
        {
            _startTime = startTime;
            _endTime = endTime;
        }

        public IOperationResult Execute(IDesignExamScoresTracker solution)
        {
            var result = solution.TotalScore(_startTime, _endTime);

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly long _value;

            public Result(long value)
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