using AutoMapper;
using BISolutionsProject.Services.FirstApp.Models;

namespace BISolutionsProject.Services.FirstAppResponse.Models;

/// <summary>
/// Model used for delivering responses based on ListOfNumbersModel
/// </summary>
public class SumOfNumbersResponseModel
{
    /// <summary>
    /// Sum of numbers itself
    /// </summary>
    public int SumOfNumbers { get; set; }
}

/// <summary>
/// Pofile for ListOfNumbersResponseModel mapping
/// </summary>
public class SumOfNumbersResponseModelProfile : Profile
{
    /// <summary>
    /// A constructor with defenitions for mapping profiles
    /// </summary>
    public SumOfNumbersResponseModelProfile()
    {
        CreateMap<SumOfNumbersModel, SumOfNumbersResponseModel>();
        CreateMap<SumOfNumbersResponseModel, SumOfNumbersModel>();
    }
}