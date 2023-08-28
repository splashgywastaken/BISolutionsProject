namespace BISolutionsProject.Services.ThirdApp.Models;

/// <summary>
/// Model used to return data back to the controller
/// </summary>
public class SortedListModel
{
    /// <summary>
    /// Sorted list itself
    /// </summary>
    public IEnumerable<int> List { get; set; } = null!;
}