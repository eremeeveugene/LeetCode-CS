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

using LeetCode.Algorithms.DesignStackWithIncrementOperation;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignStackWithIncrementOperation;

public abstract class DesignStackWithIncrementOperationTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignStackWithIncrementOperation_WithMixedOperations_ProcessesOperationsAccordingToSpecification(StackWithIncrementScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.MaxSize);

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

    protected abstract IDesignStackWithIncrementOperation GetSolution(int maxSize);

    private static IEnumerable<StackWithIncrementScenario[]> GetScenarios()
    {
        yield return
        [
            new StackWithIncrementScenario(
                3,
                [
                    new PushOperation(1),
                    new PushOperation(2),
                    new PopOperation(),
                    new PushOperation(2),
                    new PushOperation(3),
                    new PushOperation(4),
                    new IncrementOperation(5, 100),
                    new IncrementOperation(2, 100),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(2),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(103),
                    new PopOperation.Result(202),
                    new PopOperation.Result(201),
                    new PopOperation.Result(-1)
                ])
        ];

        yield return [new StackWithIncrementScenario(2, [new PopOperation()], [new PopOperation.Result(-1)])];

        yield return
        [
            new StackWithIncrementScenario(
                2,
                [new PushOperation(1), new PushOperation(2), new PushOperation(3), new PopOperation(), new PopOperation(), new PopOperation()],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(2),
                    new PopOperation.Result(1),
                    new PopOperation.Result(-1)
                ])
        ];

        yield return
        [
            new StackWithIncrementScenario(
                3,
                [new PushOperation(1), new PushOperation(2), new IncrementOperation(10, 5), new PopOperation(), new PopOperation()],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(7),
                    new PopOperation.Result(6)
                ])
        ];

        yield return
        [
            new StackWithIncrementScenario(
                3,
                [new PushOperation(5), new PushOperation(10), new IncrementOperation(0, 100), new PopOperation(), new PopOperation()],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(10),
                    new PopOperation.Result(5)
                ])
        ];

        yield return
        [
            new StackWithIncrementScenario(
                1,
                [
                    new PushOperation(1),
                    new PushOperation(2),
                    new PopOperation(),
                    new PopOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(1),
                    new PopOperation.Result(-1)
                ])
        ];

        yield return
        [
            new StackWithIncrementScenario(
                1,
                [
                    new PopOperation(),
                    new IncrementOperation(1, 5),
                    new PushOperation(9),
                    new IncrementOperation(1, -5),
                    new PopOperation()
                ],
                [
                    new PopOperation.Result(-1),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(4)
                ])
        ];

        yield return
        [
            new StackWithIncrementScenario(
                5,
                [
                    new PushOperation(1),
                    new PushOperation(2),
                    new PushOperation(3),
                    new IncrementOperation(2, -100),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(3),
                    new PopOperation.Result(-98),
                    new PopOperation.Result(-99)
                ])
        ];

        yield return
        [
            new StackWithIncrementScenario(
                4,
                [
                    new PushOperation(10),
                    new PushOperation(20),
                    new PushOperation(30),
                    new PushOperation(40),
                    new PushOperation(50),
                    new IncrementOperation(4, 1),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(41),
                    new PopOperation.Result(31),
                    new PopOperation.Result(21),
                    new PopOperation.Result(11),
                    new PopOperation.Result(-1)
                ])
        ];

        yield return
        [
            new StackWithIncrementScenario(
                3,
                [
                    new PushOperation(1),
                    new IncrementOperation(3, 7),
                    new PushOperation(2),
                    new IncrementOperation(1, 3),
                    new PopOperation(),
                    new PopOperation(),
                    new IncrementOperation(2, 2),
                    new PopOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(2),
                    new PopOperation.Result(11),
                    VoidOperationResult.Instance,
                    new PopOperation.Result(-1)
                ])
        ];

        yield return
        [
            new StackWithIncrementScenario(
                2,
                [
                    new PushOperation(1000),
                    new PushOperation(1000),
                    new IncrementOperation(1000, 100),
                    new PopOperation(),
                    new PopOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(1100),
                    new PopOperation.Result(1100)
                ])
        ];

        yield return
        [
            new StackWithIncrementScenario(
                10,
                [
                    new PushOperation(1),
                    new PushOperation(2),
                    new IncrementOperation(1, 10),
                    new IncrementOperation(2, 20),
                    new IncrementOperation(3, 30),
                    new PopOperation(),
                    new PopOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(52),
                    new PopOperation.Result(61)
                ])
        ];

        yield return
        [
            new StackWithIncrementScenario(
                1,
                [
                    new PushOperation(278),
                    new PushOperation(299),
                    new PushOperation(675),
                    new PopOperation(),
                    new PushOperation(478),
                    new PopOperation(),
                    new PopOperation(),
                    new PushOperation(270),
                    new PushOperation(892),
                    new PushOperation(367),
                    new PushOperation(370),
                    new IncrementOperation(3, -59),
                    new IncrementOperation(5, -58),
                    new PushOperation(668)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(278),
                    VoidOperationResult.Instance,
                    new PopOperation.Result(478),
                    new PopOperation.Result(-1),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new StackWithIncrementScenario(
                1,
                [
                    new IncrementOperation(6, -93),
                    new PushOperation(281),
                    new PushOperation(875),
                    new PopOperation(),
                    new PopOperation(),
                    new IncrementOperation(8, 55),
                    new PushOperation(894)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(281),
                    new PopOperation.Result(-1),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new StackWithIncrementScenario(
                6,
                [
                    new IncrementOperation(6, -54),
                    new PushOperation(765),
                    new PopOperation(),
                    new IncrementOperation(4, -31),
                    new PopOperation(),
                    new IncrementOperation(4, 24),
                    new PushOperation(513)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(765),
                    VoidOperationResult.Instance,
                    new PopOperation.Result(-1),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new StackWithIncrementScenario(
                3,
                [
                    new PushOperation(838),
                    new PushOperation(286),
                    new PushOperation(122),
                    new PushOperation(166),
                    new PopOperation(),
                    new PushOperation(703),
                    new IncrementOperation(2, 8)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(122),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new StackWithIncrementScenario(
                4,
                [
                    new IncrementOperation(7, 16),
                    new PushOperation(497),
                    new PopOperation(),
                    new PopOperation(),
                    new PopOperation(),
                    new IncrementOperation(2, -35),
                    new PopOperation(),
                    new PopOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(497),
                    new PopOperation.Result(-1),
                    new PopOperation.Result(-1),
                    VoidOperationResult.Instance,
                    new PopOperation.Result(-1),
                    new PopOperation.Result(-1)
                ])
        ];

        yield return
        [
            new StackWithIncrementScenario(
                2,
                [
                    new IncrementOperation(8, -83),
                    new IncrementOperation(3, 25),
                    new PushOperation(586),
                    new PopOperation(),
                    new PushOperation(846),
                    new PopOperation(),
                    new PopOperation(),
                    new PushOperation(356),
                    new IncrementOperation(6, 20),
                    new PushOperation(365),
                    new PushOperation(543),
                    new PushOperation(44),
                    new IncrementOperation(8, -35)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(586),
                    VoidOperationResult.Instance,
                    new PopOperation.Result(846),
                    new PopOperation.Result(-1),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new StackWithIncrementScenario(
                1,
                [
                    new PushOperation(36),
                    new PushOperation(320),
                    new PushOperation(1),
                    new IncrementOperation(5, 33),
                    new PushOperation(258),
                    new PushOperation(36),
                    new PushOperation(794),
                    new PushOperation(2),
                    new PushOperation(257),
                    new IncrementOperation(5, -54),
                    new PushOperation(213),
                    new IncrementOperation(6, -26)
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
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new StackWithIncrementScenario(
                6,
                [
                    new PushOperation(575),
                    new IncrementOperation(3, 30),
                    new PushOperation(376),
                    new PopOperation(),
                    new PopOperation(),
                    new PushOperation(984),
                    new PopOperation(),
                    new IncrementOperation(6, 24),
                    new IncrementOperation(1, -37),
                    new PopOperation(),
                    new PopOperation()
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(376),
                    new PopOperation.Result(605),
                    VoidOperationResult.Instance,
                    new PopOperation.Result(984),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(-1),
                    new PopOperation.Result(-1)
                ])
        ];

        yield return
        [
            new StackWithIncrementScenario(
                3,
                [
                    new PushOperation(827),
                    new PushOperation(134),
                    new PushOperation(56),
                    new PushOperation(217),
                    new PushOperation(499),
                    new PopOperation(),
                    new PushOperation(558)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(56),
                    VoidOperationResult.Instance
                ])
        ];

        yield return
        [
            new StackWithIncrementScenario(
                4,
                [
                    new PushOperation(263),
                    new PushOperation(555),
                    new PopOperation(),
                    new PopOperation(),
                    new PushOperation(456),
                    new PushOperation(93)
                ],
                [
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance,
                    new PopOperation.Result(555),
                    new PopOperation.Result(263),
                    VoidOperationResult.Instance,
                    VoidOperationResult.Instance
                ])
        ];
    }

    public sealed class StackWithIncrementScenario : IScenario<IDesignStackWithIncrementOperation>
    {
        public StackWithIncrementScenario(
            int maxSize,
            IOperation<IDesignStackWithIncrementOperation>[] operations,
            IOperationResult[] operationResults)
        {
            MaxSize = maxSize;
            Operations = operations;
            OperationResults = operationResults;
        }

        public int MaxSize { get; }

        public IOperation<IDesignStackWithIncrementOperation>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class PushOperation : IOperation<IDesignStackWithIncrementOperation>
    {
        private readonly int _value;

        public PushOperation(int value)
        {
            _value = value;
        }

        public IOperationResult Execute(IDesignStackWithIncrementOperation designStackWithIncrementOperation)
        {
            designStackWithIncrementOperation.Push(_value);

            return VoidOperationResult.Instance;
        }
    }

    private sealed class PopOperation : IOperation<IDesignStackWithIncrementOperation>
    {
        public IOperationResult Execute(IDesignStackWithIncrementOperation designStackWithIncrementOperation)
        {
            var value = designStackWithIncrementOperation.Pop();

            return new Result(value);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly int _value;

            public Result(int value)
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

    private sealed class IncrementOperation : IOperation<IDesignStackWithIncrementOperation>
    {
        private readonly int _k;
        private readonly int _val;

        public IncrementOperation(int k, int val)
        {
            _k = k;
            _val = val;
        }

        public IOperationResult Execute(IDesignStackWithIncrementOperation designStackWithIncrementOperation)
        {
            designStackWithIncrementOperation.Increment(_k, _val);

            return VoidOperationResult.Instance;
        }
    }
}