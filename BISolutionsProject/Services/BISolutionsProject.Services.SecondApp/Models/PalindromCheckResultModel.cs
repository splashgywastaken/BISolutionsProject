namespace BISolutionsProject.Services.SecondApp.Models;

/// <summary>
/// A model used to transfer data between controller and a service
/// </summary>
public class PalindromCheckResultModel
{
    /// <summary>
    /// A boolean value used to determine if a string is palindrom or not
    /// </summary>
    public bool IsPalindrom { get; set; }
}