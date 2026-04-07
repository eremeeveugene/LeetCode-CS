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

/// <summary>
///     Represents a self-contained test scenario for a given solution type.
///     A scenario defines a sequence of operations to execute and the expected
///     results they should produce.
/// </summary>
/// <typeparam name="TSolution">
///     The solution interface under test. Operations are executed against an instance of this type.
/// </typeparam>
public interface IScenario<in TSolution>
{
    /// <summary>
    ///     Gets the ordered sequence of operations to execute against the solution.
    /// </summary>
    IOperation<TSolution>[] Operations { get; }

    /// <summary>
    ///     Gets the expected results corresponding to each operation in <see cref="Operations" />.
    ///     The element at index <c>i</c> is the expected outcome of <c>Operations[i]</c>.
    /// </summary>
    IOperationResult[] OperationResults { get; }
}