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

using LeetCode.Algorithms.RangeSumQueryMutable;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.RangeSumQueryMutable;

public abstract class RangeSumQueryMutableTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void RangeSumQueryMutable_WithGivenArrayAndRangeQueries_ProcessesOperationsAccordingToSpecification(RangeSumQueryMutableScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.Nums);

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

    protected abstract IRangeSumQueryMutable GetSolution(int[] nums);

    private static IEnumerable<RangeSumQueryMutableScenario[]> GetScenarios()
    {
        yield return
        [
            new RangeSumQueryMutableScenario(
                [1, 3, 5],
                [new SumRangeOperation(0, 2), new UpdateOperation(1, 2), new SumRangeOperation(0, 2)],
                [new SumRangeOperation.Result(9), VoidOperationResult.Instance, new SumRangeOperation.Result(8)])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [1, 2, 3],
                [new UpdateOperation(1, 10), new UpdateOperation(1, 5), new SumRangeOperation(0, 2)],
                [VoidOperationResult.Instance, VoidOperationResult.Instance, new SumRangeOperation.Result(9)])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [1, 2, 3, 4, 5],
                [new SumRangeOperation(0, 4), new UpdateOperation(0, 10), new UpdateOperation(4, 10), new SumRangeOperation(0, 4)],
                [new SumRangeOperation.Result(15), VoidOperationResult.Instance, VoidOperationResult.Instance, new SumRangeOperation.Result(29)])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [7],
                [new SumRangeOperation(0, 0), new UpdateOperation(0, 3), new SumRangeOperation(0, 0)],
                [new SumRangeOperation.Result(7), VoidOperationResult.Instance, new SumRangeOperation.Result(3)])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [1, 2, 3],
                [new SumRangeOperation(1, 1), new UpdateOperation(0, 100), new SumRangeOperation(1, 1)],
                [new SumRangeOperation.Result(2), VoidOperationResult.Instance, new SumRangeOperation.Result(2)])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [0],
                [
                    new SumRangeOperation(0, 0),
                    new UpdateOperation(0, 100),
                    new SumRangeOperation(0, 0)
                ],
                [
                    new SumRangeOperation.Result(0),
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(100)
                ])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [-100],
                [
                    new SumRangeOperation(0, 0),
                    new UpdateOperation(0, -50),
                    new SumRangeOperation(0, 0)
                ],
                [
                    new SumRangeOperation.Result(-100),
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(-50)
                ])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [1, 1],
                [
                    new SumRangeOperation(0, 1),
                    new UpdateOperation(1, 100),
                    new SumRangeOperation(0, 1),
                    new UpdateOperation(0, -100),
                    new SumRangeOperation(0, 1)
                ],
                [
                    new SumRangeOperation.Result(2),
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(101),
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(0)
                ])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [1, 2, 3, 4],
                [
                    new UpdateOperation(0, 0),
                    new UpdateOperation(1, 0),
                    new UpdateOperation(2, 0),
                    new UpdateOperation(3, 0),
                    new SumRangeOperation(0, 3)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(0)
                ])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [5, 5, 5, 5, 5, 5],
                [
                    new SumRangeOperation(1, 4),
                    new UpdateOperation(2, 0),
                    new SumRangeOperation(1, 4),
                    new UpdateOperation(3, 10),
                    new SumRangeOperation(1, 4),
                    new SumRangeOperation(0, 5)
                ],
                [
                    new SumRangeOperation.Result(20),
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(15),
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(20),
                    new SumRangeOperation.Result(30)
                ])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [-1, -2, -3, -4, -5],
                [
                    new SumRangeOperation(0, 4),
                    new UpdateOperation(4, 5),
                    new SumRangeOperation(0, 4),
                    new UpdateOperation(0, 5),
                    new SumRangeOperation(0, 4),
                    new SumRangeOperation(1, 3)
                ],
                [
                    new SumRangeOperation.Result(-15),
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(-5),
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(1),
                    new SumRangeOperation.Result(-9)
                ])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [10, 20, 30],
                [
                    new UpdateOperation(1, 20),
                    new SumRangeOperation(0, 2),
                    new SumRangeOperation(1, 1)
                ],
                [
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(60),
                    new SumRangeOperation.Result(20)
                ])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [1, 2, 3, 4, 5, 6, 7],
                [
                    new SumRangeOperation(0, 6),
                    new UpdateOperation(3, -4),
                    new SumRangeOperation(0, 6),
                    new SumRangeOperation(3, 3),
                    new SumRangeOperation(2, 4),
                    new UpdateOperation(6, 7),
                    new SumRangeOperation(5, 6)
                ],
                [
                    new SumRangeOperation.Result(28),
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(20),
                    new SumRangeOperation.Result(-4),
                    new SumRangeOperation.Result(4),
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(13)
                ])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [100, -100, 100, -100],
                [
                    new SumRangeOperation(0, 3),
                    new UpdateOperation(1, 100),
                    new SumRangeOperation(0, 3),
                    new UpdateOperation(3, 100),
                    new SumRangeOperation(0, 3),
                    new SumRangeOperation(1, 2)
                ],
                [
                    new SumRangeOperation.Result(0),
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(200),
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(400),
                    new SumRangeOperation.Result(200)
                ])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [0, 0, 0, 0, 0],
                [
                    new UpdateOperation(2, 7),
                    new SumRangeOperation(0, 4),
                    new SumRangeOperation(0, 1),
                    new SumRangeOperation(2, 2),
                    new SumRangeOperation(3, 4)
                ],
                [
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(7),
                    new SumRangeOperation.Result(0),
                    new SumRangeOperation.Result(7),
                    new SumRangeOperation.Result(0)
                ])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [4, 3, 2, 1],
                [
                    new SumRangeOperation(0, 0),
                    new UpdateOperation(0, 1),
                    new UpdateOperation(1, 2),
                    new UpdateOperation(2, 3),
                    new UpdateOperation(3, 4),
                    new SumRangeOperation(0, 3),
                    new SumRangeOperation(0, 0),
                    new SumRangeOperation(3, 3)
                ],
                [
                    new SumRangeOperation.Result(4),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(10),
                    new SumRangeOperation.Result(1),
                    new SumRangeOperation.Result(4)
                ])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [9, 9, 9, 9, 9, 9, 9, 9],
                [
                    new SumRangeOperation(0, 7),
                    new UpdateOperation(4, -9),
                    new SumRangeOperation(0, 7),
                    new SumRangeOperation(4, 4),
                    new SumRangeOperation(0, 3),
                    new SumRangeOperation(5, 7),
                    new UpdateOperation(7, 100),
                    new SumRangeOperation(4, 7)
                ],
                [
                    new SumRangeOperation.Result(72),
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(54),
                    new SumRangeOperation.Result(-9),
                    new SumRangeOperation.Result(36),
                    new SumRangeOperation.Result(27),
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(109)
                ])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [1, 2, 3],
                [
                    new UpdateOperation(0, 3),
                    new UpdateOperation(1, 2),
                    new UpdateOperation(2, 1),
                    new SumRangeOperation(0, 2),
                    new SumRangeOperation(0, 0),
                    new SumRangeOperation(2, 2)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(6),
                    new SumRangeOperation.Result(3),
                    new SumRangeOperation.Result(1)
                ])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [-100, 100],
                [
                    new SumRangeOperation(0, 1),
                    new UpdateOperation(0, 100),
                    new SumRangeOperation(0, 1),
                    new UpdateOperation(1, -100),
                    new SumRangeOperation(0, 1)
                ],
                [
                    new SumRangeOperation.Result(0),
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(200),
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(0)
                ])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [6, 5, 4, 3, 2, 1],
                [
                    new UpdateOperation(5, 6),
                    new UpdateOperation(4, 5),
                    new UpdateOperation(3, 4),
                    new SumRangeOperation(3, 5),
                    new SumRangeOperation(0, 5),
                    new UpdateOperation(0, 1),
                    new SumRangeOperation(0, 5)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(15),
                    new SumRangeOperation.Result(30),
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(25)
                ])
        ];

        yield return
        [
            new RangeSumQueryMutableScenario(
                [2, 2, 2, 2, 2, 2, 2, 2, 2, 2],
                [
                    new SumRangeOperation(0, 9),
                    new UpdateOperation(9, -2),
                    new UpdateOperation(0, -2),
                    new SumRangeOperation(0, 9),
                    new SumRangeOperation(1, 8),
                    new UpdateOperation(5, 20),
                    new SumRangeOperation(4, 6)
                ],
                [
                    new SumRangeOperation.Result(20),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(12),
                    new SumRangeOperation.Result(16),
                    VoidOperationResult.Instance,
                    new SumRangeOperation.Result(24)
                ])
        ];

        yield return [CreateMaxLengthScenario()];
    }

    private static RangeSumQueryMutableScenario CreateMaxLengthScenario()
    {
        const int Length = 30000;

        var nums = new int[Length];

        for (var i = 0; i < Length; i++)
        {
            nums[i] = 1;
        }

        IOperation<IRangeSumQueryMutable>[] operations =
        [
            new SumRangeOperation(0, Length - 1),
            new UpdateOperation(Length / 2, 100),
            new SumRangeOperation(0, Length - 1),
            new SumRangeOperation(Length / 2, Length / 2),
            new UpdateOperation(Length - 1, -100),
            new SumRangeOperation(Length / 2, Length - 1)
        ];

        IOperationResult[] operationResults =
        [
            new SumRangeOperation.Result(30000),
            VoidOperationResult.Instance,
            new SumRangeOperation.Result(30099),
            new SumRangeOperation.Result(100),
            VoidOperationResult.Instance,
            new SumRangeOperation.Result(14998)
        ];

        return new RangeSumQueryMutableScenario(nums, operations, operationResults);
    }

    public sealed class RangeSumQueryMutableScenario : IScenario<IRangeSumQueryMutable>
    {
        public RangeSumQueryMutableScenario(int[] nums, IOperation<IRangeSumQueryMutable>[] operations, IOperationResult[] operationResults)
        {
            Nums = nums;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int[] Nums { get; }

        public IOperation<IRangeSumQueryMutable>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class UpdateOperation : IOperation<IRangeSumQueryMutable>
    {
        private readonly int _index;
        private readonly int _value;

        public UpdateOperation(int index, int value)
        {
            _index = index;
            _value = value;
        }

        public IOperationResult Execute(IRangeSumQueryMutable rangeSumQueryMutable)
        {
            rangeSumQueryMutable.Update(_index, _value);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class SumRangeOperation : IOperation<IRangeSumQueryMutable>
    {
        private readonly int _left;
        private readonly int _right;

        public SumRangeOperation(int left, int right)
        {
            _left = left;
            _right = right;
        }

        public IOperationResult Execute(IRangeSumQueryMutable rangeSumQueryMutable)
        {
            var sum = rangeSumQueryMutable.SumRange(_left, _right);

            return new Result(sum);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _sum;

            public Result(int sum)
            {
                _sum = sum;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _sum == other._sum;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_sum);
            }
        }
    }
}