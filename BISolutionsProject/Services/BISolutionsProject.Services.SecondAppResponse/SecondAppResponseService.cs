using System.Text;
using BISolutionsProject.Services.SecondApp.Models;
using BISolutionsProject.Services.SecondAppResponse.Models;

namespace BISolutionsProject.Services.SecondAppResponse;

/// <summary>
/// A class containing implementations of methods from ISecondAppResponseService interface
/// </summary>
public class SecondAppResponseService : ISecondAppResponseService
{
    /// <inheritdoc />
    public PalindromCheckResponseModel GeneratePalindromCheckResponse(PalindromCheckResultModel palindromCheckResultModel)
    {
        var sb = new StringBuilder();
        sb.Append("A string ");
        sb.Append(palindromCheckResultModel.IsPalindrom ? "is" : "is not");
        sb.Append(" a palindrom");
        return new PalindromCheckResponseModel
        {
            Message = sb.ToString(),
            IsPalindrom = palindromCheckResultModel.IsPalindrom
        };
    }
}