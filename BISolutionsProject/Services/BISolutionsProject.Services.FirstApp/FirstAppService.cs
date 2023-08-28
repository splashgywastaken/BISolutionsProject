using BISolutionsProject.Services.FirstApp.Models;

namespace BISolutionsProject.Services.FirstApp;

/// <summary>
/// A class with implementations of methods from IFirstAppService,
/// mainly it implements only one function used to get a specific sum of numbers
/// </summary>
public class FirstAppService : IFirstAppService
{
    /// <inheritdoc />
    public SumOfNumbersModel SumOfEverySecondEvenNumbers(ListOfNumbersModel list)
    {
        var counter = 0;
        var sumOfNumbers = list.ListOfNumbers.Sum(val =>
        {
            if (val % 2 != 0 || val == 0) return 0;
            counter++;
            if (counter - 2 != 0) return 0;
            counter = 0;
            return val;
        });

        return new SumOfNumbersModel
        {
            SumOfNumbers = sumOfNumbers
        };
    }
}