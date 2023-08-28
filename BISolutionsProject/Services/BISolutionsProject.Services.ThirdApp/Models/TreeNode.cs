namespace BISolutionsProject.Services.ThirdApp.Models;

/// <summary>
/// Tree implementation
/// </summary>
public class TreeNode
{
    /// <summary>
    /// Data about tree's node
    /// </summary>
    public int Data { get; set; }

    /// <summary>
    /// Left node of a tree
    /// </summary>
    public TreeNode? Left { get; set; }

    /// <summary>
    /// Right node of a tree
    /// </summary>
    public TreeNode? Right { get; set; }

    /// <summary>
    /// Constructor, initializes data for a tree's node
    /// </summary>
    /// <param name="data"></param>
    public TreeNode(int data)
    {
        Data = data;
    }
}