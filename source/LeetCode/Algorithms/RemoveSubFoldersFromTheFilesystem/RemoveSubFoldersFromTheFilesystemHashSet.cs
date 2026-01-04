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

/// <inheritdoc />
public class RemoveSubFoldersFromTheFilesystemHashSet : IRemoveSubFoldersFromTheFilesystem
{
    /// <summary>
    ///     Time complexity - O(n * m^2)
    ///     Space complexity - O(n)
    /// </summary>
    /// <param name="folders"></param>
    /// <returns></returns>
    public IList<string> RemoveSubfolders(string[] folders)
    {
        var result = new List<string>();

        var foldersHashSet = new HashSet<string>(folders);

        foreach (var folder in folders)
        {
            var i = 1;
            var add = true;

            while (i < folder.Length)
            {
                if (folder[i] is '/' && foldersHashSet.Contains(folder[..i]))
                {
                    add = false;

                    break;
                }

                i++;
            }

            if (add)
            {
                result.Add(folder);
            }
        }

        return result;
    }
}