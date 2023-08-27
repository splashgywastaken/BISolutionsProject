namespace BISolutionsProject.Services.SecondAppResponse.Models;

/// <summary>
/// A model used to keep data from generated response
/// </summary>
public class PalindromCheckResponseModel
{
    /// <summary>
    /// A message for check process
    /// </summary>
    public string Message { get; set; } = null!;
    /// <summary>
    /// A boolean value used to determine if a string is palindrom or not
    /// </summary>
    public bool IsPalindrom { get; set; }
}