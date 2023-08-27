using BISolutionsProject.Services.SecondApp.Models;
using BISolutionsProject.Services.SecondAppResponse.Models;

namespace BISolutionsProject.Services.SecondAppResponse;

/// <summary>
/// An interface containing definitions for methods for second task reponse service
/// </summary>
public interface ISecondAppResponseService
{
    /// <summary>
    /// Method that generates response data based on what it's given in PalindromCheckModel 
    /// </summary>
    /// <param name="palindromCheckResultModel"></param>
    /// <returns></returns>
    public PalindromCheckResponseModel GeneratePalindromCheckResponse(PalindromCheckResultModel palindromCheckResultModel);
}