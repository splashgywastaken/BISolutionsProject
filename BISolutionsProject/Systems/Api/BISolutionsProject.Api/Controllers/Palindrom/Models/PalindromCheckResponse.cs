using AutoMapper;
using BISolutionsProject.Services.SecondAppResponse.Models;

namespace BISolutionsProject.Api.Controllers.Palindrom.Models;

/// <summary>
/// A model used to return data from controller method
/// </summary>
public class PalindromCheckResponse
{
    /// <summary>
    /// A message for check process
    /// </summary>
    public string Message { get; set; } = null!;
    /// <summary>
    /// A boolean value used to determine if a string is palindrom or not
    /// </summary>
    public bool IsPalindrom { get; set; }
}

/// <summary>
/// Mapper profile class for PalindromCheckResponse
/// </summary>
public class PalindromCheckResponseProfile : Profile
{
    /// <summary>
    /// Constructor with mapping defenitions
    /// </summary>
    public PalindromCheckResponseProfile()
    {
        CreateMap<PalindromCheckResponseModel, PalindromCheckResponse>();
    }
}