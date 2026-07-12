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

namespace LeetCode.Algorithms.RemoveSubFoldersFromTheFilesystem;

/// <summary>
///     https://leetcode.com/problems/remove-sub-folders-from-the-filesystem/description/
/// </summary>
public interface IRemoveSubFoldersFromTheFilesystem
{
    /// <summary>
    ///     Removes every folder in <paramref name="folders" /> that is a sub-folder of another folder in the list.
    /// </summary>
    /// <param name="folders">The array of absolute folder paths.</param>
    /// <returns>The list of folders remaining after all sub-folders have been removed.</returns>
    IList<string> RemoveSubfolders(string[] folders);
}