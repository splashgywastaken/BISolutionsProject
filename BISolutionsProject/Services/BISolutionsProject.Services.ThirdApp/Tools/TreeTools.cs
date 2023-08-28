using BISolutionsProject.Services.ThirdApp.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BISolutionsProject.Services.ThirdApp.Tools;

/// <summary>
/// Class dedicated to tools used for trees
/// </summary>
public static class TreeTools
{
    /// <summary>
    /// Iterativly adds new node to a tree
    /// </summary>
    /// <param name="originalNode"></param>
    /// <param name="node"></param>
    public static void Insert(this TreeNode originalNode, TreeNode node)
    {
        while (true)
        {
            if (node.Data < originalNode.Data)
            {
                if (originalNode.Left == null)
                {
                    originalNode.Left = node;
                }
                else
                {
                    originalNode = originalNode.Left;
                    continue;
                }
            }
            else
            {
                if (originalNode.Right == null)
                {
                    originalNode.Right = node;
                }
                else
                {
                    originalNode = originalNode.Right;
                    continue;
                }
            }

            break;
        }
    }

    /// <summary>
    /// Conversion tree to an array
    /// </summary>
    /// <param name="originalNode"></param>
    /// <param name="elements"></param>
    /// <returns></returns>
    public static IEnumerable<int> Transform(this TreeNode originalNode, List<int>? elements = null)
    {
        elements ??= new List<int>();
        originalNode.Left?.Transform(elements);
        elements.Add(originalNode.Data);
        originalNode.Right?.Transform(elements);

        return elements;
    }

    /// <summary>
    /// Method sort using binary tree
    /// </summary>
    /// <param name="array"></param>
    /// <returns></returns>
    public static IEnumerable<int> TreeSort(IList<int> array)
    {
        var treeNode = new TreeNode(array[0]);
        for (var index = 1; index < array.Count; index++)
        {
            treeNode.Insert(new TreeNode(array[index]));
        }

        return treeNode.Transform();
    }
}