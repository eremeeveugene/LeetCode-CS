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

using LeetCode.Algorithms.DesignAnATMMachine;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.DesignAnATMMachine;

public abstract class DesignAnATMMachineTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void DesignAnATMMachine_WithMixedOperations_ProcessesOperationsAccordingToSpecification(
        IScenario<IDesignAnATMMachine> scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution();

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
        CollectionAssert.AreEqual(expectedResult, actualResult);
    }

    protected abstract IDesignAnATMMachine GetSolution();

    private static IEnumerable<IScenario<IDesignAnATMMachine>[]> GetScenarios()
    {
        yield return
        [
            new Scenario<IDesignAnATMMachine>([
                    new DepositOperation([0, 0, 0, 0, 1]),
                    new WithdrawOperation(500),
                    new WithdrawOperation(500)
                ],
                [
                    new DepositOperationResult(),
                    new WithdrawOperationResult([0, 0, 0, 0, 1]),
                    new WithdrawOperationResult([-1])
                ]
            )
        ];

        yield return
        [
            new Scenario<IDesignAnATMMachine>([
                    new DepositOperation([1, 1, 1, 1, 1]),
                    new WithdrawOperation(870)
                ],
                [
                    new DepositOperationResult(),
                    new WithdrawOperationResult([1, 1, 1, 1, 1])
                ]
            )
        ];

        yield return
        [
            new Scenario<IDesignAnATMMachine>([
                    new DepositOperation([10, 0, 0, 0, 0]),
                    new WithdrawOperation(200)
                ],
                [
                    new DepositOperationResult(),
                    new WithdrawOperationResult([10, 0, 0, 0, 0])
                ]
            )
        ];

        yield return
        [
            new Scenario<IDesignAnATMMachine>([
                    new DepositOperation([0, 0, 2, 0, 0]),
                    new WithdrawOperation(300)
                ],
                [
                    new DepositOperationResult(),
                    new WithdrawOperationResult([-1])
                ]
            )
        ];

        yield return
        [
            new Scenario<IDesignAnATMMachine>([
                    new DepositOperation([0, 1, 1, 0, 0]),
                    new WithdrawOperation(150)
                ],
                [
                    new DepositOperationResult(),
                    new WithdrawOperationResult([0, 1, 1, 0, 0])
                ]
            )
        ];

        yield return
        [
            new Scenario<IDesignAnATMMachine>([
                    new DepositOperation([0, 0, 1, 0, 1]),
                    new WithdrawOperation(700)
                ],
                [
                    new DepositOperationResult(),
                    new WithdrawOperationResult([-1])
                ]
            )
        ];

        yield return
        [
            new Scenario<IDesignAnATMMachine>([
                    new DepositOperation([0, 0, 5, 0, 0]),
                    new WithdrawOperation(500),
                    new WithdrawOperation(100)
                ],
                [
                    new DepositOperationResult(),
                    new WithdrawOperationResult([0, 0, 5, 0, 0]),
                    new WithdrawOperationResult([-1])
                ]
            )
        ];

        yield return
        [
            new Scenario<IDesignAnATMMachine>([
                    new DepositOperation([0, 0, 0, 0, 0]),
                    new WithdrawOperation(20)
                ],
                [
                    new DepositOperationResult(),
                    new WithdrawOperationResult([-1])
                ]
            )
        ];

        yield return
        [
            new Scenario<IDesignAnATMMachine>([
                    new DepositOperation([1, 1, 1, 1, 1]),
                    new WithdrawOperation(20 + 50 + 100 + 200 + 500) // = 870
                ],
                [
                    new DepositOperationResult(),
                    new WithdrawOperationResult([1, 1, 1, 1, 1])
                ]
            )
        ];

        yield return
        [
            new Scenario<IDesignAnATMMachine>([
                    new DepositOperation([1, 0, 0, 0, 0]),
                    new DepositOperation([1, 0, 0, 0, 0]),
                    new WithdrawOperation(20)
                ],
                [
                    new DepositOperationResult(),
                    new DepositOperationResult(),
                    new WithdrawOperationResult([1, 0, 0, 0, 0])
                ]
            )
        ];

        yield return
        [
            new Scenario<IDesignAnATMMachine>([
                    new DepositOperation([0, 0, 0, 2, 0]),
                    new WithdrawOperation(200),
                    new WithdrawOperation(200)
                ],
                [
                    new DepositOperationResult(),
                    new WithdrawOperationResult([0, 0, 0, 1, 0]),
                    new WithdrawOperationResult([0, 0, 0, 1, 0])
                ]
            )
        ];

        yield return
        [
            new Scenario<IDesignAnATMMachine>([
                    new DepositOperation([0, 0, 0, 0, 5]),
                    new WithdrawOperation(300)
                ],
                [
                    new DepositOperationResult(),
                    new WithdrawOperationResult([-1])
                ]
            )
        ];

        yield return
        [
            new Scenario<IDesignAnATMMachine>([
                    new DepositOperation([0, 0, 0, 0, 1]),
                    new WithdrawOperation(300),
                    new WithdrawOperation(500)
                ],
                [
                    new DepositOperationResult(),
                    new WithdrawOperationResult([-1]),
                    new WithdrawOperationResult([0, 0, 0, 0, 1])
                ]
            )
        ];

        yield return
        [
            new Scenario<IDesignAnATMMachine>([
                    new DepositOperation([0, 0, 0, 0, 1]),
                    new WithdrawOperation(500),
                    new DepositOperation([0, 0, 0, 0, 1]),
                    new WithdrawOperation(500)
                ],
                [
                    new DepositOperationResult(),
                    new WithdrawOperationResult([0, 0, 0, 0, 1]),
                    new DepositOperationResult(),
                    new WithdrawOperationResult([0, 0, 0, 0, 1])
                ]
            )
        ];
    }

    private sealed class DepositOperation : IOperation<IDesignAnATMMachine>
    {
        private readonly int[] _banknotesCounts;

        public DepositOperation(int[] banknotesCounts)
        {
            _banknotesCounts = banknotesCounts;
        }

        public IOperationResult Execute(IDesignAnATMMachine designAnATMMachine)
        {
            designAnATMMachine.Deposit(_banknotesCounts);

            return new DepositOperationResult();
        }
    }

    private sealed class WithdrawOperation : IOperation<IDesignAnATMMachine>
    {
        private readonly int _amount;

        public WithdrawOperation(int amount)
        {
            _amount = amount;
        }

        public IOperationResult Execute(IDesignAnATMMachine designAnATMMachine)
        {
            var banknotesCounts = designAnATMMachine.Withdraw(_amount);

            return new WithdrawOperationResult(banknotesCounts);
        }
    }

    private sealed class DepositOperationResult : IOperationResult, IEquatable<DepositOperationResult>
    {
        public bool Equals(DepositOperationResult? other)
        {
            return other is not null;
        }

        public override bool Equals(object? obj)
        {
            return obj is DepositOperationResult other && Equals(other);
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }

    private sealed class WithdrawOperationResult : IOperationResult, IEquatable<WithdrawOperationResult>
    {
        private readonly int[] _banknotesCounts;

        public WithdrawOperationResult(int[] banknotesCounts)
        {
            _banknotesCounts = banknotesCounts;
        }

        public bool Equals(WithdrawOperationResult? other)
        {
            return other is not null && _banknotesCounts.SequenceEqual(other._banknotesCounts);
        }

        public override bool Equals(object? obj)
        {
            return obj is WithdrawOperationResult other && Equals(other);
        }

        public override int GetHashCode()
        {
            var hashCode = new HashCode();

            foreach (var banknotesCount in _banknotesCounts)
            {
                hashCode.Add(banknotesCount);
            }

            return hashCode.ToHashCode();
        }
    }
}