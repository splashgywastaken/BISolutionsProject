namespace BISolutionsProject.Services.SecondApp.Models;

/// <summary>
/// A model used to transfer data between controller and a service
/// </summary>
public class PalindromCheckModel
{
    /// <summary>
    /// A string to check if it is palindrom or not
    /// </summary>
    public string StringToCheck { get; set; } = null!;
}