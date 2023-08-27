using AutoMapper;

namespace BISolutionsProject.Services.FirstApp.Models;

/// <summary>
/// Model used to transfer data about sum of numbers
/// </summary>
public class SumOfNumbersModel
{
    /// <summary>
    /// Sum of numbers itself
    /// </summary>
    public int SumOfNumbers { get; set; }
}

/// <summary>
/// Profile for SumOfNumbersModel mapping 
/// </summary>
public class SumOfNumbersModelProfile : Profile
{
    /// <summary>
    /// Constructor with defenitions for mapping
    /// </summary>
    public SumOfNumbersModelProfile()
    {
    }
}