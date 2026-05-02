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

namespace LeetCode.Tests.Base.Scenarios;

/// <inheritdoc />
public sealed class Scenario<TSolution> : IScenario<TSolution>
{
    public Scenario(IOperation<TSolution>[] operations, IOperationResult[] operationResults)
    {
        Operations = operations;
        OperationResults = operationResults;
    }

    /// <inheritdoc />
    public IOperation<TSolution>[] Operations { get; }

    /// <inheritdoc />
    public IOperationResult[] OperationResults { get; }
}