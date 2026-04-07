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
///     An executable step in a test scenario that produces a result.
/// </summary>
/// <typeparam name="TSolution">
///     The solution type this operation executes against.
/// </typeparam>
public interface IOperation<in TSolution>
{
    /// <summary>
    ///     Executes this operation against the provided solution and returns the outcome.
    /// </summary>
    /// <param name="solution">The solution instance to execute the operation against.</param>
    /// <returns>
    ///     An <see cref="IOperationResult" /> representing the outcome of the operation.
    /// </returns>
    IOperationResult Execute(TSolution solution);
}