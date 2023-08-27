using BISolutionsProject.Services.SecondApp.Models;

namespace BISolutionsProject.Services.SecondApp;

/// <summary>
/// Contains defenitions for methods for second task
/// </summary>
public interface ISecondAppService
{
    /// <summary>
    /// A method used to check if a string in PalindromCheckModel is palindrom or not
    /// </summary>
    /// <param name="palindromCheckModel"></param>
    /// <returns></returns>
    public PalindromCheckResultModel CheckStringForPalindrom(PalindromCheckModel palindromCheckModel);
}