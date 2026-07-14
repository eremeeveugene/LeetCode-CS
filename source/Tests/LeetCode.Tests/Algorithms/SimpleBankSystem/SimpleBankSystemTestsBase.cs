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

using LeetCode.Algorithms.SimpleBankSystem;
using LeetCode.Tests.Base.Scenarios;

namespace LeetCode.Tests.Algorithms.SimpleBankSystem;

public abstract class SimpleBankSystemTestsBase
{
    [TestMethod]
    [DynamicData(nameof(GetScenarios))]
    public void SimpleBankSystem_WithMixedOperations_ProcessesOperationsAccordingToSpecification(BankSystemScenario scenario)
    {
        // Arrange
        var expectedResult = scenario.OperationResults;

        var solution = GetSolution(scenario.Balance);

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

    protected abstract ISimpleBankSystem GetSolution(long[] balance);

    private static IEnumerable<BankSystemScenario[]> GetScenarios()
    {
        yield return
        [
            new BankSystemScenario(
                [10, 100, 20, 50, 30],
                [
                    new WithdrawOperation(3, 10),
                    new TransferOperation(5, 1, 20),
                    new DepositOperation(5, 20),
                    new TransferOperation(3, 4, 15),
                    new WithdrawOperation(5, 50)
                ],
                [
                    new WithdrawOperation.Result(true),
                    new TransferOperation.Result(true),
                    new DepositOperation.Result(true),
                    new TransferOperation.Result(false),
                    new WithdrawOperation.Result(false)
                ])
        ];

        yield return
        [
            new BankSystemScenario(
                [50],
                [new WithdrawOperation(1, 100), new WithdrawOperation(1, 50)],
                [new WithdrawOperation.Result(false), new WithdrawOperation.Result(true)])
        ];

        yield return
        [
            new BankSystemScenario(
                [10, 20],
                [new TransferOperation(1, 2, 50), new TransferOperation(2, 1, 10)],
                [new TransferOperation.Result(false), new TransferOperation.Result(true)])
        ];

        yield return
        [
            new BankSystemScenario(
                [10],
                [new WithdrawOperation(1, 50), new DepositOperation(1, 100), new WithdrawOperation(1, 50)],
                [new WithdrawOperation.Result(false), new DepositOperation.Result(true), new WithdrawOperation.Result(true)])
        ];

        yield return
        [
            new BankSystemScenario(
                [100, 200],
                [new WithdrawOperation(3, 10), new DepositOperation(1, 10), new TransferOperation(1, 3, 10)],
                [new WithdrawOperation.Result(false), new DepositOperation.Result(true), new TransferOperation.Result(false)])
        ];

        yield return [new BankSystemScenario([0], [new DepositOperation(1, 1)], [new DepositOperation.Result(true)])];

        yield return [new BankSystemScenario([1000000000], [new WithdrawOperation(1, 1000000000)], [new WithdrawOperation.Result(true)])];

        yield return
        [
            new BankSystemScenario(
                [100],
                [new WithdrawOperation(1, 0), new DepositOperation(1, 0)],
                [new WithdrawOperation.Result(true), new DepositOperation.Result(true)])
        ];

        yield return
        [
            new BankSystemScenario(
                [50, 50, 50],
                [new TransferOperation(1, 3, 50), new TransferOperation(3, 2, 100)],
                [new TransferOperation.Result(true), new TransferOperation.Result(true)])
        ];

        yield return [new BankSystemScenario([100, 200, 300], [new WithdrawOperation(4, 10)], [new WithdrawOperation.Result(false)])];

        yield return [new BankSystemScenario([100, 200, 300], [new DepositOperation(4, 10)], [new DepositOperation.Result(false)])];

        yield return [new BankSystemScenario([100, 200, 300], [new TransferOperation(1, 1, 10)], [new TransferOperation.Result(true)])];

        yield return
        [
            new BankSystemScenario(
                [500],
                [new DepositOperation(1, 500), new WithdrawOperation(1, 1000)],
                [new DepositOperation.Result(true), new WithdrawOperation.Result(true)])
        ];

        yield return
        [
            new BankSystemScenario(
                [10, 20, 30],
                [new WithdrawOperation(1, 10), new WithdrawOperation(2, 10), new WithdrawOperation(3, 10)],
                [new WithdrawOperation.Result(true), new WithdrawOperation.Result(true), new WithdrawOperation.Result(true)])
        ];

        yield return
        [
            new BankSystemScenario(
                [100, 200],
                [new TransferOperation(2, 1, 200), new WithdrawOperation(1, 300)],
                [new TransferOperation.Result(true), new WithdrawOperation.Result(true)])
        ];

        yield return
        [
            new BankSystemScenario(
                [1, 1, 1],
                [new TransferOperation(1, 2, 1), new TransferOperation(2, 3, 2), new WithdrawOperation(3, 2)],
                [new TransferOperation.Result(true), new TransferOperation.Result(true), new WithdrawOperation.Result(true)])
        ];

        yield return
        [
            new BankSystemScenario(
                [100],
                [new WithdrawOperation(1, 100), new DepositOperation(1, 50), new WithdrawOperation(1, 50)],
                [new WithdrawOperation.Result(true), new DepositOperation.Result(true), new WithdrawOperation.Result(true)])
        ];

        yield return
        [
            new BankSystemScenario(
                [300, 100],
                [new TransferOperation(1, 2, 100), new TransferOperation(2, 1, 200), new WithdrawOperation(1, 400)],
                [new TransferOperation.Result(true), new TransferOperation.Result(true), new WithdrawOperation.Result(true)])
        ];

        yield return
        [
            new BankSystemScenario(
                [50, 50],
                [new WithdrawOperation(1, 51), new DepositOperation(2, 100), new TransferOperation(2, 1, 150)],
                [new WithdrawOperation.Result(false), new DepositOperation.Result(true), new TransferOperation.Result(true)])
        ];
    }

    public sealed class BankSystemScenario : IScenario<ISimpleBankSystem>
    {
        public BankSystemScenario(long[] balance, IOperation<ISimpleBankSystem>[] operations, IOperationResult[] operationResults)
        {
            Balance = balance;
            Operations = operations;
            OperationResults = operationResults;
        }

        public long[] Balance { get; }

        public IOperation<ISimpleBankSystem>[] Operations { get; }

        public IOperationResult[] OperationResults { get; }
    }

    private sealed class TransferOperation : IOperation<ISimpleBankSystem>
    {
        private readonly int _account1;
        private readonly int _account2;
        private readonly long _money;

        public TransferOperation(int account1, int account2, long money)
        {
            _account1 = account1;
            _account2 = account2;
            _money = money;
        }

        public IOperationResult Execute(ISimpleBankSystem simpleBankSystem)
        {
            var result = simpleBankSystem.Transfer(_account1, _account2, _money);

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _success;

            public Result(bool success)
            {
                _success = success;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _success == other._success;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_success);
            }
        }
    }

