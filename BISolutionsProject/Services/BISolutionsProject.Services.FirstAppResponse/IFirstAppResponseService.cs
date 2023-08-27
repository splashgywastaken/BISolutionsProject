using BISolutionsProject.Services.FirstApp.Models;
using BISolutionsProject.Services.FirstAppResponse.Models;

namespace BISolutionsProject.Services.FirstAppResponse;

/// <summary>
/// Contains defenitions for response methods for First App service
/// </summary>
public interface IFirstAppResponseService
{
    /// <summary>
    /// Method used to generate response for sum of numbers
    /// </summary>
    /// <param name="sumOfNumbers"></param>
    /// <returns></returns>
    public SumOfNumbersResponseModel GenerateResponseForSumOfNumbers(SumOfNumbersModel sumOfNumbers);
}