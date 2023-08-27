using BISolutionsProject.Services.FirstApp.Models;

namespace BISolutionsProject.Services.FirstApp;

/// <summary>
/// Defenitions for methods for the first app (first task)
/// </summary>
public interface IFirstAppService
{
    /// <summary>
    /// A method used to get a sum of every second even number represented in a ListOfNumbersModel list
    /// </summary>
    /// <param name="list"></param>
    /// <returns></returns>
    public SumOfNumbersModel SumOfEverySecondEvenNumbers(ListOfNumbersModel list);
}