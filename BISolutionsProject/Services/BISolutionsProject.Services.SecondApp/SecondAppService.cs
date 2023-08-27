using BISolutionsProject.Services.SecondApp.Models;

namespace BISolutionsProject.Services.SecondApp;

/// <summary>
/// Contains implementations of methods in ISecondAppService
/// </summary>
public class SecondAppService : ISecondAppService
{
    /// <inheritdoc />
    public PalindromCheckResultModel CheckStringForPalindrom(PalindromCheckModel palindromCheckModel)
    {
        var stringToCheck = palindromCheckModel.StringToCheck;
        for (var index = 0; index < stringToCheck.Length / 2; index++)
        {
            if (stringToCheck[index] != stringToCheck[stringToCheck.Length - index - 1])
                return new PalindromCheckResultModel
                {
                    IsPalindrom = false
                };
        }

        return new PalindromCheckResultModel
        {
            IsPalindrom = true
        };
    }
}