    private sealed class DepositOperation : IOperation<ISimpleBankSystem>
    {
        private readonly int _account;
        private readonly long _money;

        public DepositOperation(int account, long money)
        {
            _account = account;
            _money = money;
        }

        public IOperationResult Execute(ISimpleBankSystem simpleBankSystem)
        {
            var result = simpleBankSystem.Deposit(_account, _money);

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _success;

            public Result(bool success)
            {
                _success = success;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _success == other._success;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_success);
            }
        }
    }

    private sealed class WithdrawOperation : IOperation<ISimpleBankSystem>
    {
        private readonly int _account;
        private readonly long _money;

        public WithdrawOperation(int account, long money)
        {
            _account = account;
            _money = money;
        }

        public IOperationResult Execute(ISimpleBankSystem simpleBankSystem)
        {
            var result = simpleBankSystem.Withdraw(_account, _money);

            return new Result(result);
        }

        public sealed class Result
            : IOperationResult,
                IEquatable<Result>
        {
            private readonly bool _success;

            public Result(bool success)
            {
                _success = success;
            }

            public bool Equals(Result? other)
            {
                return other is not null && _success == other._success;
            }

            public override bool Equals(object? obj)
            {
                return obj is Result other && Equals(other);
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(_success);
            }
        }
    }
}