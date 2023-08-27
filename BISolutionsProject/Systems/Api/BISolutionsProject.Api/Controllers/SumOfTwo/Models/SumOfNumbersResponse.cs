using AutoMapper;
using BISolutionsProject.Services.FirstApp.Models;
using BISolutionsProject.Services.FirstAppResponse.Models;

namespace BISolutionsProject.Api.Controllers.SumOfTwo.Models;

/// <summary>
/// Model used for response in controller
/// </summary>
public class SumOfNumbersResponse
{
    /// <summary>
    /// Sum of numbers itself
    /// </summary>
    public int SumOfNumbers { get; set; }
}

/// <summary>
/// Pofile for ListOfNumbersResponseModel mapping
/// </summary>
public class SumOfNumbersResponseProfile : Profile
{
    /// <summary>
    /// A constructor with defenitions for mapping profiles
    /// </summary>
    public SumOfNumbersResponseProfile()
    {
        CreateMap<SumOfNumbersResponse, SumOfNumbersResponseModel>();
        CreateMap<SumOfNumbersResponseModel, SumOfNumbersResponse>();
    }
}